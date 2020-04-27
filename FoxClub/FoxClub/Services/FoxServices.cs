using FoxClub.DataContext;
using FoxClub.Models;

using Microsoft.EntityFrameworkCore;
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

        public void AddFoxNutrition(int foxId, string trick)
        {
            var fox = foxClubDbContext.Foxes.Find(foxId);
            var id = fox.Id;

            var nutrition = new Nutrition
            {
                Food = trick,
                FoxId = id
            };
            foxClubDbContext.Nutritions.Add(nutrition);
            foxClubDbContext.SaveChanges();
        }

        public void AddFoxTrick(int foxId, string trick)
        {

            var fox = foxClubDbContext.Foxes.Find(foxId);
            var id = fox.Id;

            var tricks = new Trick
            {
                NameTrick = trick,
                FoxId = id
            };
            foxClubDbContext.Tricks.Add(tricks);
            foxClubDbContext.SaveChanges();

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
            return foxClubDbContext.Foxes.Include(f => f.Tricks).Include(f => f.Nutritions).FirstOrDefault(f => f.Id == id);
        }



        public IEnumerable<Fox> GetFoxes()
        {
            return foxClubDbContext.Foxes.Include(f => f.Tricks).Include(f => f.Nutritions);
        }

        public Fox GetFoxWithNAme(string name)
        {
            var fox = foxClubDbContext.Foxes.FirstOrDefault(f => f.Name == name);
            return fox;
        }

        public IEnumerable<Nutrition> GetNutritions()
        {
            return foxClubDbContext.Nutritions;

        }


        public IEnumerable<Trick> GetTricks()
        {
            return foxClubDbContext.Tricks;

        }
    }
}
