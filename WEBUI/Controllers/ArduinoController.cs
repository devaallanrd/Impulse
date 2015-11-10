using Arduino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Controllers;
using WEBUI.Models;
using WEBUI.Providers;

namespace WEBUI.Controllers
{
    public class ArduinoController : Controller
    {


        string Card;

        public ActionResult Index()
        {
           
            ViewBag.Title = "Arduino Get DB 2015";
            return View();
          
        }

        public ActionResult Registrar()
        {

            ViewBag.Title = "Registrar";
            return View();

        }

       
        public JsonResult GetUsers()
        {

            IList<Models.Usuario> list = new UsuariosRepositorio().EncontrarTodos();

            return new JsonResult { Data = list , JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetArduino()
        {
            //Nuevo Modelo de Arduino 
            //Esto deberia ser un contexto de acceso a datos
            Card = new ArduinoModel().readData();


            //Aqui voy al repositorio de Usuarios con el # de tarjeta leida arriba 
            //Hay que pasarlo por una interfaz
            Usuario user = new UsuariosRepositorio().EncontrarUsuario(Card);
            string ret = "";
            if (user.Code == null)
            {
                ret = Card;
            }
            else { 
            if ((user.Code == Card) | (user.Code != "") | (user.Code != null))
            {
                ret = "Ya esta registrada";
            }
            else
            {
                ret = Card;
            }
            }

            return new JsonResult { Data = ret, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


        }
      
    }
}
