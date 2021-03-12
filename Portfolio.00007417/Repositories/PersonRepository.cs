using Microsoft.EntityFrameworkCore;
using Portfolio._00007417.DAL.Context;
using Portfolio._00007417.DAL.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio._00007417.Repositories
{
    public class PersonRepository: BaseRepository, IRepository<Person>
    {
        public PersonRepository(CgiProductsDbContext context) : base(context)
        {

        }

        public async Task AddAsync(Person entity)
        {
            _context.People.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Person entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var people = await _context.People.FindAsync(id);
            _context.People.Remove(people);
            await _context.SaveChangesAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.People.FindAsync(id);
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.People.ToListAsync();
        }

        public bool IfExists(int id)
        {
            return _context.People.Any(e => e.Id == id);
        }

    }
}
