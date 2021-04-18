using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebFCJSev.Models;
using WebFCJSev.Externo;

namespace WebFCJSev.Controllers
{
    [EnableCors("*", "*", "*")] 
    public class ApiGenericController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage ApGenerica(object json)
        {
          
            CodExterno externo = new CodExterno();
            int res = 0;
            HttpStatusCode http = new HttpStatusCode();
            CodExterno codExterno = new CodExterno();            

            var jsondes = JsonConvert.DeserializeObject<Generica>(json.ToString());

            if (int.Parse(jsondes.Accion) == 3)
            {
                //Select
            }

            List<object> ListRespuesta = new List<object>();

            List<FCJUser> ListAlumnos = jsondes.LstUser; 
            List<Secciones> ListSecc = jsondes.LstSecciones;
            List<Almacen> ListAlmacen = jsondes.LtAlmacen;
            List<Tienda> ListTienda = jsondes.LstTienda;
            List<Eventos> ListEventos = jsondes.LstEventos;
            List<Calificaciones> ListCali = jsondes.LstCalificaciones;
            
            if (ListAlumnos != null && ListAlumnos.Count() > 0)
            {                
                switch (int.Parse(jsondes.Accion))
                {                    
                    case 1:
                        //insert
                        res = externo.SaveUserFCJ(1,ListAlumnos);
                        break;
                    case 2:
                        //update
                        res = externo.SaveUserFCJ(2,ListAlumnos);
                        break;
                }                
            }
            else if (ListAlmacen != null && ListAlmacen.Count() > 0)
            {
                switch (int.Parse(jsondes.Accion))
                {
                    case 1:
                        //insert
                        res = externo.SaveAlmacen(1,ListAlmacen);
                        break;
                    case 2:
                        //update
                        res = externo.SaveAlmacen(2, ListAlmacen);
                        break;
                }

            }
            else if (ListEventos != null && ListEventos.Count() > 0)
            {
                switch (int.Parse(jsondes.Accion))
                {
                    case 1:
                        //insert
                        res = externo.SaveEvento(1,ListEventos);
                        break;
                    case 2:
                        //update
                        res = externo.SaveEvento(2, ListEventos);
                        break;

                }
            }
            else if (ListCali != null && ListCali.Count() > 0)
            {
                switch (int.Parse(jsondes.Accion))
                {
                    case 1:
                        //insert
                        res = externo.SaveCali(1,ListCali);
                        break;
                    case 2:
                        //update
                        res = externo.SaveCali(2, ListCali);
                        break;

                }
            }
            else if (ListSecc != null && ListSecc.Count() > 0)
            {
                switch (int.Parse(jsondes.Accion))
                {
                    case 1:
                        //insert
                        res = externo.SaveSecciones(1,ListSecc);
                        break;
                    case 2:
                        //update
                        res = externo.SaveSecciones(2, ListSecc);
                        break;

                }
            }
            else if (ListTienda != null && ListTienda.Count() > 0)
            {
                switch (int.Parse(jsondes.Accion))
                {
                    case 1:
                        //insert
                        res = externo.SaveTienda(1, ListTienda);
                        break;
                    case 2:
                        //update
                        res = externo.SaveTienda(2, ListTienda);
                        break;

                }
            }

            if (res == 1)
            {
                http = HttpStatusCode.OK;
                ListRespuesta = null;
            }
            else
            {
                http = HttpStatusCode.BadRequest;
                ListRespuesta = null;
            }

            return Request.CreateResponse(http, ListRespuesta);
        }
    }
}
