using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularBlog.API.Models.GenericRepository
{
    public interface IAngularBlogRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);

        //Task Update(int id, T entity);

        Task Delete(T entity);
        Task<bool> SaveAll();
    }
}