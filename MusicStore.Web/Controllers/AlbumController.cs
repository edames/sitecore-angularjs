using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Web.Controllers
{
    public class AlbumController : Controller
    {
        public ActionResult Index()
        {

            return View(Views.Index);
        }

        public static class Views
        {
            public static readonly string Index = "/Views/Albums/View.cshtml";
        }
    }
}