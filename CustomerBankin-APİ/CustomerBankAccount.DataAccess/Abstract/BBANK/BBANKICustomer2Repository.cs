using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.BBANK
{
    public interface BBANKICustomer2Repository
    {
        List<BBANKCustomer2> GetAllCustomer2();
        BBANKCustomer2 GetCustomer2ById(int id);
        BBANKCustomer2 PostCustomer2(BBANKCustomer2 customer2);
        BBANKCustomer2 PutCustomer2(BBANKCustomer2 customer2);
        void DeleteCustomer2(int id);
    }
}
