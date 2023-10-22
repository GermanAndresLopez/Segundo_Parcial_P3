using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class response
    {
        public IList<Empleados> Priorizado { get; set; }
        public Empleados empleados { get; set; }
        public string Mensaje { get; set; }
        public bool error { get; set; }
        public int Dosis { get; set; }
    }
}
