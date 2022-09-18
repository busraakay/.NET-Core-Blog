using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic3 : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.adminName = c.Admins.Where(x => x.AdminID == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.adminImage = c.Admins.Where(x => x.AdminID == 1).Select(y => y.ImageURL).FirstOrDefault();
            ViewBag.adminDescription = c.Admins.Where(x => x.AdminID == 1).Select(y => y.ShortDescription).FirstOrDefault();

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
