using eticket_app.Models;
using eticket_app.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using eticket_app.Data.Base;

namespace eticket_app.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
