using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> category = _db.Categories.ToList();
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }
        public IActionResult Edit(int ?id)
        {
            if (id==0 || id==null)
            {
                return NotFound();
            }
            else
            {
                Category? item = _db.Categories.Find(id);
                return View(item);
            }
            
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            else
            {
                Category? item = _db.Categories.Find(id);
                return View(item);
            }

        }
        [HttpPost]
        public IActionResult Delete(Category obj)
        {
                _db.Categories.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
