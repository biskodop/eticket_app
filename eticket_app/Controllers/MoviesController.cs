using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eticket_app.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Movies.ToList();
            return View();
        }
    }
}
