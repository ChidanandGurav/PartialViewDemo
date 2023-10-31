using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Data;
using PartialViewDemo.Models;

namespace PartialViewDemo.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext context;

        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var model = context.Books.ToList();
            return View(model);
        }
    }
}
