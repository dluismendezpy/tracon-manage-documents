using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
using CapaEntidad;
using CapaServicio;
using System.Net;

namespace CapaPresentacion.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            var empleado = EmpleadosNegocios.ListarEmpleados();
            return View(empleado);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Empleado empleado)
        {
            try
            {
                EmpleadosNegocios.Agregar(empleado);
                //return Json(new { ok = true, toRedirect = "Index" }, JsonRequestBehavior.AllowGet);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //return Json(new { ok = false, msg = ex.Message }, JsonRequestBehavior.AllowGet);
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        public ActionResult Detalles(int id)
        {
            var empleado = EmpleadosNegocios.GetEmpleado(id);
            return View(empleado);
        }

        public ActionResult Editar(int id)
        {
            var empleado = EmpleadosNegocios.GetEmpleado(id);
            return View(empleado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Empleado empleado)
        {
            try
            {
                EmpleadosNegocios.Editar(empleado);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(empleado);
            }
        }

        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var empleado = EmpleadosNegocios.GetEmpleado(id.Value);
            return View(empleado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(int id)
        {
            try
            {
                EmpleadosNegocios.Eliminar(id);
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
        public ActionResult ResultadoBusqueda(string nombre)
        {
            return View(BuscaEmpleadoServicios.BuscaEmpleados(nombre));
        }
    }
}