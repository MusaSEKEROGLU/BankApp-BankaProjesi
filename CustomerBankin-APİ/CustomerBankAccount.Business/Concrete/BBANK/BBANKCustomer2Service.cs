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
    public class BBANKCustomer2Service : BBANKICustomer2Service
    {
        private BBANKCustomer2Repository repository = new BBANKCustomer2Repository();
        public List<BBANKCustomer2> GetAllCustomer2()
        {
            return repository.GetAllCustomer2().ToList();
        }
        public BBANKCustomer2 GetCustomer2ById(int id)
        {
            return repository.GetCustomer2ById(id);
        }
        public BBANKCustomer2 PostCustomer2(BBANKCustomer2 customer2)
        {
            return repository.PostCustomer2(customer2);
        }
        public BBANKCustomer2 PutCustomer2(BBANKCustomer2 customer2)
        {
            return repository.PutCustomer2(customer2);
        }
        public void DeleteCustomer2(int id)
        {
             repository.DeleteCustomer2(id);
        }
    }
}
