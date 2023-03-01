using GestionScolaire.Data;
using GestionScolaire.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionScolaire.Controllers
{
    public class EleveController : Controller
    {
        private readonly ApplicationDBContext _db;

        public EleveController(ApplicationDBContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            var objEleveList = _db.eleves.ToList();
            return View(objEleveList);
        }

        //Ajouter une nouvelle matiere
        //Get from the client to the server
        public IActionResult Create()
        {
            return View();
        }
        //Post
        [HttpPost]
        public IActionResult Create(Eleve obj)
        {
            if (ModelState.IsValid)
            {
                _db.eleves.Add(obj);
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
            var CateforyFormDb = _db.eleves.Find(id);
            if (CateforyFormDb == null)
            {
                return NotFound();
            }
            return View(CateforyFormDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Eleve obj)
        {
            if (ModelState.IsValid)
            {
                _db.eleves.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public ActionResult Delete(int? id)
        {
            var model = _db.eleves.Find(id);
            _db.eleves.Remove(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
