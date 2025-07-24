using BookShop.DataAccess.Data;
using BookShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Category
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList(); // GetAllCategories
            return View(categories);
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category); // CreateCategory
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }
    }
}
