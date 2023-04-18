using Microsoft.AspNetCore.Mvc;
using TP2.ViewModels;
using TP2.Models;

namespace TP2.Controllers
{

    public class EnfantController : Controller
    {
        private Database DB { get; set; }

        public EnfantController(Database db)
        {
            this.DB = db;
        }
        [Route("/Recherche")]
        [Route("/enfant/Recherche")]
        [Route("/enfant/Recherche/{id:int?}")]
        public IActionResult Recherche()
        {
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.Soigneur = true;
            model.Criteres.Dps = true;
            model.Criteres.Tank = true;
            model.Resultat = DB.Enfants.ToList();
            return View(model);
        }
        [Route("/enfant/detail/{id:int?}")]
        [Route("/enfant/{id:int?}")]
       // [Route("/{id:int?}")]
        public IActionResult Detail(int id)
        {
            var Hero = this.DB.Enfants.Where(h => h.id == id).SingleOrDefault();
            if(Hero == null)
            {
                return View("NotFound");
            }
            return View("Detail",Hero);
        }
        [Route("/enfant/detail/{nom?}")]
        [Route("/enfant/{nom?}")]
       // [Route("/{nom?}")]
        public IActionResult Detail(string nom)
        {
            var Hero = this.DB.Enfants.Where(h => h.nom.ToUpper() == nom.ToUpper()).SingleOrDefault();
            if(Hero == null)
            {
                return View("NotFound");
            }
            return View("Detail",Hero);
        }

    }
}
