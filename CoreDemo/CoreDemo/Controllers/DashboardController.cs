using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            
            Context c = new Context();
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v3 = c.Categories.Count().ToString();
            ViewBag.v4 = c.Writers.Count().ToString();

            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            //var writerName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();

            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == writerId).Count().ToString();
            ViewBag.v5 = userName;

            string apiKey = "84450326158b347fa6e39d0c4b5b6ad2";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Kocaeli&mode=xml&units=metric&appid=" + apiKey;
            XDocument document = XDocument.Load(connection);
            ViewBag.temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            string icon = document.Descendants("weather").ElementAt(0).Attribute("icon").Value;
            ViewBag.icon = "http://openweathermap.org/img/w/" + icon + ".png";
            return View();
        }
    }
}
