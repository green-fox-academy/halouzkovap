using FoxClub.DataContext;
using FoxClub.Models;
using System.Collections.Generic;
using System.Linq;

namespace FoxClub.Services
{
    public class FoxServices : IFoxServices
    {
        private readonly FoxClubDbContext foxClubDbContext;

        public FoxServices(FoxClubDbContext foxClubDbContext)
        {
            this.foxClubDbContext = foxClubDbContext;
        }

        public bool CheckFox(Fox fox)
        {
            var result = foxClubDbContext.Foxes.FirstOrDefault(f => f.Name == fox.Name);
            if (result == null)
            {
                return true;
            }
            return false;
        }

        public void CreateFox(Fox fox)
        {
            foxClubDbContext.Foxes.Add(fox);
            foxClubDbContext.SaveChanges();
        }

        public Fox GetFox(int id)
        {
            return foxClubDbContext.Foxes.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Fox> GetFoxes()
        {
            return foxClubDbContext.Foxes;
        }
    }
}
