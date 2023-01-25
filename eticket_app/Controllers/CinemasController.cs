using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eticket_app.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Producers.ToList();
            return View();
        }
    }
}
