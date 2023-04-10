using AutoMapper;
using Light.Core.AutoMapper;
using Light.Data.DataAccess;
using Light.Data.DataAccess.Ef;
using Light.Logic.Services;
using Light.Logic.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Light.AppConfig.Extensions
{
    public static class ServiceExtension
    {
        public static void AddDatabase(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, EfUnitOfWork>();
        }
        public static void AddMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IOneCService, OneCService>();
            services.AddScoped<ICashBoxService, CashBoxService>();
        }
    }
}
