using eticket_app.Models;
using eTickets.Data;
using eTickets.Data.Base;

namespace eticket_app.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
