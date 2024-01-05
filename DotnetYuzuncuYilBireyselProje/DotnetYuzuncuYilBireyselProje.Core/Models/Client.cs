using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilBireyselProje.Core.Models
{
    public class Client : BaseEntity
    {
        public string ClientName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int StoreId { get; set; }
        public Store store { get; set; }
    }
}
