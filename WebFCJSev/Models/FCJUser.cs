using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFCJSev.Models
{
    public class FCJUser
    {
        public string ClaveU { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Tipo { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Iglesia { get; set; }
        public string Pastor { get; set; }        
        public int Status { get; set; }
        public int Critiano { get; set; }
        public int Edad { get; set; }        
    }
}