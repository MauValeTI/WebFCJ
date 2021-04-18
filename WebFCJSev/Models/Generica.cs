using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFCJSev.Models
{
    public class Generica
    {
        public string Tabla { get; set; }
        public string Accion { get; set; }
        public List<Almacen> LtAlmacen { get; set; }
        public List<Calificaciones> LstCalificaciones { get; set; }
        public List<Eventos> LstEventos { get; set; }
        public List<FCJUser> LstUser { get; set; }        
        public List<Secciones> LstSecciones { get; set; }
        public List<Tienda> LstTienda { get; set; }
    }
}