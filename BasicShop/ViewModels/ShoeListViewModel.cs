using BasicShop.Models;
using System.Collections.Generic;

namespace BasicShop.ViewModels
{
    public class ShoeListViewModel
    {
        public IEnumerable<Item> Shoes { get; internal set; }
    }
}
