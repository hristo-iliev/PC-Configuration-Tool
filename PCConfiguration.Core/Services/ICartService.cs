using PCConfiguration.Core.Models;
using System.Collections.Generic;

namespace PCConfiguration.Core.Services
{
    public interface ICartService
    {
        PCConfigurationViewModel SetupModel(IEnumerable<PartViewModel> items, Cart cart);

        decimal Sum(Cart cart);

        void TogglePart(Cart cart, PartViewModel part);

        IEnumerable<PartViewModel> SetSelected(IEnumerable<PartViewModel> allItems, Cart cart);

        bool EnableAllByType(IEnumerable<PartViewModel> allItems, string type);
    }
}
