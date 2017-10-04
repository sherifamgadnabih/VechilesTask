using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechiles.DTO
{
   public class VechileDTO
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string RegNr { get; set; }
        public bool Status { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
    }
}
