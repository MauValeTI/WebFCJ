using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFCJSev.Models
{
    public class Tienda
    {
        public string Clave { get; set; }
        public string Gerente { get; set; }        
        public double CorteInicio { get; set; }
        public int ProductosVendidos { get; set; }
        public double TotalVendido { get; set; }
    }
}