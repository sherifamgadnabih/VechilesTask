using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechiles.Models
{
    public class Vechile
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string RegNr { get; set; }
        public bool Status { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
