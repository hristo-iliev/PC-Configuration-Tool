using System.Collections.Generic;

namespace PCConfiguration.Core.Models
{
    public class PCConfigurationViewModel
    {
        public IEnumerable<PartViewModel> Parts {get;set;}
        public decimal Sum { get; set; }
        public bool AllCPUEnabled { get; set; }
        public bool AllMotherboardEnabled { get; set; }
        public bool AllRAMEnabled { get; set; }
        public bool AllStorageEnabled { get; set; }
        public bool AllVideoCardEnabled { get; set; }
    }
}
