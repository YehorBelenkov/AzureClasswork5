using AzureSqlLab5.Models;
using AzureSqlLab5.Models.AzureSqlLab5;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AzureSqlLab5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Products()
        {
            using (var db = new ProductCategoryDbContext())
            {
                await db.Database.EnsureCreatedAsync();

                var products = db.Products.ToList();
                ViewBag.products = products;
            }

            return View();
        }
        [HttpPost]
        public IActionResult AddProducts(Product newProduct)
        {
            using (var context = new ProductCategoryDbContext())
            {
                context.Products.Add(newProduct);
                context.SaveChangesAsync();
            }
            return RedirectToAction("Products");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteProducts(int Id)
        {
            using (var db = new ProductCategoryDbContext())
            {
                Product product = db.Products.Where(o => o.Id == Id).AsNoTracking().FirstOrDefault();
                db.Remove(product);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Products");
        }
        public async Task<IActionResult> Categories()
        {
            using (var db = new ProductCategoryDbContext())
            {
                await db.Database.EnsureCreatedAsync();

                var categories = db.Categories.ToList();
                ViewBag.categories = categories;
            }
            return View();
        }
        [HttpPost]
        public IActionResult AddCategories(Category category)
        {
            using (var db = new ProductCategoryDbContext())
            {
                db.Categories.Add(category);
                db.SaveChangesAsync();
            }

            return RedirectToAction("Categories");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCategories(int Id)
        {
            using (var db = new ProductCategoryDbContext())
            {
                Category category = db.Categories.Where(o => o.Id == Id).AsNoTracking().FirstOrDefault();
                db.Remove(category);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Categories");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}