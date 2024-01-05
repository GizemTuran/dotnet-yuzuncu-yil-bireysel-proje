using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Core.Models
{
    public class Store : BaseEntity
    {
        public string StoreName;

        public ICollection<ClientProfile> Client { get; set; }
    }
}
