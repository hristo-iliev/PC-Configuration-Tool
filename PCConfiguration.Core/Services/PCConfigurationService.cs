using AutoMapper;
using PCConfiguration.Core.Models;
using PCConfiguration.DAL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCConfiguration.Core.Services
{
    public class PCConfigurationService : IPCConfigurationService
    {
        private readonly IPCConfigurationUoW _unitOfWork;
        private readonly IMapper _mapper;

        public PCConfigurationService(IPCConfigurationUoW uow, IMapper mapper)
        {
            _unitOfWork = uow;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PartViewModel>> GetAllParts()
        {
            var items = _mapper.Map<IEnumerable<PartViewModel>>(await _unitOfWork.GetAllItemsAsync());
            return items;
        }

        public async Task<IEnumerable<CPUViewModel>> GetAllCPUItems()
        {
            var cpuItems = _mapper.Map<IEnumerable<CPUViewModel>>(await _unitOfWork.CPU.GetAll());
            return cpuItems;
        }
        public async Task<IEnumerable<MotherboardViewModel>> GetAllMotherboardItems()
        {
            var motherboardItems = _mapper.Map<IEnumerable<MotherboardViewModel>>(await _unitOfWork.Motherboard.GetAll());
            return motherboardItems;
        }
        public async Task<MotherboardViewModel> GetMotherboardById(int id)
        {
            var motherboard = _mapper.Map<MotherboardViewModel>(await _unitOfWork.Motherboard.GetById(id));
            return motherboard;
        }

        public async Task<IEnumerable<RAMViewModel>> GetAllRAMItems()
        {
            var ramItems = _mapper.Map<IEnumerable<RAMViewModel>>(await _unitOfWork.RAM.GetAll());
            return ramItems;
        }
        public async Task<IEnumerable<StorageViewModel>> GetAllStorageItems()
        {
            var storages = _mapper.Map<IEnumerable<StorageViewModel>>(await _unitOfWork.Storage.GetAll());
            return storages;
        }
        public async Task<IEnumerable<VideoCardViewModel>> GetAllVideoCardItems()
        {
            var videoCardItems = _mapper.Map<IEnumerable<VideoCardViewModel>>(await _unitOfWork.VideoCard.GetAll());
            return videoCardItems;
        }
    }
}
