using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer2Repository
    {
        List<ABANKCustomer2> GetAllCustomer2();
        ABANKCustomer2 GetCustomer2ById(int id);
        ABANKCustomer2 PostCustomer2(ABANKCustomer2 customer2);
        ABANKCustomer2 PutCustomer2(ABANKCustomer2 customer2);
        void DeleteCustomer2(int id);
    }
}
