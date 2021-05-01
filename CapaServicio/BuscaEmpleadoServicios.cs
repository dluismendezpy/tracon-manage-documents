using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaServicio
{
    public class BuscaEmpleadoServicios
    {
        public static List<BuscaEmpleados_Result> BuscaEmpleados(string nombre)
        {
            using (var db = new CDocumentosEntities())
            {
                return db.BuscaEmpleados(nombre).ToList();
            }
        }
    }
}
