using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class empleadoRepository
    {
        static private string ruta = "empleados.txt";

        public IList<Empleados> empleados;

        public empleadoRepository()
        {
            empleados = new List<Empleados>();
        }

        public void Registar(Empleados empleados)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{empleados.identifiacion};{empleados.nombre};{empleados.salarioBase};{empleados.estado}");
            writer.Close();
            file.Close();
        }

        public IList<Empleados> Consultar() 
        {
            empleados = new List<Empleados>();
            string line = string.Empty;
            FileStream file = new FileStream(ruta,FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            while ((line = reader.ReadLine()) != null)
            {
                Empleados empleado = new Empleados();
                char delimiter = ';';
                string[] MatrizEmpleado = line.Split(delimiter);
                empleado.identifiacion = MatrizEmpleado[0];
                empleado.nombre = MatrizEmpleado[1];
                empleado.salarioBase = double.Parse(MatrizEmpleado[2]);
                empleado.estado = MatrizEmpleado[3];
                empleados.Add(empleado);
            }
            reader.Close();
            file.Close();
            return empleados;
        }

        public Empleados ConsultarPorId(string id)
        {
            empleados = Consultar();
            return empleados.Where(p => p.identifiacion == id).FirstOrDefault();
        }

    }
}
