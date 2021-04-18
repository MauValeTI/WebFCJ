using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFCJSev.Models
{
    public class Almacen
    {
        public string Clave { get; set; }
        public string Gerente { get; set; }        
        public string Productos { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int Estatus { get; set; }
    }
}