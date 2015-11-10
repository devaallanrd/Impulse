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
    public class HomeController : Controller
    {

        string Card;
     

        public ActionResult Index()
        {
           
            ViewBag.Title = "Marchamos 2015";
            return View();
          
        }

       
        public JsonResult GetArduino()
        {
            //Nuevo Modelo de Arduino 
            //Esto deberia ser un contexto de acceso a datos
            Card = new ArduinoModel().readData();


            //Aqui voy al repositorio de Usuarios con el # de tarjeta leida arriba 
            //Hay que pasarlo por una interfaz
            Usuario user = new UsuariosRepositorio().EncontrarUsuario(Card);

           
            ModelViewUsuario modelViewUsuario = new ModelViewUsuario(user);

            IList<object> UserView = modelViewUsuario.getUserViewModel();


                return new JsonResult { Data = UserView, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        
              }

        
      
    }
}
