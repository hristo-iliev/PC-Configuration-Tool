using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCConfiguration.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);
    }
}
