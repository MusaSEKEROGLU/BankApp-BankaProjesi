using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract.BBANK
{
    public interface BBANKICustomer1Service
    {
        List<BBANKCustomer1> GetAllCustomer1();
        BBANKCustomer1 GetCustomer1ById(int id);
        BBANKCustomer1 PostCustomer1(BBANKCustomer1 customer1);
        BBANKCustomer1 PutCustomer1(BBANKCustomer1 customer1);
        void DeleteCustomer1(int id);
    }
}
