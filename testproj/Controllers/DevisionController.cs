using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testproj.Controllers
{
    public class DevisionController : Controller
    {
        // GET: DevisionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DevisionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DevisionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DevisionController/Create
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

        // GET: DevisionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DevisionController/Edit/5
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

        // GET: DevisionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DevisionController/Delete/5
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
