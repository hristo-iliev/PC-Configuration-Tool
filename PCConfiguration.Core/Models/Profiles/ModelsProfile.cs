using AutoMapper;
using PCConfigurationTool.DataModel;

namespace PCConfiguration.Core.Models.Profiles
{
    public class ModelsProfile : Profile
    {
        public ModelsProfile()
        {
            CreateMap<CPU, CPUViewModel>();
            CreateMap<Motherboard, MotherboardViewModel>();
            CreateMap<RAM, RAMViewModel>();
            CreateMap<Storage, StorageViewModel>();
            CreateMap<VideoCard, VideoCardViewModel>();
            CreateMap<IPart, PartViewModel>()
                .ForMember(x => x.Type, m => m.MapFrom(p => p.GetType().Name));
        }
    }
}
