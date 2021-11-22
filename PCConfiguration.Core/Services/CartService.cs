using PCConfiguration.Core.Models;
using PCConfiguration.Core.Properties;
using System.Collections.Generic;
using System.Linq;

namespace PCConfiguration.Core.Services
{
    public class CartService : ICartService
    {
        public PCConfigurationViewModel SetupModel(IEnumerable<PartViewModel> items, Cart cart)
        {
            var model = new PCConfigurationViewModel();

            model.Parts = SetSelected(items, cart);
            model.Sum = cart != null ? Sum(cart) : 0;

            model.AllCPUEnabled = EnableAllByType(items, Resources.CPU_TYPE);
            model.AllMotherboardEnabled = EnableAllByType(items, Resources.MOTHERBOARD_TYPE);
            model.AllRAMEnabled = EnableAllByType(items, Resources.RAM_TYPE);
            model.AllStorageEnabled = EnableAllByType(items, Resources.STORAGE_TYPE);
            model.AllVideoCardEnabled = EnableAllByType(items, Resources.VIDEOCARD_TYPE);

            return model;
        }

        public decimal Sum(Cart cart)
        {
            return cart.SelectedItems.Sum(i => i.Price);
        }

        public void TogglePart(Cart cart, PartViewModel part)
        {
            var existingPart = cart.SelectedItems.FirstOrDefault(p => p.Id == part.Id && p.Name == part.Name);
            if (existingPart == null)
            {
                cart.SelectedItems.Add(part);
            }
            else
            {
                cart.SelectedItems.Remove(part);
            }
        }

        public IEnumerable<PartViewModel> SetSelected(IEnumerable<PartViewModel> allItems, Cart cart)
        {
            if (cart != null) 
            {
                foreach (var item in allItems)
                {
                    if (cart.SelectedItems.Any(p => p.Id == item.Id && p.Name == item.Name))
                    {
                        item.IsSelected = true;
                    }
                }
            }            

            return allItems;
        }

        public bool EnableAllByType(IEnumerable<PartViewModel> allItems, string type)
        {
            return allItems.Where(i => i.Type == type).All(p => !p.IsSelected);
        }
    }
}
