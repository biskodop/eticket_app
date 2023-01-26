using eticket_app.Models;
using eTickets.Data.Base;
using eTickets.Data;

namespace eticket_app.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context) : base(context) { }
    }
}
