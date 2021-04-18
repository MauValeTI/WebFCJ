using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFCJSev.Models
{
    public class Eventos
    {
        public string Clave { get; set; }
        public string Titulo { get; set; }        
        public int NumAsistentes { get; set; }
        public double Costo { get; set; }
        public int Estatus { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Imparte { get; set; }
    }
}