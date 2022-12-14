<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using Contracts;
=======
﻿using CompanyEmployees;
using Contracts;
>>>>>>> lab4
=======
﻿using CompanyEmployees;
using Contracts;
>>>>>>> lab5
=======
﻿using CompanyEmployees;
using Contracts;
>>>>>>> lab6
using Entities;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployess.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts => 
                opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("CompanyEmployess")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

        public static IMvcBuilder AddCustomCSVFormatter(this IMvcBuilder builder) =>
         builder.AddMvcOptions(config => config.OutputFormatters.Add(new CsvOutputFormatter()));
>>>>>>> lab4
=======

        public static IMvcBuilder AddCustomCSVFormatter(this IMvcBuilder builder) =>
         builder.AddMvcOptions(config => config.OutputFormatters.Add(new CsvOutputFormatter()));
>>>>>>> lab5
=======

        public static IMvcBuilder AddCustomCSVFormatter(this IMvcBuilder builder) =>
         builder.AddMvcOptions(config => config.OutputFormatters.Add(new CsvOutputFormatter()));
>>>>>>> lab6
    }
}
