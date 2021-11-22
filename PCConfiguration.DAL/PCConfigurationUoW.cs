using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using PCConfiguration.DAL.Properties;
using PCConfiguration.DAL.Repositories;
using PCConfigurationTool.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCConfiguration.DAL
{
    public class PCConfigurationUoW : IPCConfigurationUoW
    {
        private readonly PCConfigurationContext _context;

        public PCConfigurationUoW(PCConfigurationContext context, ILoggerFactory loggerFactory, IMemoryCache memoryCache)
        {
            _context = context;
            ILogger logger = loggerFactory.CreateLogger("logs");

            CPU = new GenericRepository<CPU>(context, Resources.CPU_KEY, memoryCache, logger);
            Motherboard = new GenericRepository<Motherboard>(context, Resources.MOTHERBOARD_KEY, memoryCache, logger);
            RAM = new GenericRepository<RAM>(context, Resources.RAM_KEY, memoryCache, logger);
            Storage = new GenericRepository<Storage>(context, Resources.STORAGE_KEY, memoryCache, logger);
            VideoCard = new GenericRepository<VideoCard>(context, Resources.VIDEOCARD_KEY, memoryCache, logger);
        }

        public IRepository<CPU> CPU { get; private set; }

        public IRepository<Motherboard> Motherboard { get; private set; }

        public IRepository<RAM> RAM { get; private set; }

        public IRepository<Storage> Storage { get; private set; }

        public IRepository<VideoCard> VideoCard { get; private set; }

        public async Task<IEnumerable<IPart>> GetAllItemsAsync()
        {
            var allItems = new List<IPart>();

            allItems.AddRange(await CPU.GetAll());
            allItems.AddRange(await Motherboard.GetAll());
            allItems.AddRange(await RAM.GetAll());
            allItems.AddRange(await Storage.GetAll());
            allItems.AddRange(await VideoCard.GetAll());

            return allItems;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
