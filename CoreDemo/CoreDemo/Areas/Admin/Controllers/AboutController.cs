using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        AboutManager cm = new AboutManager(new EfAboutRepository());

        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page, 4);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbout(About p)
        {
            AboutValidator cv = new AboutValidator();
            ValidationResult results = cv.Validate(p);

            if (results.IsValid)
            {
                p.AboutStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "About");
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
        public IActionResult AboutPassive(int id)
        {
            var value = cm.TGetById(id);
            value.AboutStatus = false;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult AboutActive(int id)
        {
            var value = cm.TGetById(id);
            value.AboutStatus = true;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var value = cm.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditAbout(About p)
        {

            AboutValidator cv = new AboutValidator();
            ValidationResult results = cv.Validate(p);

            if (results.IsValid)
            {
                p.AboutStatus = true;
                cm.TUpdate(p);
                return RedirectToAction("Index", "Category");
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
