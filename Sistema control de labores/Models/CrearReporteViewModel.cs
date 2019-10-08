using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_control_de_labores.Models.ViewModel
{
    public class CrearReporteViewModel
    {
        public int TN_idUsuario { get; set; }
        public int TN_idSubProceso { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display (Name ="Fecha")]
        public DateTime TF_RealizaTarea { get; set; }
        [Required]
        [Display(Name ="Cantidad")]
        public int TN_Cantidad { get; set; }
    }
}