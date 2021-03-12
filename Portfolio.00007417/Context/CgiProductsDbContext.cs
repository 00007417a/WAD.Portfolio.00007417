using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio._00007417.DAL.DBO;

namespace Portfolio._00007417.DAL.Context
{
    public class CgiProductsDbContext : DbContext
    {
        public CgiProductsDbContext(DbContextOptions<CgiProductsDbContext> options):
            base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Person> People { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
    }
}
