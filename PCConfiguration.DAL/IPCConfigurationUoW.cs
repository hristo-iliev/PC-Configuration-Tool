using PCConfiguration.DAL.Repositories;
using PCConfigurationTool.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCConfiguration.DAL
{
    public interface IPCConfigurationUoW
    {
        public IRepository<CPU> CPU { get; }
        public IRepository<Motherboard> Motherboard { get; }
        public IRepository<RAM> RAM { get; }
        public IRepository<Storage> Storage { get; }
        public IRepository<VideoCard> VideoCard { get; }

        Task<IEnumerable<IPart>> GetAllItemsAsync();
        Task CompleteAsync();
    }
}
