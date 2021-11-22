using PCConfiguration.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCConfiguration.Core.Services
{
    public interface IPCConfigurationService
    {
        Task<IEnumerable<PartViewModel>> GetAllParts();
        Task<IEnumerable<CPUViewModel>> GetAllCPUItems();
        Task<IEnumerable<MotherboardViewModel>> GetAllMotherboardItems();
        Task<MotherboardViewModel> GetMotherboardById(int id);
        Task<IEnumerable<RAMViewModel>> GetAllRAMItems();
        Task<IEnumerable<StorageViewModel>> GetAllStorageItems();
        Task<IEnumerable<VideoCardViewModel>> GetAllVideoCardItems();
    }
}