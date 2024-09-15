using BulkyWeb.Data;
using BulkyWeb.Models;
using BulkyWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BulkyWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Index: Display list of products with categories
        public IActionResult Index()
        {
            var viewModel = new ProductCategoryViewModel
            {
                Products = _db.Products.ToList(),
                Categories = _db.Categories.ToList()
            };
            return View(viewModel);
        }

        // Create: Display form to create a new product
        public IActionResult Create()
        {
            var viewModel = new ProductCategoryViewModel
            {
                Categories = _db.Categories.ToList(),
                Product = new Product()
            };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductCategoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(viewModel.Product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            viewModel.Categories = _db.Categories.ToList();
            return View(viewModel);
        }

        // Edit: Display form to edit a product
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductCategoryViewModel
            {
                Product = product,
                Categories = _db.Categories.ToList()
            };
            return View(viewModel);
        }

        [HttpPost,ActionName("Edit")]
        public IActionResult Edit(ProductCategoryViewModel viewModel)
        {
            if (viewModel.Product.Id == 0)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Products.Update(viewModel.Product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            viewModel.Categories = _db.Categories.ToList();
            return View(viewModel);
        }



        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductCategoryViewModel
            {
                Product = product,
                Categories = _db.Categories.ToList()
            };
            return View(viewModel);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            var viewModel = new ProductCategoryViewModel
            {
                Product = product,
                Categories = _db.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}
