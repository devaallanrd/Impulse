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
           /// string consumerKey = "kR4y7G1mh6lreuSBKEx7EnJOR"; // Clave del consumidor de la aplicación
           // string consumerSecret = "RdzSmMcngGNXNgdgpgbuRI0ldGRc3EDfHnaPhTIrliU46iuLV1"; // Secreto del consumidor de la aplicación
           // string accessToken = "62594043-wpg1rczxxnhMcdXNyNkzAEDcv7pwcbDsyCffv2NzI"; // El token de acceso concedido después de la autorización OAuth
          //  string accessTokenSecret = "fiMmlk8B7zpDVWYaPj9v5VzkBNHwmG6eJzRXfe42oBV57"; // El secreto de acceso simbólico otorgado después de la autorización OAuth


            // Generar credenciales que queremos utilizar
            // var creds = new TwitterCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
            // Auth.ApplicationCredentials = new TwitterCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
             Auth.ApplicationCredentials = new TwitterCredentials("kR4y7G1mh6lreuSBKEx7EnJOR", "RdzSmMcngGNXNgdgpgbuRI0ldGRc3EDfHnaPhTIrliU46iuLV1",
                 "62594043-wpg1rczxxnhMcdXNyNkzAEDcv7pwcbDsyCffv2NzI", "fiMmlk8B7zpDVWYaPj9v5VzkBNHwmG6eJzRXfe42oBV57");
            
            // Utilice el método ExecuteOperationWithCredentials para invocar una operación
            // con un conjunto específico de credenciales
             Tweet.PublishTweet(x);

             Auth.ApplicationCredentials = null;
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

 
