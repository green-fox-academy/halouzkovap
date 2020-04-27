using FoxClub.Models;

using System.Collections.Generic;

namespace FoxClub.Services
{
    public interface IFoxServices
    {
        public void CreateFox(Fox fox);
        public IEnumerable<Fox> GetFoxes();

        public Fox GetFox(int id);
        public Fox GetFoxWithNAme(string name);
        public bool CheckFox(Fox fox);
        public void AddFoxTrick(int foxId, string trick);
        public void AddFoxNutrition(int foxId, string trick);

        public IEnumerable<Nutrition> GetNutritions();
        public IEnumerable<Trick> GetTricks();

    }
}
