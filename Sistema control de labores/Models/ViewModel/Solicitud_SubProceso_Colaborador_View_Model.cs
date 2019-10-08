using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_control_de_labores.Models.ViewModel
{
    public class Solicitud_SubProceso_Colaborador_View_Model
    {
        public int TN_idUsuarioSolicitante { get; set; }

        public int TN_idUsuarioDestino { get; set; }
        [Display(Name = "SubProceso")]
        public int TN_idSubProceso { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime TF_SolicitudRealizada{ get; set; }
        public int TC_Nom_SubProceso { get; set; }

    }
}