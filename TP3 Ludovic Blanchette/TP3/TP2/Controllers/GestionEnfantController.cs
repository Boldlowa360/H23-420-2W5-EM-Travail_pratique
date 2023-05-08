using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP2.Models;

namespace TP2.Controllers
{
    public class GestionEnfantController : Controller
    {
        private Database DB { get; set; }

        public GestionEnfantController(Database db)
        {
            this.DB = db;
        }

        [Route("/GestionEnfant/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            Enfant enfant = DB.Enfants.Where(h => h.id == id).SingleOrDefault();
            if(enfant != null)
            {
                return View(enfant);
            }
            return View("NotFound");
        }

        // POST: GestionEnfantController/Delete/5
        [Route("/GestionEnfant/Delete/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Enfant enfant)
        {
            enfant = DB.Enfants.Where(h => h.id == id).SingleOrDefault();
            if (enfant != null)
            {
                var parent = DB.Parents.Where(r => r.Id == enfant.IdParent).SingleOrDefault();
                parent.Enfants.Remove(enfant);
                DB.Enfants.Remove(enfant);
                
            }
            return RedirectToAction("Index","Home");
        }
    }
}
