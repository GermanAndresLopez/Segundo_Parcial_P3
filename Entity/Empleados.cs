using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleados
    {
        public Empleados()
        {
        }

        public Empleados(string id,string name,double salario,string estados)
        {
            identifiacion = id;
            nombre = name;
            salarioBase = salario;
            estado = estados;
        }

        public string identifiacion {  get; set; }
        public string nombre { get; set; }
        public double salarioBase { get; set; }
        public string estado { get; set; }

    }
}
