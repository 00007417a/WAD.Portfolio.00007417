using Portfolio._00007417.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio._00007417.DAL.Repositories
{
    public class BaseRepository
    {
        protected readonly CgiProductsDbContext _context;
        protected BaseRepository(CgiProductsDbContext context)
        {
            _context = context;
        }
    }
}
