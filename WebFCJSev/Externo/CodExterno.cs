using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFCJSev.Models;
using SCG;
using Encryptor;

namespace WebFCJSev.Externo
{
    public class CodExterno
    {
        int respuesta = 0;
        WithSP withSP = new WithSP();
        int status = 0;
        string cla = "";

        public CodExterno()
        {
            withSP.Source = "sql2016"; //"DESKTOP-F2UI3L0";
            withSP.Catalog = "w210066_WebFCJ"; //"APPFCJ";
            withSP.Security = "flase";
            withSP.User = "w210066_AdminMau";
            withSP.Pass = "Di02M3ama03";
            withSP.CreateConnect();
        }

        public string CreateClave(string campo1)
        {
            Random ra = new Random();
            string res = "";            
            res = ra.Next(10) + "" + campo1.Substring(0, 2) + "" + DateTime.Now.Day + "" + ra.Next(20) + "" + DateTime.Now.Month + "" + DateTime.Now.Year + "" + ra.Next(30);
            return res;
        }

        public int SaveUserFCJ(int op, List<FCJUser> ListUse)
        {            
            foreach (var item in ListUse)
            {
                status = op == 1 ? 1 : item.Status;
                cla = CreateClave(item.Nombre);
                string sinpass = Encriptador.Encryp(item.Pass);
                respuesta = withSP.SaveGeneric("GenericUSERFCJ", "@Opcion", op, "@Clave", cla , "@Nombre", item.Nombre, "@Apellidos", item.Apellidos, "@Direccion", item.Direccion, "@Telefono", item.Telefono, "@Tipo", item.Tipo, "@Email", item.Email, "@Pass", sinpass, "@Iglesia", item.Iglesia, "@Pastor", item.Pastor, "@Estatus", status, "@Cristiano", item.Critiano, "@Edad", item.Edad);
                //respuesta = "Insert into " + tabla + " values (" + "'" + item.idAlmacen + "'" + "," + "'" + item.Gerente + "'" + "," + "'" + item.Fecha + "'" + "," + "'" + item.Productos + "'" + "," + item.Precio + "," + item.Cantidad + "," + item.Estatus + ")";
            }            
            return respuesta;
        }

        public int SaveAlmacen(int op, List<Almacen> ListAlmacen)
        {    
            foreach (var item in ListAlmacen)
            {
                status = op == 1 ? 1 : item.Estatus;
                cla = CreateClave(item.Gerente);
                respuesta = withSP.SaveGeneric("GenericAlmacen", "@Opcion",op,"@Clave", cla, "@Gerente", item.Gerente, "@Producto", item.Productos, "@Precio", item.Precio, "@Cantidad", item.Cantidad, "@Estatus", status);
            }
            return respuesta;
        }
        public int SaveEvento(int op, List<Eventos> ListEventos)
        {            
            foreach (var item in ListEventos)
            {
                status = op == 1 ? 1 : item.Estatus;
                cla = CreateClave(item.Titulo);
                respuesta = withSP.SaveGeneric("GenericEventos", "@Opcion", op, "@Clave", cla, "@Titulo", item.Titulo, "@NumAsistencias", item.NumAsistentes, "@Costo", item.Costo, "@Estatus", status, "@FechaEvento", item.FechaEvento, "@Imparte", item.Imparte);
            }
            return respuesta;
        }
        public int SaveCali(int op, List<Calificaciones> ListCali)
        {            
            foreach (var item in ListCali)
            {
                respuesta = withSP.SaveGeneric("GenericCalif", "@Opcion", op, "@Clave", item.Clave, "@Materia", item.Materia, "@Calificacion", item.Calificacion, "@Alumno", item.Alumno);
            }
            return respuesta;
        }
        public int SaveSecciones(int op, List<Secciones> ListSec)
        {            
            foreach (var item in ListSec)
            {
                respuesta = withSP.SaveGeneric("GenericSecciones", "@Opcion", op, "@Clave", item.Clave, "@Alumno", item.Alumno, "@Seccion", item.Seccion, "@Porcentaje", item.Porcentaje);
            }
            return respuesta;
        }
        public int SaveTienda(int op, List<Tienda> ListTienda)
        {            
            foreach (var item in ListTienda)
            {
                cla = CreateClave(item.Gerente);
                respuesta = withSP.SaveGeneric("GenericTienda", "@Opcion", op, "@Clave", cla,"@Gerente", item.Gerente, "@CorteInicio", item.CorteInicio, "@CantidadVendida", item.ProductosVendidos, "@TotalVenta", item.TotalVendido);
            }
            return respuesta;
        }
    }
}