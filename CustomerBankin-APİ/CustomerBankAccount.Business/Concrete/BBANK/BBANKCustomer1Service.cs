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
    public class BBANKCustomer1Service : BBANKICustomer1Service
    {
        private BBANKCustomer1Repository repository = new BBANKCustomer1Repository();
        public List<BBANKCustomer1> GetAllCustomer1()
        {
            return repository.GetAllCustomer1().ToList();
        }
        public BBANKCustomer1 GetCustomer1ById(int id)
        {
            return repository.GetCustomer1ById(id);
        }
        public BBANKCustomer1 PostCustomer1(BBANKCustomer1 customer1)
        {
            return repository.PostCustomer1(customer1);
        }
        public BBANKCustomer1 PutCustomer1(BBANKCustomer1 customer1)
        {
            return repository.PutCustomer1(customer1);
        }
        public void DeleteCustomer1(int id)
        {
             repository.DeleteCustomer1(id);
        }
    }
}
