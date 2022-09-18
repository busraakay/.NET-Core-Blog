using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        UserManager um = new UserManager(new EfUserRepository());

        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            Context c = new Context();
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            ViewBag.mail = userMail;
            
            var writerName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.name = writerName;
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult PartialWriterNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialWriterFooter()
        {
            return PartialView();
        }

        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            //Context c = new Context();
            //var userName = User.Identity.Name;
            //var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            //var writerId = c.Users.Where(x => x.Email == userMail).Select(y => y.Id).FirstOrDefault();
            //var writerValues = um.TGetById(writerId);
            UserUpdateViewModel model = new UserUpdateViewModel();
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            model.mail = values.Email;
            model.namesurname = values.NameSurname;
            model.imageurl = values.ImageUrl;
            model.description = values.Description;
            model.username = values.UserName;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {
            //WriterValidator wl = new WriterValidator();
            //ValidationResult results = wl.Validate(p);
            //if (results.IsValid)
            //{
            //    wm.TUpdate(p);
            //    return RedirectToAction("Index", "Dashboard");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = model.namesurname;
            values.ImageUrl = model.imageurl;
            values.Description = model.description;
            values.Email = model.mail;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");
            //return View();
        }

        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;

            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;

            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
