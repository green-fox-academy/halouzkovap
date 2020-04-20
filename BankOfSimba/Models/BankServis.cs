using System.Collections.Generic;

namespace BankOfSimba.Models
{
    public class BankServis : IBankServis
    {
        private readonly BankOfSimbaDbContext _bankOfSimbaDbContext;

        public BankServis(BankOfSimbaDbContext bankOfSimbaDbContext)
        {
            _bankOfSimbaDbContext = bankOfSimbaDbContext;
        }
        public IEnumerable<BankAccount> GettAll()
        {
            return _bankOfSimbaDbContext.BankAccounts;
        }
    }
}
