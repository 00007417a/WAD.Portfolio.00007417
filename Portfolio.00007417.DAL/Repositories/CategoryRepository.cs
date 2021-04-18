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
    public class CategoryRepository : BaseRepository, IRepository<Category>
    {
        public CategoryRepository(CgiProductsDbContext context) : base(context)
        {

        }

        // method for adding a category to a table
        public async Task AddAsync(Category entity)
        {
            _context.Categories.Add(entity);
            await _context.SaveChangesAsync();
        }

        // editing functionality
        public async Task UpdateAsync(Category entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // this method accepts an id of a specific category and removes it from the list
        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        // gets a specific item from the table
        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        // method for getting all the records from the table
        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        // check if exists
        public bool IfExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }

    }
}
