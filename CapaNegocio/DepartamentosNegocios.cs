using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class DepartamentosNegocios
    {

        private static DepartamentosDatos capaDatos = new DepartamentosDatos();

        public static void Agregar(Departamento dpto)
        {
            capaDatos.Agregar(dpto);
        }

        public static List<Departamento> ListarDepartamentos()
        {
            return capaDatos.ListarDepartamentos();
        }

        public static Departamento GetDepartamento(int id)
        {
            return capaDatos.GetDepartamento(id);
        }

        public static void Editar(Departamento dpto)
        {
            capaDatos.Editar(dpto);
        }

        public static void Eliminar(int id)
        {
            capaDatos.Eliminar(id);
        }

    }
}
