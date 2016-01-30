using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace _02_SelfHostingWithRoutingAndControllers
{
    public class MyController : ApiController
    {
        public string Get(string lastname = null, string firstname=null)
        {
            //return "Ответ от SelfHost Web API приложения";
            //string contentStart = "<!DOCTYPE html><html lang='en'><head></head><body>";
            //string body = "<h2>Ответ сервера Web API</h2>";
            //string contentEnd = "</body></html>";
            //string msg = contentStart + body + contentEnd;
            //return msg;
            string name = lastname + " " + firstname;
            return "Hello " + name + " from WebApi at " + DateTime.Now.ToShortTimeString();
        }

        public string Post([FromBody]string user, [FromBody]string password)
        {
            //string message = string.Format("Save {0} {0}", lastname, firstname);
            //message += string.Format(" with {0} friends", person.Friends.Count);
            //message += string.Format("({0} in Twitter)", person.Friends.Where(x => x.IsOnTwitter).Count());
            return user;//Json(new { message });
            //return "Користувача стоврено";
        }
    }
}
