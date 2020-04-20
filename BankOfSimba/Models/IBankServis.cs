using System.Collections.Generic;

namespace BankOfSimba.Models
{
    public interface IBankServis
    {
        public IEnumerable<BankAccount> GettAll();
    }
}
