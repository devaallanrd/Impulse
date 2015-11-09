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
            
            string ret = "";
           // string tweet = "Nothing yet";

            if (user.ID == null)
            {
                ret = "";
            }
            else { 
            if (user.Vencido == "true")
            {
                //tweet = user.Nombre + "- Le recordamos que debe pagar su derecho de circulacion";
               // new TwitterController("M |" );
                ret =  "<b><h1>[" + user.Propietario +"]</h1></b>  <br> No ha pagado el marchamo"
                + "<br> Ahora usted tiene : <h2> [" + user.Multas + "] Multas </h2>   <br> "
                + "<a href='http://portal.ins-cr.com/portal.ins-cr.com/Encontrarnos/Recaudadores/'>Puede cancelar en cualquier de nuestras oficinas </a>";
               
            }
            else
            {
               // tweet = user.Nombre + "- Gracias por estar al dia con su derecho de circulacion";
              //  new TwitterController("P |" );
                ret =  "<b><h1>[" + user.Propietario + "]</h1></b>  <br> Esta al dia  con su marchamo"
                + "<br> Usted tiene : <h2> [" + user.Multas + "]  </h2> Multas sin resolver    <br> "
                + "<a href='http://portal.ins-cr.com/portal.ins-cr.com/Encontrarnos/Recaudadores/'>Puede cancelar en cualquier de nuestras oficinas </a>";



            }
            }

           
           
          
            return new JsonResult { Data = ret, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        
      
    }
}
