using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels
{
    public class BankAccountViewModel
    {
        public IEnumerable<BankAccount> Account { get; internal set; }
    }
}
