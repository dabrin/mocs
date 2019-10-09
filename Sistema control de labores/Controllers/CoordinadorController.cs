using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_control_de_labores.Controllers
{
    public class CoordinadorController : Controller
    {
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
                        var reporte = new TSCL_Reporte_Usuario();
                        reporte.TN_idUsuario = model.TN_idUsuario;
                        reporte.TN_idSubProceso = model.TN_idSubProceso;
                        reporte.TF_RealizaTarea = model.TF_RealizaTarea;
                        reporte.TN_Cantidad = model.TN_Cantidad;
                        db.PA_InsertarReporte(model.TN_idUsuario, model.TN_idSubProceso,
                        model.TF_RealizaTarea, model.TN_Cantidad);
                        db.SaveChangesAsync();
                    }
                    return Redirect("~/Coordinador/CrearReporte");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public ActionResult ControlUsuarios()
        {
            return View();
        }

        public ActionResult Solicitud_SubProceso_Colaborador()
        {
            obtenerSubProcesos();
            return View();
        }

        [HttpPost]
        public ActionResult Solicitud_SubProceso_Colaborador(Solicitud_SubProceso_Colaborador_View_Model model)
        {
            try
            {
                DateTime date = DateTime.Now;
                //valida los dataAnnotations
                if (ModelState.IsValid)
                {
                    using (sisContLabEntities db = new sisContLabEntities())
                    {
                        var reporte = new TSCL_SolSubPCol();
                        reporte.TN_idUsuarioSolicitante = model.TN_idUsuarioSolicitante;
                        reporte.TN_idUsuarioDestino = model.TN_idUsuarioDestino;
                        reporte.TN_idSubProceso = model.TN_idSubProceso;
                        reporte.TF_SolicitudRealizada = model.TF_SolicitudRealizada;

                        db.PA_Insertar_SolSubCol(model.TN_idUsuarioSolicitante, model.TN_idUsuarioDestino,
                        model.TN_idSubProceso, date);
                        db.SaveChangesAsync();
                    }
                    return Redirect("~/Coordinador/Solicitud_SubProceso_Colaborador");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }




            //return View();
        }

        public List<SubProcesoViewModel> obtenerSubProcesos()
        {
            sisContLabEntities db = new sisContLabEntities();
            List<SubProcesoViewModel> resultado = new List<SubProcesoViewModel>();
            resultado = db.Database.SqlQuery<SubProcesoViewModel>("PA_Consulta_Todos_SubProceso").ToList();
            ViewBag.subProcesos = resultado;

            return resultado;
        }


    }
}



    }
}