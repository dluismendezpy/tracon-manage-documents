using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DocumentosDatos
    {

        public void Agregar(Documento documento)
        {
            using (var db = new CDocumentosEntities())
            {
                db.Documentoes.Add(documento);
                db.SaveChanges();
            }
        }

        public List<Documento> ListarDocumentos()
        {
            using (var db = new CDocumentosEntities())
            {
                return db.Documentoes.ToList();
            }
        }

        public Documento GetDocumento(int id)
        {
            using (var db = new CDocumentosEntities())
            {
                return db.Documentoes.Find(id);
            }
        }

        public void Editar(Documento documento)
        {
            using (var db = new CDocumentosEntities())
            {
                var original = db.Documentoes.Find(documento.DocumentoId);
                original.Ano = documento.Ano;
                original.DepartamentoOrigen = documento.DepartamentoOrigen;
                original.DepartamentoDestino = documento.DepartamentoDestino;
                original.NombreDocumento = documento.NombreDocumento;
                original.FechaCreacionDocumento = documento.FechaCreacionDocumento;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new CDocumentosEntities())
            {
                var documento = db.Documentoes.Find(id);
                db.Documentoes.Remove(documento);
                db.SaveChanges();
            }
        }

    }
}
