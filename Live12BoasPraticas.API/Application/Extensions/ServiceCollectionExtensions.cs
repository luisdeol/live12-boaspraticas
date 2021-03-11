using Live12BoasPraticas.API.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Live12BoasPraticas.API.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IPeopleService, PeopleService>();

            return services;
        }
    }
}
