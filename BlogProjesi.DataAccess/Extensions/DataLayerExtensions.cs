using BlogProjesi.DataAccess.Context;
using BlogProjesi.DataAccess.Repositories.Abstract;
using BlogProjesi.DataAccess.Repositories.Concrete;
using BlogProjesi.DataAccess.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjesi.DataAccess.Extensions
{
    public static class DataLayerExtensions
    {
        //Extension sayesinde program.cs dosyalarına fazla addscoped eklememiş olduk.
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
