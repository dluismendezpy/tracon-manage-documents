using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaServicio
{
    public class BuscaDocumentoServicios
    {

        public static List<BuscaDocumentos_Result> BuscaDocumentos(string documento)
        {
            using (var db = new CDocumentosEntities())
            {
                return db.BuscaDocumentos(documento).ToList();
            }
        }

    }
}
