using FoxClub.Models;

using System.Collections.Generic;

namespace FoxClub.Services
{
    public interface IFoxServices
    {
        public void CreateFox(Fox fox);
        public IEnumerable<Fox> GetFoxes();
        public IEnumerable<Fox> GetOnlyFoxes();
        public Fox GetFox(int id);
        public bool CheckFox(Fox fox);
        public void AddFoxTrick(int foxId, string trick);
        public void AddFoxNutrition(int foxId, string trick);

        public IEnumerable<Nutrition> GetNutritions();
        public IEnumerable<Trick> GetTricks();

    }
}
