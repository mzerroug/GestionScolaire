using GestionScolaire.Data;
using GestionScolaire.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionScolaire.Controllers
{
    public class MatiereController : Controller
    {
        private readonly ApplicationDBContext _db;

        public MatiereController(ApplicationDBContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            var objMatiereList = _db.matieres.ToList();
            return View(objMatiereList);
        }

        //Ajouter une nouvelle matiere
        //Get from the client to the server
        public IActionResult Create()
        {
            return View();
        }
        //Post
        [HttpPost]
        public IActionResult Create(Matiere obj)
        {
            if (ModelState.IsValid)
            {
                _db.matieres.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //Mise ajour d'une matiere

        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CateforyFormDb = _db.matieres.Find(id);
            if (CateforyFormDb == null)
            {
                return NotFound();
            }
            return View(CateforyFormDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Matiere obj)
        {
            if (ModelState.IsValid)
            {
                _db.matieres.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public ActionResult Delete(int? id)
        {
            var model = _db.matieres.Find(id);
            _db.matieres.Remove(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
