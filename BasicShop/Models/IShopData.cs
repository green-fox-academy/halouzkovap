using System.Collections.Generic;

namespace BasicShop.Models
{
    public interface IShopData
    {
        IEnumerable<Item> OnlyAvailable();
        IEnumerable<Item> CheapestFirst();
        IEnumerable<Item> ContainsNike();
        public double Averadge();
        IEnumerable<Item> MostExpensive();
        IEnumerable<Item> AllShoe();
        Item GetById(int id);

        IEnumerable<Item> GetMostExpensive();



    }
}
