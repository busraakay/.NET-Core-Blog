using BusinessLayer.Concrete;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")] 
    public class WriterController : Controller
    {
        WriterManager cm = new WriterManager(new EfWriterRepository());
        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page, 4);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWriter(Writer p)
        {
            WriterValidator cv = new WriterValidator();
            ValidationResult results = cv.Validate(p);

            if (results.IsValid)
            {
                p.WriterStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Writer");
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
        public IActionResult WriterPassive(int id)
        {
            var value = cm.TGetById(id);
            value.WriterStatus = false;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }

        public IActionResult WriterActive(int id)
        {
            var value = cm.TGetById(id);
            value.WriterStatus = true;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditWriter(int id)
        {
            var value = cm.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditWriter(Writer p)
        {

            WriterValidator cv = new WriterValidator();
            ValidationResult results = cv.Validate(p);

            if (results.IsValid)
            {
                p.WriterStatus = true;
                cm.TUpdate(p);
                return RedirectToAction("Index", "Writer");
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
