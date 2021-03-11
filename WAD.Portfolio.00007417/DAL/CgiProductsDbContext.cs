using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD.Portfolio._00007417.Models;

namespace WAD.Portfolio._00007417.DAL
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
