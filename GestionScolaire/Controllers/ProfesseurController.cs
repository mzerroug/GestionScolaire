using Microsoft.AspNetCore.Mvc;

namespace GestionScolaire.Controllers
{
    public class ProfesseurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
