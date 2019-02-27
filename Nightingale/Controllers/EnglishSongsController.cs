using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nightingale.Controllers
{
    public class EnglishSongsController : Controller
    {
        // GET: EnglishSongs
        public ActionResult Index()
        {
            return View();
        }
    }
}