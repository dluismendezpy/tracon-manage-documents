using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;
using CapaServicio;

namespace CapaPresentacion.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
            var datos = DepartamentosNegocios.ListarDepartamentos();

            return View(datos);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Departamento dpto)
        {

            try
            {

                if (dpto.NombreDepartamento == null)
                {
                    ModelState.AddModelError("", "Debes ingresar un nombre de departamento");
                    return View(dpto);
                }

                DepartamentosNegocios.Agregar(dpto);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(dpto);
            }
        }

        public ActionResult GetDepartamento(int id)
        {
            var dpto = DepartamentosNegocios.GetDepartamento(id);

            return View(dpto);
        }

        public ActionResult Editar(int id)
        {
            var dpto = DepartamentosNegocios.GetDepartamento(id);
            return View(dpto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Departamento dpto)
        {
            try
            {

                if (dpto.NombreDepartamento == null)
                {
                    ModelState.AddModelError("", "Debes ingresar un nombre de departamento");
                    return View(dpto);
                }

                DepartamentosNegocios.Editar(dpto);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(dpto);
            }
        }

        public ActionResult Eliminar(int? id)
        {

            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var dpto = DepartamentosNegocios.GetDepartamento(id.Value);
            return View(dpto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(int id)
        {
            try
            {
                DepartamentosNegocios.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResultadoBusqueda(string departamento)
        {
            return View(BuscaDepartamentoServicios.BuscaDepartamentos(departamento));
        }
    }
}