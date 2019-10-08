using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_control_de_labores.Controllers
{
    public class EstadisticoController : Controller
    {
        // GET: Estadistico
        public ActionResult EstadisticoGeneral()
        {
            return View();
        }

        public ActionResult EstadisticoProceso()
        {
            return View();
        }

        public ActionResult EstadisticoUsuario()
        {
            return View();
        }
    }
}