using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;


using Tweetinvi.Core.Credentials;
using Tweetinvi;
using Tweetinvi.Core.Interfaces;


namespace Web.Controllers
{
    public class TwitterController
    {

       
        public TwitterController(string x)
        {
            //Credenciales de mi app en https://apps.twitter.com/
            string consumerKey = "JY8GyTVOsBFsx8l0u4c69k4PF"; // Clave del consumidor de la aplicación
            string consumerSecret = "OmjAaD0AYjWIuwakqDe0tE8NorR13phBZ1pv3BUQf4bnJoT8oe"; // Secreto del consumidor de la aplicación
            string accessToken = "62594043-NhFHPL96RVmoGaSCSPozWK4D1NwVXo6kLYePzjIPh"; // El token de acceso concedido después de la autorización OAuth
            string accessTokenSecret = "knbtbEte8LJjJhql65J6KbppiE5PUif8hOJx1pdWSSQLV"; // El secreto de acceso simbólico otorgado después de la autorización OAuth


            // Generar credenciales que queremos utilizar
            // var creds = new TwitterCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
             Auth.ApplicationCredentials = new TwitterCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
            // Utilice el método ExecuteOperationWithCredentials para invocar una operación
            // con un conjunto específico de credenciales
             var tweet = Tweet.PublishTweet(x);
        }
      
    }
}


        /*
        public string TweetSomething(string x)
        {
            var tweet = Auth.ExecuteOperationWithCredentials(creds, () =>
            {
                return  Tweet.PublishTweet(x);
            });

            if (tweet != null)
            {
                return "Completed Tweeted";
            }
            else
            {
                return "No completed Tweet";
            }
          
        }
        
        public void getUserLogged()
        {
            var user = Auth.ExecuteOperationWithCredentials(creds, () =>
            {
                return User.GetLoggedUser();
            });

            
        }

        public void getMatchResults()
        {
           IEnumerable<ITweet> matchingTweets 
               = Search.SearchTweets("tweetinvi").ToList();

        }*/

 
