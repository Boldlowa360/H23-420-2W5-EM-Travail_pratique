using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP2.Gestion_Session;
using TP2.Models;

namespace TP2.Controllers
{

    public class FavorisController : Controller
    {
        private Database DB { get; set; }

        public FavorisController(Database db)
        {
            this.DB = db;
        }
        [Route("/Favoris")]
        [Route("/Favoris/Index")]
        public IActionResult Index()
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("EnfantIDs");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            var enfantDeLaBD = DB.Enfants.Where(e => enfantIDs.Contains(e.id)).ToList();

            return View(enfantDeLaBD);
        }
        [HttpPost]
        public IActionResult AjouterUnEnfant(int id)
        {
            List<int> E = HttpContext.Session.Get<List<int>>("EnfantIDs");
            if (E == null)
            {
                E = new List<int>();
            }
            if (E.Where(e => e == id).ToList() != null)
            {
                E.Add(id);
                HttpContext.Session.Set<List<int>>("EnfantIDs", E);
            }
            return RedirectToAction("Index");
        }
        public IActionResult SupprimerUnEnfant(int id)
        {
            List<int> E = HttpContext.Session.Get<List<int>>("EnfantIDs");
            E.Remove(id);
            HttpContext.Session.Set<List<int>>("EnfantIDs", E);
            return RedirectToAction("Index");
        }
    }
}
 