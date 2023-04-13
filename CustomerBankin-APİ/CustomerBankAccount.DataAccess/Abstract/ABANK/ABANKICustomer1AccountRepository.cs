using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer1AccountRepository
    {
        List<ABANKCustomer1Account> GetAllCustomer1Account();
        ABANKCustomer1Account GetCustomer1AccountById(int id);
        ABANKCustomer1Account PostCustomer1Account(ABANKCustomer1Account customer1Account);
        ABANKCustomer1Account PutCustomer1Account(ABANKCustomer1Account customer1Account);
        void DeleteCustomer1Account(int id);
    }
}
