using DotnetYuzuncuYilBireyselProje.Core.Models;
using DotnetYuzuncuYilBireyselProje.Core.Repository;
using DotnetYuzuncuYilBireyselProje.Core.Services;
using DotnetYuzuncuYilBireyselProje.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Service.Services
{
    public class ClientService : Service<Client>, IClientService
    {
        public ClientService(IGenericRepository<Client> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
