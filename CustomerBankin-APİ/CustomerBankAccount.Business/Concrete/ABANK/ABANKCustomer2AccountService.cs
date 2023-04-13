using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Concrete.ABANK
{
    public class ABANKCustomer2AccountService : ABANKICustomer2AccountService
    {
        private ABANKCustomer2AccountRepository _repository = new ABANKCustomer2AccountRepository();

        public List<ABANKCustomer2Account> GetAllCustomer2Account()
        {
            return _repository.GetAllCustomer2Account();
        }
        public ABANKCustomer2Account GetCustomer2AccountById(int id)
        {
            return _repository.GetCustomer2AccountById(id);
        }
        public ABANKCustomer2Account PostCustomer2Account(ABANKCustomer2Account customer2Account)
        {
            return _repository.PostCustomer2Account(customer2Account);
        }
        public ABANKCustomer2Account PutCustomer2Account(ABANKCustomer2Account customer2Account)
        {
            return _repository.PutCustomer2Account(customer2Account);
        }
        public void DeleteCustomer2Account(int id)
        {
             _repository.DeleteCustomer2Account(id);
        }
    }
}
