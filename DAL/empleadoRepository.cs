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
        public readonly Empleados empleados;
        public readonly string ruta = @"C:\Windows\System32\cmd.exe";
        public void Registar(Empleados empleados)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{empleados.identifiacion};{empleados.nombre};{empleados.salarioBase};{empleados.estado}");
            writer.Close();
            file.Close();
        }


    }
}
