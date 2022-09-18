using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        Context c = new Context();
        MessageManager mm = new MessageManager(new EfMessageRepository());

        public IActionResult Inbox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetInboxListByWriter(writerId);
            return View(values);
        }

        public IActionResult Sendbox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetSendBoxListByWriter(writerId);
            return View(values);
        }

        [HttpGet]
        public IActionResult ComposeMessage()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult ComposeMessage(Message2 p)
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            p.SenderID = writerId;
            p.ReceiverID = 2;
            p.MessageStatus = true;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("Sendbox");
        }
    }
}
