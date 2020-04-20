using System.Collections.Generic;

namespace BankOfSimba.Models
{
    public interface IBankServis
    {
        public IEnumerable<BankAccount> GettAll();

        public void CreateBankAccount(BankAccount bank);
        public void RaiseBalance();
    }
}
