using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DepartamentosDatos
    {

        public void Agregar(Departamento dpto)
        {
            using (var db = new CDocumentosEntities())
            {
                db.Departamentoes.Add(dpto);
                db.SaveChanges();
            }
        }

        public List<Departamento> ListarDepartamentos()
        {
            using (var db = new CDocumentosEntities())
            {
                return db.Departamentoes.ToList();
            }
        }

        public Departamento GetDepartamento(int id)
        {
            using (var db = new CDocumentosEntities())
            {
                //return db.Departamentoes.Find(id);
                return db.Departamentoes.Where(d => d.DepartamentoId == id).FirstOrDefault();
            }
        }

        public void Editar(Departamento dpto)
        {
            using (var db = new CDocumentosEntities())
            {
                var d = db.Departamentoes.Find(dpto.DepartamentoId);
                d.NombreDepartamento = dpto.NombreDepartamento;
                d.Sigla = dpto.Sigla;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new CDocumentosEntities())
            {
                var dpto = db.Departamentoes.Find(id);
                db.Departamentoes.Remove(dpto);
                db.SaveChanges();
            }
        }

    }
}
