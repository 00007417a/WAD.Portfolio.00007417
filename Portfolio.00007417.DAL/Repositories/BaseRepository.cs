using Portfolio._00007417.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio._00007417.DAL.Repositories
{
    // the abstract class will be inherited by repositories
    // this method is used to apply SRP
    public abstract class BaseRepository
    {
        protected readonly CgiProductsDbContext _context;

        protected BaseRepository(CgiProductsDbContext context)
        {
            _context = context;
        }
    }
}
