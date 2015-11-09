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

    
     

        public ActionResult Index()
        {
           
            ViewBag.Title = "Arduino Get DB 2015";
            return View();
          
        }

       
        public JsonResult GetUsers()
        {

            IList<Models.Usuario> list = new UsuariosRepositorio().EncontrarTodos();

            return new JsonResult { Data = list , JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        
      
    }
}
