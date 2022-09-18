using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class AdminProfile : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var userImage = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterImage).FirstOrDefault();
            var Name = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.image = userImage;
            ViewBag.name = Name;
            return View();
        }
    }
}
