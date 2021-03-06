using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rema1000.Shared.Models
{
    public abstract class BaseModel
    {
        // base model for all 3 classes, to reduce redundancy.
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
    }
}
