using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class empleadoService
    {
        public readonly Empleados empleados;
        public readonly empleadoRepository empleadoRepository;

        public string Registar(Empleados empleados)
        {
            try
            {
                empleadoRepository.Registar(empleados);
                return "Guardado con exito";
            }
            catch (Exception e)
            {

                return "Error: " + e.Message;
            }
        }

    }
}
