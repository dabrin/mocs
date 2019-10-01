using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_control_de_labores.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult GestionProcesos()
        {
            return View();
        }

        public ActionResult GestionSubprocesos()
        {
            return View();
        }

        public ActionResult Solicitudes()
        {
            return View();
        }
    }
}