using BookStoreCet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreCet.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext dbContext;
        public CategoryController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Category> categories = dbContext.Categories.ToList();
            return View(categories);
        }

        /*
        public IActionResult Details(int id)
        {
            var category = dbContext.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        */

        public IActionResult Details(int id)
        {
            var category = dbContext.Categories.Include(c => c.Books).FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
    }
}
