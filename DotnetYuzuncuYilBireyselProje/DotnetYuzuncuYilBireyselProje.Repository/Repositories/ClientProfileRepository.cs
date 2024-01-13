using DotnetYuzuncuYilBireyselProje.Core.Models;
using DotnetYuzuncuYilBireyselProje.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Repository.Repositories
{
    public class ClientProfileRepository : GenericRepository<ClientProfile>, IClientProfileRepository
    {
        public ClientProfileRepository(AppDbContext context) : base(context)
        {

        }
    }
}
