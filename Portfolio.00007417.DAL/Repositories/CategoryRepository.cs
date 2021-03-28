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

        public async Task AddAsync(Category entity)
        {
            _context.Categories.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public bool IfExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }

    }
}
