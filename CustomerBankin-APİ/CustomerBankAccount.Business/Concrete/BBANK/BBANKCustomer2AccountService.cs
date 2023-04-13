using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.DataAccess.Concrete.BBANK;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Concrete.BBANK
{
    public class BBANKCustomer2AccountService : BBANKICustomer2AccountService
    {
        private BBANKCustomer2AccountRepository repository = new BBANKCustomer2AccountRepository();
        public List<BBANKCustomer2Account> GetAllCustomer2Account()
        {
            return repository.GetAllCustomer2Account().ToList();
        }
        public BBANKCustomer2Account GetCustomer2AccountById(int id)
        {
            return repository.GetCustomer2AccountById(id);
        }
        public BBANKCustomer2Account PostCustomer2Account(BBANKCustomer2Account customer2Account)
        {
            return repository.PostCustomer2Account(customer2Account);
        }
        public BBANKCustomer2Account PutCustomer2Account(BBANKCustomer2Account customer2Account)
        {
            return repository.PutCustomer2Account(customer2Account);
        }
        public void DeleteCustomer2Account(int id)
        {
             repository.DeleteCustomer2Account(id);
        }
    }
}
