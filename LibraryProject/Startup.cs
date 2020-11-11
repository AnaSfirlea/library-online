using AutoMapper;
using LibraryProject.Entities;
using LibraryProject.Repositories;
using LibraryProject.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using LibraryProject.Services;

namespace LibraryProject
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddMvcOptions(o =>
                {
                    o.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                });

            var connectionString = configuration["connectionStrings:DefaultConnection"];
        
            services.AddDbContext<AppDbContext>(o =>
            {
                o.UseSqlServer(connectionString);
            });

            services.AddScoped<IGenreRepository, GenreRepository>();

            services.AddScoped<IBookRepository, BookRepository>();

            services.AddScoped<IGenreService, GenreService>();

            services.AddScoped<IBookService, BookService>();

            services.AddScoped<IAuthorRepository, AuthorRepository>();

            services.AddScoped<IAuthorService, AuthorService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddCors(options =>
            {
                options.AddPolicy("DefaultPolicy",
                builder =>
                {
                    builder.WithOrigins("http://localhost:59880");
                    builder.WithOrigins("http://localhost:3000");
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseCors("DefaultPolicy");

            app.UseStatusCodePages();
            app.UseMvc();

        }
    }
}

