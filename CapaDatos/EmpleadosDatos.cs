using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class EmpleadosDatos
    {

        public void Agregar(Empleado empleado)
        {
            using (var db = new CDocumentosEntities())
            {
                db.Empleadoes.Add(empleado);
                db.SaveChanges();
            }
        }

        public List<Empleado> ListarEmpleados()
        {
            using (var db = new CDocumentosEntities())
            {
                return db.Empleadoes.ToList();
            }
        }

        public Empleado GetEmpleado(int id)
        {
            using (var db = new CDocumentosEntities())
            {
                return db.Empleadoes.Find(id);
            }
        }

        public void Editar(Empleado empleado)
        {
            using (var db = new CDocumentosEntities())
            {
                var original = db.Empleadoes.Find(empleado.EmpleadoId);
                original.NombreEmpleado = empleado.NombreEmpleado;
                original.CorreoElectronico = empleado.CorreoElectronico;
                original.Departamento = empleado.Departamento;
                original.Cargo = empleado.Cargo;
                original.Telefono = empleado.Telefono;
                original.Direccion = empleado.Direccion;
                original.FechaCreacionEmpleado = original.FechaCreacionEmpleado;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new CDocumentosEntities())
            {
                var empleado = db.Empleadoes.Find(id);
                db.Empleadoes.Remove(empleado);
                db.SaveChanges();
            }
        }

    }
}
