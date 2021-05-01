using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class DocumentosNegocios
    {

        private static DocumentosDatos capaDatos = new DocumentosDatos();

        public static void Agregar(Documento documento)
        {
            capaDatos.Agregar(documento);
        }

        public static List<Documento> ListarDocumentos()
        {
            return capaDatos.ListarDocumentos();
        }

        public static Documento GetDocumento(int id)
        {
            return capaDatos.GetDocumento(id);
        }

        public static void Editar(Documento documento)
        {
            capaDatos.Editar(documento);
        }

        public static void Eliminar(int id)
        {
            capaDatos.Eliminar(id);
        }

    }
}
