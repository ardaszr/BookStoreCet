using BookStoreCet.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreCet.Controllers
{
    public class PublisherController : Controller
    {
        ApplicationDbContext dbContext;
        public PublisherController(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Publisher> publishers = dbContext.Publishers.ToList();
            return View(publishers);
        }

        public IActionResult Details (int id)
        {
            var publisher = dbContext.Publishers.Find(id);

            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }
    }
}
