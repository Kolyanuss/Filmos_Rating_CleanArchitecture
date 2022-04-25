﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Filmos_Rating_CleanArchitecture.Application.Common.Interfaces;

namespace Filmos_Rating_CleanArchitecture.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            /*services.AddDbContext<FilmosDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("NorthwindDatabase")));*/

            services.AddScoped<IFilmosDbContext>(provider => provider.GetService<FilmosDbContext>());

            return services;
        }
    }
}
