using Microsoft.EntityFrameworkCore;
using Portfolio._00007417.DAL.Context;
using Portfolio._00007417.DAL.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio._00007417.DAL.Repositories
{
    public class ProductRepository : BaseRepository, IRepository<Product>
    {
        public ProductRepository(CgiProductsDbContext context) : base(context)
        {

        }
        // method for adding a product to a table
        public async Task AddAsync(Product entity)
        {
            _context.Products.Add(entity);
            await _context.SaveChangesAsync();
        }
        // editing functionality
        public async Task UpdateAsync(Product entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // this method accepts an id of a specific product and removes it from the table
        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        // gets a specific item from the table
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        // method for getting all the records from the table
        public async Task<List<Product>> GetAllAsync()
        {
            // includes product category
            return await _context.Products.Include("ProductCategory").ToListAsync();
        }

        // check if exists
        public bool IfExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

    }
}
