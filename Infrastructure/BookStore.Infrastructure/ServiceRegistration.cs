using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Abstractions.Services.Configurations;
using BookStore.Application.Abstractions.Storage;
using BookStore.Application.Abstractions.Token;
using BookStore.Application.Services;
using BookStore.Infrastructure.Enums;
using BookStore.Infrastructure.Services;
using BookStore.Infrastructure.Services.Configurations;
using BookStore.Infrastructure.Services.Storage;
using BookStore.Infrastructure.Services.Storage.Local;
using BookStore.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<ITokenHandler, TokenHandler>();
            services.AddHttpClient();
            services.AddScoped<IApplicationService, ApplicationService>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
            serviceCollection.AddScoped<IStorageService, StorageService>();

        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    break;
                case StorageType.AWS:

                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}