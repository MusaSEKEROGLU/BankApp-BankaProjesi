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
    public class ABANKCustomer1AccountService : ABANKICustomer1AccountService
    {
        private ABANKCustomer1AccountRepository _repository = new ABANKCustomer1AccountRepository();

        public List<ABANKCustomer1Account> GetAllCustomer1Account()
        {
            return _repository.GetAllCustomer1Account();
        }
        public ABANKCustomer1Account GetCustomer1AccountById(int id)
        {
            return _repository.GetCustomer1AccountById(id);
        }
        public ABANKCustomer1Account PostCustomer1Account(ABANKCustomer1Account customer1Account)
        {
            return _repository.PostCustomer1Account(customer1Account);
        }
        public ABANKCustomer1Account PutCustomer1Account(ABANKCustomer1Account customer1Account)
        {
            return _repository.PutCustomer1Account(customer1Account);
        }
        public void DeleteCustomer1Account(int id)
        {
            _repository.DeleteCustomer1Account(id);
        }
    }
}
