using EverSoftSupplier.Application.Interfaces;
using EverSoftSupplier.Application.Mappings;
using EverSoftSupplier.Application.Services;
using EverSoftSupplier.Domain.Interfaces;
using EverSoftSupplier.Infra.Data.Context;
using EverSoftSupplier.Infra.Data.Repository;
using EverSoftSupplier.Infrastructure.Data.Interfaces;
using EverSoftSupplier.Infrastructure.Data.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services
                .AddDbContext<ApplicationDbContext>(opt => 
                    opt.UseSqlite(configuration["sqlite"],
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            var myHandlers = AppDomain.CurrentDomain.Load("EverSoftSupplier.Application");
            services.AddMediatR(myHandlers);

            return services;
        }
    }
}
