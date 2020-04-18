using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularBlog.API.Models;
using AngularBlog.API.Models.GenericRepository;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularBlog.API.Models.Repository
{
    public class AngularBlogRepository<T> : IAngularBlogRepository<T> where T : class, IEntityBase
    {
        private readonly DataContext _context;
        public AngularBlogRepository(DataContext context)
        {
            _context = context;

        }
        public async Task Create(T entity)
        {
            await _context.AddAsync(entity);
            //_context.SaveChanges();
        }

        public async Task Delete(T entity)
        {
            _context.Remove(entity);
            //_context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
         IQueryable<T> query = _context.Set<T>();
        return query;
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}