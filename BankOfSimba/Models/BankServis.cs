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

        public void CreateBankAccount(BankAccount bankAccount)
        {


            _bankOfSimbaDbContext.BankAccounts.Add(bankAccount);

            _bankOfSimbaDbContext.SaveChanges();
        }

        public void DecreaseBalance()
        {
            foreach (var item in _bankOfSimbaDbContext.BankAccounts)
            {
                if (item.Name == "King")
                {
                    item.Balance -= 100;

                }
                else
                {
                    item.Balance -= 10;
                }
            }
            _bankOfSimbaDbContext.SaveChanges();
        }

        public IEnumerable<BankAccount> GettAll()
        {
            return _bankOfSimbaDbContext.BankAccounts;
        }

        public void RaiseBalance()
        {
            foreach (var item in _bankOfSimbaDbContext.BankAccounts)
            {
                if (item.Name == "King")
                {
                    item.Balance += 100;

                }
                else
                {
                    item.Balance += 10;
                }
            }
            _bankOfSimbaDbContext.SaveChanges();
        }

        public void TakeThemALL()
        {
            foreach (var item in _bankOfSimbaDbContext.BankAccounts)
            {
                item.Balance = 0;
            }
            _bankOfSimbaDbContext.SaveChanges();
        }
    }
}
