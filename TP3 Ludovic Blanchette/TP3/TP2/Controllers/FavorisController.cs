using Microsoft.AspNetCore.Mvc;

namespace TP2.Controllers
{

    public class FavorisController : Controller
    {
        [Route("/Favoris/index")]
        [Route("/index")]
        public IActionResult index()
        {
            return View("Favoris");
        }
    }
}
 