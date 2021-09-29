using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyNotes.WebMVC.Controllers
{
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            return View();
        }
    }
}