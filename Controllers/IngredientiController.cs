using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_model.Controllers
{
    public class IngredientiController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            List<Ingredienti> ingredients = new List<Ingredienti>{
             new Ingredienti("Passata di Pomodoro"),
             new Ingredienti("Cipolla"),
             new Ingredienti("Tonno"),
             new Ingredienti("Prosciutto Crudo"),
             new Ingredienti("Melanzane"),
             new Ingredienti("Funghi"),
             new Ingredienti("Patatine"),
             new Ingredienti("Wurstell"),
             new Ingredienti("Melanzana"),
             new Ingredienti("Parmigiano"),

            };

            return View("index", ingredients);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
