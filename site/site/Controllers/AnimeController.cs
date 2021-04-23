using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace site.Controllers
{
    public class AnimeController : Controller
    {
        // GET: Anime
        public ActionResult Home()
        {
            return View();
        }
    }
}