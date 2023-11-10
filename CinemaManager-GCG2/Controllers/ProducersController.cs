using CinemaManager_GCG2.Models.Cinema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManager_GCG2.Controllers
{
    public class ProducersController : Controller
    {
        CinemaDbGcg2Context _context;
        public ProducersController(CinemaDbGcg2Context context)
        {
            _context = context;
        }
        // GET: ProducersController
        public ActionResult Index()
        {
            return View(_context.Producers.ToList());
        }
        public ActionResult ProdsAndTheirMovies()
        {
            _context.Movies.ToList();
            return View(_context.Producers.ToList());
        }

        // GET: ProducersController/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.Producers.Find(id));
        }

        // GET: ProducersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProducersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producer p)
        {
            try
            {
                _context.Producers.Add(p);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProducersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.Producers.Find(id));
        }

        // POST: ProducersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Producer prod)
        {
            try
            {
                _context.Producers.Update(prod);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProducersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Producers.Find(id));
        }

        // POST: ProducersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Producer prod)
        {
            try
            {
                _context.Producers.Remove(prod);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
