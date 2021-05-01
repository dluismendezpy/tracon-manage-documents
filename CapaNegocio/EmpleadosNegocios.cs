using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class EmpleadosNegocios
    {

        private static EmpleadosDatos capaDatos = new EmpleadosDatos();

        public static void Agregar(Empleado empleado)
        {
            capaDatos.Agregar(empleado);
        }

        public static List<Empleado> ListarEmpleados()
        {
            return capaDatos.ListarEmpleados();
        }

        public static Empleado GetEmpleado(int id)
        {
            return capaDatos.GetEmpleado(id);
        }

        public static void Editar(Empleado empleado)
        {
            capaDatos.Editar(empleado);
        }

        public static void Eliminar(int id)
        {
            capaDatos.Eliminar(id);
        }

    }
}
