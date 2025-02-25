using Microsoft.AspNetCore.Mvc;
using taskk4.Models;

namespace taskk4.Controllers
{
    public class cards : Controller
    {

        private readonly MyDbContextProduct _dddd;

        public cards(MyDbContextProduct dddd)
        {
            _dddd = dddd;
        }

        public IActionResult Index()
        {
            var s = _dddd.Productts.ToList();
            return View(s);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Productt product)
        {
            if (ModelState.IsValid)
            {
                _dddd.Productts.Add(product);
                _dddd.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
        public IActionResult Details(int Id)
        {
          var f=  _dddd.Productts.Find(Id);
            if (f == null)
            {
                return NotFound();
            }
            return View(f);
        }
        public IActionResult Delete(int Id)
        {
            var d = _dddd.Productts.Find(Id);
            if (d == null)
            {
                return NotFound();
            }
            _dddd.Productts.Remove(d);
            _dddd.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            var e = _dddd.Productts.Find(Id);
            return View(e);
        }
        [HttpPost]
        public IActionResult Edit(Productt sss)
        {
            _dddd.Update(sss);
            _dddd.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}
