using DotnetYuzuncuYilBireyselProje.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Repository.Seeds
{
    public class StoreSeed : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasData(

                new Store { Id = 1, StoreName = "Zara", CreatedDate = DateTime.Now },
                new Store { Id = 2, StoreName = "Mango", CreatedDate = DateTime.Now },
                new Store { Id = 3, StoreName = "Stradivarious", CreatedDate = DateTime.Now },
                new Store { Id = 4, StoreName = "Bershka", CreatedDate = DateTime.Now }

                );
        }
    }
}
