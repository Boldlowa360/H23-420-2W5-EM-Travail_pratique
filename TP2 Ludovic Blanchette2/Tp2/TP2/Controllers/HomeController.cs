using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP2.Models;

namespace TP2.controller
{
    public class HomeController : Controller
    {
            private Database DB { get; set; }

            public HomeController(Database db)
            {
                this.DB = db;
            }
        public ActionResult Index()
        {
            return View(DB.Parents.ToList());
        }

    }
}
