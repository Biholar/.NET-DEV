using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MilkMarket.Domain.Persistence.Contexts;


namespace MilkMarket.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
