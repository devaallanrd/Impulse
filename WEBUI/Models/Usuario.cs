using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBUI.Models
{
    public class Usuario
    {
       

        public string Code { get; set; }
        public string Nombre { get; set; }
        public string Vencido { get; set; }
        public int Multas { get; set; }
    }
}