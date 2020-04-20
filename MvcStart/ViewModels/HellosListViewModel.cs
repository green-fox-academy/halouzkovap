using MvcStart.Models;
using System.Collections.Generic;

namespace MvcStart.ViewModels
{
    public class HellosListViewModel
    {
        public IEnumerable<Hello> hellos { get; set; }
    }
}
