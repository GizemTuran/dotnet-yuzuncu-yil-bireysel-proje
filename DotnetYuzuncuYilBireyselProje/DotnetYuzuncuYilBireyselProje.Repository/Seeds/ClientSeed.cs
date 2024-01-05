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
    public class ClientSeed : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData(
                new Client { Id = 1, ClientName = "Gizem", Email = "gizemturan@gmail.com", Password = "123456", StoreId = 1 },
                new Client { Id = 2, ClientName = "Ecem", Email = "ecemturan@gmail.com", Password = "564821", StoreId = 2 },
                new Client { Id = 3, ClientName = "Burcu", Email = "burcudag@gmail.com", Password = "546218", StoreId = 3 },
                new Client { Id = 4, ClientName = "Bahar", Email = "baharkoc@gmail.com", Password = "9856124", StoreId = 4 }
                );
        }
    }
}
