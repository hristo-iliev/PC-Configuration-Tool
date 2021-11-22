using PCConfiguration.Core.Models;
using System.Collections.Generic;

namespace PCConfiguration.Core
{
    /// <summary>
    /// Cart object is used to be stored in the Session Storage
    /// </summary>
    public class Cart
    {
        protected IList<PartViewModel> _selectedItems = new List<PartViewModel>();

        public IList<PartViewModel> SelectedItems
        {
            get
            { 
                return _selectedItems;
            }
            set 
            { 
                _selectedItems = value;
            }
        }
    }
}
