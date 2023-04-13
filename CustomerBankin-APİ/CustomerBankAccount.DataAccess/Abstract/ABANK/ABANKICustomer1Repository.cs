using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer1Repository
    {
        List<ABANKCustomer1> GetAllCustomer1();
        ABANKCustomer1 GetCustomer1ById(int id);
        ABANKCustomer1 PostCustomer1(ABANKCustomer1 customer1);
        ABANKCustomer1 PutCustomer1(ABANKCustomer1 customer1);
        void DeleteCustomer1(int id);
    }
}
