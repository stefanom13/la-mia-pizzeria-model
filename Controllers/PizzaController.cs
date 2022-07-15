using Microsoft.AspNetCore.Http;
using la_mia_pizzeria_model;
using Microsoft.AspNetCore.Mvc;


namespace la_mia_pizzeria_model.Controllers
{
    public class PizzaController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            List<Pizza> pizze = new List<Pizza>{
                new Pizza("Margherita", "La margherita più buona della città","pathimage", 5.45f),
                new Pizza("Capricciosa", "Super pizza Capricciosa","pathimage", 6.5f),
                new Pizza("Tonno e Cipolla", "Rossi","pathimage", 6.5f),
            };

            return View(pizze);
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
