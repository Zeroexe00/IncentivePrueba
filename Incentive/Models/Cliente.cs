using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Incentive.Models
{
    public class Cliente
    {
        public string ciudad { get; set; }
        public int codigo { get; set; }
        public string direccion { get; set; }
        public string estado { get; set; }
        public string fecha_registro { get; set; }
        public string nombre { get; set; }
    }
}
