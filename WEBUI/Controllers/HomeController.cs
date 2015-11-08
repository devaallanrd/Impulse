using Arduino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            string ret = "";
            if (user.Vencido == "true")
            {
                ret = "<b><h1>[" + user.Nombre +"]</h1></b>  <br> No ha pagado el marchamo"
                + "<br> Ahora usted tiene : <h2> [" + user.Multas + "] Multas </h2>   <br> "
                + "<a href='http://portal.ins-cr.com/portal.ins-cr.com/Encontrarnos/Recaudadores/'>Puede cancelar en cualquier de nuestras oficinas </a>";
            }
            else
            {
                ret = "<b><h1>[" + user.Nombre + "]</h1></b>  <br> Esta al dia  con su marchamo"
                + "<br> Usted tiene : <h2> [" + user.Multas + "]  </h2> Multas sin resolver    <br> "
                + "<a href='http://portal.ins-cr.com/portal.ins-cr.com/Encontrarnos/Recaudadores/'>Puede cancelar en cualquier de nuestras oficinas </a>";
           
            }
           
            return new JsonResult { Data = ret, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        
      
    }
}
