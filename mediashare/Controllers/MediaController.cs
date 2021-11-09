using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mediashare.Models;

namespace mediashare.Controllers
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