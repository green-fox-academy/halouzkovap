using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicShop.Models
{
    public class ShopData : IShopData
    {
        private readonly ShopDbContext _shopDb;

        public ShopData(ShopDbContext shopDb)
        {
            _shopDb = shopDb;
        }

        public IEnumerable<Item> AllShoe()
        {
            return _shopDb.Shoes.ToList();
        }

        public double Averadge()
        {
            var number = _shopDb.Shoes.Count();
            var sum = _shopDb.Shoes.Sum(x => x.Price);
            var average = (double)sum / (double)number;
            return average;
        }

        public IEnumerable<Item> CheapestFirst()
        {
            return _shopDb.Shoes.OrderBy(x => x.Price);
        }

        public IEnumerable<Item> ContainsNike()
        {
            return _shopDb.Shoes.Where(x => x.Description.Contains("Nike"));
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetMostExpensive()
        {
            yield return _shopDb.Shoes.OrderByDescending(x => x.Price).FirstOrDefault();
        }

        public IEnumerable<Item> MostExpensive()
        {
            return _shopDb.Shoes.Where(x => x.QuantityOfStock > 0).OrderByDescending(x => x.Price);
        }

        public IEnumerable<Item> OnlyAvailable()
        {
            return _shopDb.Shoes.Where(x => x.QuantityOfStock > 0);
        }



    }
}
