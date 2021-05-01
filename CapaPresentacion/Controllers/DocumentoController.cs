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
    public class DocumentoController : Controller
    {
        // GET: Documento
        public ActionResult Index()
        {
            var documento = DocumentosNegocios.ListarDocumentos();
            return View(documento);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Documento documento)
        {
            try
            {
                DocumentosNegocios.Agregar(documento);
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
            var documento = DocumentosNegocios.GetDocumento(id);
            return View(documento);
        }

        public ActionResult Editar(int id)
        {
            var documento = DocumentosNegocios.GetDocumento(id);
            return View(documento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Documento documento)
        {
            try
            {
                DocumentosNegocios.Editar(documento);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(documento);
            }
        }

        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var documento = DocumentosNegocios.GetDocumento(id.Value);
            return View(documento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(int id)
        {
            try
            {
                DocumentosNegocios.Eliminar(id);
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
        public ActionResult ResultadoBusqueda(string documento)
        {
            return View(BuscaDocumentoServicios.BuscaDocumentos(documento));
        }
    }
}