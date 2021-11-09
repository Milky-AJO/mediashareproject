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
        public ActionResult Index()
        {
            var media = new Media() {Name = "My Picture"};
            return View(media);
        }
    }
}