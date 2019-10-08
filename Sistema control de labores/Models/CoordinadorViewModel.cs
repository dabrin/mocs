using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_control_de_labores.Models.ViewModel
{
    public class CoordinadorViewModel
    {
        public int TN_idUsuario { get; set;}
        public int TN_idSubProceso { get; set;}
        public DateTime TF_RealizaTarea { get; set;}
        public int TN_Cantidad { get; set; }
    }
}