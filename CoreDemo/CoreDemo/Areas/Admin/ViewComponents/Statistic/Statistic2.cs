using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.lastBlogName = c.Blogs.OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogTitle).Take(1).FirstOrDefault();

            ViewBag.lastBlogImage = c.Blogs.OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogImage).Take(1).FirstOrDefault();

            ViewBag.lastBlogWriter = c.Blogs.OrderByDescending(x => x.BlogID)
                .Select(x => x.Writer.WriterImage).Take(1).FirstOrDefault();

            ViewBag.lastBlogID = c.Blogs.OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogID).Take(1).FirstOrDefault();

            var content = c.Blogs.OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogContent).Take(1).FirstOrDefault();

            var date = c.Blogs.OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogCreateDate).Take(1).FirstOrDefault();

            ViewBag.lastBlogDate = date.ToShortDateString();
            ViewBag.lastBlogTime = date.ToShortTimeString();
            ViewBag.lastBlogContent = content.Substring(0, content.Substring(0, 60).LastIndexOf(" "));

            
            return View();
        }
    }
}
