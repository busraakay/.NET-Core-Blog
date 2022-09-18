using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page, 4);
            return View(values);
        }

        public IActionResult ContacttPassive(int id)
        {
            var value = cm.TGetById(id);
            value.ContactStatus = false;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult ContactActive(int id)
        {
            var value = cm.TGetById(id);
            value.ContactStatus = true;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditContact(int id)
        {
            var value = cm.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditContact(Contact p)
        {

            ContactValidator cv = new ContactValidator();
            ValidationResult results = cv.Validate(p);

            if (results.IsValid)
            {
                p.ContactStatus = true;
                cm.TUpdate(p);
                return RedirectToAction("Index", "Contact");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
