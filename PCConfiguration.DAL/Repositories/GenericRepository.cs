using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using PCConfigurationTool.DataModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCConfiguration.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected PCConfigurationContext _context;
        internal DbSet<T> _dbSet;
        protected ILogger _logger;
        private IMemoryCache _memoryCache;
        private string _cacheKey;


        public GenericRepository(PCConfigurationContext context, string key, IMemoryCache memoryCache, ILogger logger)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
            this._memoryCache = memoryCache;
            this._cacheKey = key;
            this._logger = logger;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                if (!_memoryCache.TryGetValue(_cacheKey, out IEnumerable<T> cacheValue))
                {
                    cacheValue = await this._dbSet.ToListAsync(); 

                    var cacheEntryOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromMinutes(1))
                        .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                    _memoryCache.Set(_cacheKey, cacheValue, cacheEntryOptions);
                }

                return cacheValue;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, typeof(T).FullName + " - GetAll() function error");
                return new List<T>();
            }            
        }

        public async Task<T> GetById(int id)
        {
            return await this._dbSet.FindAsync(id);
        }
    }
}
