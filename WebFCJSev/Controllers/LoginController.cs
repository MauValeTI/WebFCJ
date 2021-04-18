using Encryptor;
using SCG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebFCJSev.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Login(string correo, string pass)
        {
            WithSP withSP = new WithSP();
            HttpStatusCode statusCode = new HttpStatusCode();
            string anterior = "";
            string nueva = "";
            nueva = Encriptador.Encryp(pass);
            //anterior = withSP..ExecuteWhitReturn("", correo);
            if (nueva == anterior)
            {
                statusCode = HttpStatusCode.OK;
            }
            else
            {
                statusCode = HttpStatusCode.InternalServerError;
            }
            return Request.CreateResponse(statusCode, "");
        }
    }
}
