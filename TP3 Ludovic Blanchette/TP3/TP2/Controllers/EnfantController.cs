using Microsoft.AspNetCore.Mvc;
using TP2.ViewModels;
using TP2.Models;
using Microsoft.AspNetCore.Http.Metadata;
using System.Reflection;

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
            if (Hero == null)
            {
                return View("NotFound");
            }
            return View("Detail", Hero);
        }
        [Route("/enfant/detail/{nom?}")]
        [Route("/enfant/{nom?}")]
        // [Route("/{nom?}")]
        public IActionResult Detail(string nom)
        {
            var Hero = this.DB.Enfants.Where(h => h.nom.ToUpper() == nom.ToUpper()).SingleOrDefault();
            if (Hero == null)
            {
                return View("NotFound");
            }
            return View("Detail", Hero);
        }

        [Route("/Enfant/Recherche/Filtrer")]
        [Route("/enfant/Filtrer")]
        [Route("/Filtrer")]
        public IActionResult Filtrer(CritereRechercheViewModel critere)
        {
            IEnumerable<Enfant> donnees = DB.Enfants;





            //filtre par Nom
            if (critere.Nom != null)
            {
                donnees = donnees.Where(h => h.nom.ToUpper().Contains(critere.Nom.ToUpper()));
            }

            //Oui
            if (critere.Favoris == "Oui")
            {
                donnees = donnees.Where(h => h.Favoris == true);
            }
            //Non
            if (critere.Favoris == "Non")
            {
                donnees = donnees.Where(h => h.Favoris == false);
            }
            //Tous
            if (critere.Favoris == "Tous")
            {


            }
            //Par niveau de difficulté
            if (critere.Difficulté == 1)
            {
                donnees = donnees.Where(h => h.difficulté == 1);
            }
            if (critere.Difficulté == 2)
            {
                donnees = donnees.Where(h => h.difficulté == 2);
            }
            if (critere.Difficulté == 3)
            {
                donnees = donnees.Where(h => h.difficulté == 3);

            }
            //Filtre par roles
            if(critere.Soigneur || critere.Tank || critere.Dps)
            {
                donnees = donnees.Where(h => (h.IdParent == 1 && critere.Dps) || (h.IdParent == 2 && critere.Soigneur) || (h.IdParent == 3 && critere.Tank));
            }






            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Resultat = donnees.ToList();

            return View(nameof(Recherche), model);
        }

    }
}
