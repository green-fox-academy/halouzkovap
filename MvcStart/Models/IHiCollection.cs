using System.Collections.Generic;

namespace MvcStart.Models
{
    public interface IHiCollection
    {
        IEnumerable<Hello> hellow { get; }
        public Hello GetHello(int id);
    }
}
