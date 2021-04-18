using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFCJSev.Models
{
    public class Calificaciones
    {
        public string Clave { get; set; }
        public string Materia { get; set; }
        public float Calificacion { get; set; }        
        public string Alumno { get; set; }
    }
}