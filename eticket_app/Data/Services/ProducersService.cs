using eticket_app.Models;
using eticket_app.Data;
using eticket_app.Data.Base;

namespace eticket_app.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
