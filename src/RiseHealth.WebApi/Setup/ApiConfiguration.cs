﻿using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RiseHealth.WebApi.Filters;
using RiseHealth.WebApi.Services.Management;
using RiseHealth.WebApi.Setup.AutoMapper;
using RiseHealthCare.Infrastructure;
using RiseHealthCare.Infrastructure.Mediator;

namespace RiseHealth.WebApi.Setup
{
    public static class ApiConfiguration
    {
        public static IServiceCollection ApiConfig(this IServiceCollection services, IConfiguration configuration)
        {
            //Contexts Dbs
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //AutoMapper
            services.AddAutoMapper(typeof(DtoProfile), typeof(ViewModelProfile));

            //Versioning
            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VV";
                options.SubstituteApiVersionInUrl = true;
            });

            //Filters
            services.AddMvc(options => options.Filters.Add(typeof(ModelStateValidatorFilter)))
                .AddFluentValidation(fv =>
                    fv.RegisterValidatorsFromAssemblyContaining<Startup>());

            //Mediator
            services.AddMediatR(typeof(Startup));
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            //Services
            services.AddScoped<IProfessionalPersistenceService, ProfessionalPersistenceService>();

            return services;
        }
    }
}