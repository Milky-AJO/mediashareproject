using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaShare.Models;

namespace MediaShare.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        public ActionResult Index()
        {
            var media = new Media() { Name = "My Media" };

            return View(media);
        }

    }
}