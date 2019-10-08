using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_control_de_labores.Controllers
{
    public class CoordinadorController : Controller
    {
        // GET: Coordinador
        public ActionResult ControlUsuarios()
        {
            return View();
        }

        public ActionResult Solicitudes()
        {
            return View();
        }
    }
}