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
using Newtonsoft;
using Repository;

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
            services.AddScoped<IAuthenticationManager, AuthenticationManager>();
            services.ConfigureSqlContext(Configuration);
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers(config => {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
            }).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters().AddCustomCSVFormatter();
            services.AddAuthentication();
            services.ConfigureIdentity();
            services.ConfigureSwagger();
        }
    

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
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Code Maze API v1");
            });
        }

        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress,
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
                CreateMap<Employees, EmployeeDto>();
                CreateMap<Order, OrderDto>();
                CreateMap<ContentOfOrder, ContentOfOrderDto>();
                CreateMap<CompanyForCreationDto, Company>();
                CreateMap<ContentOfOrderForCreationDto, ContentOfOrder>();
                CreateMap<OrderForCreationDto, Order>();
                CreateMap<EmployeeForUpdateDto, Employees>();
                CreateMap<CompanyForUpdateDto, Company>();
                CreateMap<OrderForCreationDto, Order>();
                CreateMap<ContentOfOrderDto, ContentOfOrder>();
                CreateMap<EmployeeForUpdateDto, Employees>().ReverseMap();
                CreateMap<CompanyForUpdateDto, Company>().ReverseMap();
                CreateMap<ContentOfOrderForUpdateDto, ContentOfOrder>().ReverseMap();
                CreateMap<OrderForUpdateDto, Order>().ReverseMap();
                CreateMap<UserForRegistrationDto, User>();
            }
        }
    }
}
