using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rema1000.Shared.Models
{
    public class Supplier : BaseModel
    {
        public string? Address { get; set; }
        public int? PostalCode { get; set; }
        public string? ContactPerson { get; set; }
        public string? Email { get; set; }
        public int? PhoneNumber { get; set; }
    }
}
