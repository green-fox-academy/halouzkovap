using FoxClub.Models;
using System.Collections.Generic;

namespace FoxClub.ViewModel
{
    public class FoxViewModel
    {
        public IEnumerable<Fox> Foxes { get; internal set; }
    }
}
