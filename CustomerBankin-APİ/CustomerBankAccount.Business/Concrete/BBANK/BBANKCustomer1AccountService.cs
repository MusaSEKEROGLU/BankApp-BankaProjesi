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
    public class BBANKCustomer1AccountService : BBANKICustomer1AccountService
    {
        private BBANKCustomer1AccountRepository repository = new BBANKCustomer1AccountRepository();
        public List<BBANKCustomer1Account> GetAllCustomer1Account()
        {
            return repository.GetAllCustomer1Account().ToList();
        }
        public BBANKCustomer1Account GetCustomer1AccountById(int id)
        {
            return repository.GetCustomer1AccountById(id);
        }
        public BBANKCustomer1Account PostCustomer1Account(BBANKCustomer1Account customer1Account)
        {
            return repository.PostCustomer1Account(customer1Account);
        }
        public BBANKCustomer1Account PutCustomer1Account(BBANKCustomer1Account customer1Account)
        {
            return repository.PutCustomer1Account(customer1Account);
        }
        public void DeleteCustomer1Account(int id)
        {
             repository.DeleteCustomer1Account(id);
        }
    }
}
