using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaServicio
{
    public class BuscaDepartamentoServicios
    {

        public static List<BuscaDepartamentos_Result> BuscaDepartamentos(string departamento)
        {
            using (var db = new CDocumentosEntities())
            {
                return db.BuscaDepartamentos(departamento).ToList();
            }
        }

    }
}
