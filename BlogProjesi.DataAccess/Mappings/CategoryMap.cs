using BlogProjesi.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjesi.DataAccess.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Data Seed'leme --- Manuel Test Datası
            builder.HasData(new Category
            {
                
                Id = Guid.Parse("0ADC455E-C18E-47D1-A5C0-B808227D78CF"),
                Name = "Asp.Net Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category 
            {
                
                Id = Guid.Parse("8CAA2C38-F5F2-451A-871F-35E1BCF2FB77"),
                Name = "Visual Studio 2022",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
               
            });
            
        }
    }
}
