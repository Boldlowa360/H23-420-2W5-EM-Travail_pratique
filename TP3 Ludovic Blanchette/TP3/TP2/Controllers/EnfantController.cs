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


            //filtre par Favoris
            //Oui
            if (critere.Vedette != null)
            {
                if (critere.Vedette == "Oui")
                {
                    donnees = this.DB.Enfants.Where(h => h.Favoris == true);
                }
                //Non
                if (critere.Vedette == "Non")
                {
                    donnees = this.DB.Enfants.Where(h => h.Favoris == false);
                }
                //peu importe
                if (critere.Vedette == "Peu importe")
                {//Filtre par mots clé
                    if (critere.Nom != null)
                    {
                        donnees = this.DB.Enfants.Where(h => h.nom.ToUpper().Contains(critere.Nom.ToUpper()));
                    }
                    //filtre par niveau de difficulté
                    if (critere.Difficulté == 1)
                    {
                        donnees = this.DB.Enfants.Where(h => h.difficulté == 1);
                    }

                }
            }


            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Resultat = donnees.ToList();

            return View(nameof(Recherche), model);
        }

    }
}
