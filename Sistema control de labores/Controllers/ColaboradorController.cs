using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_control_de_labores.Models;
using Sistema_control_de_labores.Models.ViewModel;
namespace Sistema_control_de_labores.Controllers
{
    public class ColaboradorController : Controller
    {
        // GET: Colaborador



        public ActionResult CrearReporte()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearReporte(CrearReporteViewModel model)
        {
            try
            {
                //valida los dataAnnotations
                if (ModelState.IsValid)
                {
                    using (sisContLabEntities db = new sisContLabEntities())
                    {
                        db.PA_InsertarReporte(1, 1, DateTime.Now, 2);
                        db.SaveChangesAsync();
                    }
                    return Redirect("/");
                }

            }
            catch (Exception ex)
            {

            }
            return View(model);
        }
        public ActionResult Diario()
        {
            return View();
        }

        public ActionResult Semanal()
        {
            return View();
        }

        public ActionResult Mensual()
        {
            return View();
        }

        public ActionResult SeleccionIntervalo()
        {
            return View();
        }
    }
}