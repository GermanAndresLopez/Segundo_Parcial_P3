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
        empleadoRepository empleadoRepository;

        public empleadoService()
        {
            empleadoRepository = new empleadoRepository();
        }

        public string Registar(Empleados empleados)
        {
            try
            {
                if (empleadoRepository.ConsultarPorId(empleados.identifiacion) == null)
                {
                    empleadoRepository.Registar(empleados);
                    return "Guardado con exito";
                }
                return $"El empleado con {empleados.identifiacion} ya existe";
            }
            catch (Exception e)
            {

                return "ERROR de Aplicacion: " + e.Message;
            }
        }

        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                respuesta.Empleados = empleadoRepository.Consultar();
                if (respuesta.Empleados != null)
                {
                    respuesta.Mensaje = "Consulta Exitosa";
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos";
                }
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Error de Datos: " + e.Message;
            }
            return respuesta;
        }


    }

    public class RespuestaConsulta
    {
        public IList<Empleados> Empleados { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
    }

}
