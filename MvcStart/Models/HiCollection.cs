using System.Collections.Generic;
using System.Linq;

namespace MvcStart.Models
{
    public class HiCollection : IHiCollection
    {
        public IEnumerable<Hello> hellow => new List<Hello> {

        new Hello{ Hi="Hello"},
        new Hello{ Hi="Hallo"},
        new Hello{ Hi="Qanuipit"},
        new Hello{ Hi="Hola"},
        new Hello{ Hi="Nei Ho"},
        new Hello{ Hi="Jambo"},
        new Hello{ Hi="Bonjour"},
        new Hello{ Hi="Hello"},
        new Hello{ Hi="Hello"},
        };



        public Hello GetHello(int id)
        {
            return hellow.ElementAt(id);
        }
    }
}
