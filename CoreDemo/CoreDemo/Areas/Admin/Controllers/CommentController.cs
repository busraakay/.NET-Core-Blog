using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index(int page = 1)
        {
            var values = cm.GetCommentWithBlog().ToPagedList(page, 4);
            return View(values);
        }

        public IActionResult CommenttPassive(int id)
        {
            var value = cm.TGetById(id);
            value.CommentStatus = false;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult CommentActive(int id)
        {
            var value = cm.TGetById(id);
            value.CommentStatus = true;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditComment(int id)
        {
            var value = cm.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditComment(Comment p)
        {

            CommentValidator cv = new CommentValidator();
            ValidationResult results = cv.Validate(p);

            if (results.IsValid)
            {
                p.CommentStatus = true;
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
