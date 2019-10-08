using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_control_de_labores.Models.ViewModel
{
    public class SubProcesoViewModel
    {
        public int TN_idSubProceso { get; set; }
        [Required]
        [Display(Name = "SubProceso")]
        public String TC_Nom_SubProceso { get; set; }
    }
}