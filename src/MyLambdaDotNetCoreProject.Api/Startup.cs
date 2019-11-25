﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using MediatR;
using MyLambdaDotNetCoreProject.Application.Query;
using MyLambdaDotNetCoreProject.Infrastructure.Query;
using MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate;
using MyLambdaDotNetCoreProject.Infrastructure.Repository;
using AutoMapper;

namespace MyLambdaDotNetCoreProject.Api
{
    class Startup
    {
        public static IServiceCollection BuildContainer()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddEnvironmentVariables()
              //template parameter used
              .AddJsonFile($"appsettings.{System.Environment.GetEnvironmentVariable("appsetting")}.json")
              .Build();

            return ConfigureServices(configuration);
        }

        //dependency injection and other application service configurations
        private static IServiceCollection ConfigureServices(IConfigurationRoot configurationRoot)
        {
            var services = new ServiceCollection();

            services
              .AddMediatR(typeof(GetEntity1RequestHandler).Assembly)
              .AddAutoMapper(typeof(Startup).Assembly)
              .AddScoped<IEntity1Query,Entity1Query>()
              .AddScoped<IEntity1Repository, Entity1Repository>()
              ;
              //.AddTransient(typeof(IAwsClientFactory<>), typeof(AwsClientFactory<>))
              //.AddTransient<IItemRepository, ItemDynamoRepository>()
            return services;
        }
    }
}
