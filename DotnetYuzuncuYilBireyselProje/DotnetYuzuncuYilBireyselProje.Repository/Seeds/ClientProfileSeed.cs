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
    public class ClientProfileSeed : IEntityTypeConfiguration<ClientProfile>
    {
        public void Configure(EntityTypeBuilder<ClientProfile> builder)
        {
            builder.HasData(
                
                new ClientProfile { Id=1,FirstName="Gizem",LastName="Turan",ClientId=1},
                new ClientProfile { Id=2,FirstName="Ecem",LastName="Turan",ClientId=2},
                new ClientProfile { Id=3,FirstName="Burcu",LastName="Dağ",ClientId=3},
                new ClientProfile { Id=4,FirstName="Bahar",LastName="Koç",ClientId=4}
                );
        }
    }
}
