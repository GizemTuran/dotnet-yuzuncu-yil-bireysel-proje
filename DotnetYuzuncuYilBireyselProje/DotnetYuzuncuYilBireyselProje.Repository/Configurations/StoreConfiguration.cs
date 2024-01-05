using DotnetYuzuncuYilBireyselProje.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Repository.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Id)
               .UseIdentityColumn();

            builder.Property(t => t.StoreName)
                .HasMaxLength(50)
                .IsRequired();

            builder.ToTable("Stores");
        }
    }
}
