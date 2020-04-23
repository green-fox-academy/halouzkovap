using FoxClub.Models;
using System.Collections.Generic;

namespace FoxClub.Services
{
    public interface IFoxServices
    {
        public void CreateFox(Fox fox);
        public IEnumerable<Fox> GetFoxes();
        public Fox GetFox(int id);
        public bool CheckFox(Fox fox);
    }
}
