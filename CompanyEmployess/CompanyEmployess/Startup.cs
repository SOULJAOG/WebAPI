using AutoMapper;
using CompanyEmployees.Extensions;
using CompanyEmployess.Extensions;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using System.IO;
<<<<<<< HEAD
=======
using Newtonsoft;
>>>>>>> lab6

namespace CompanyEmployess
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),"/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.ConfigureLoggerService();
            services.ConfigureSqlContext(Configuration);
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        }
=======
=======
>>>>>>> lab5
            services.AddControllers(config => {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
            }).AddXmlDataContractSerializerFormatters().AddCustomCSVFormatter();
        }
    
<<<<<<< HEAD
>>>>>>> lab4
=======
>>>>>>> lab5
=======
            services.AddControllers(config => {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
            }).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters().AddCustomCSVFormatter();
        }
    
>>>>>>> lab6

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerManager logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseCors("CorsPolicy");
            app.ConfigureExceptionHandler(logger);
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress,
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
                CreateMap<Employees, EmployeeDto>();
>>>>>>> lab4
                CreateMap<Order, OrderDto>();
                CreateMap<ContentOfOrder, ContentOfOrderDto>();
=======
=======
>>>>>>> lab6
                CreateMap<Employees, EmployeeDto>();
                CreateMap<Order, OrderDto>();
                CreateMap<ContentOfOrder, ContentOfOrderDto>();
                CreateMap<CompanyForCreationDto, Company>();
                CreateMap<ContentOfOrderForCreationDto, ContentOfOrder>();
                CreateMap<OrderForCreationDto, Order>();
<<<<<<< HEAD
>>>>>>> lab5
=======
                CreateMap<EmployeeForUpdateDto, Employees>();
                CreateMap<CompanyForUpdateDto, Company>();
                CreateMap<OrderForCreationDto, Order>();
                CreateMap<ContentOfOrderDto, ContentOfOrder>();
                CreateMap<EmployeeForUpdateDto, Employees>().ReverseMap();
                CreateMap<CompanyForUpdateDto, Company>().ReverseMap();
                CreateMap<ContentOfOrderForUpdateDto, ContentOfOrder>().ReverseMap();
                CreateMap<OrderForUpdateDto, Order>().ReverseMap();
>>>>>>> lab6
            }
        }
    }
}
