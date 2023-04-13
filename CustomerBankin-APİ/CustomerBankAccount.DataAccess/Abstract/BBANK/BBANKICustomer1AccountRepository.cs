using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.BBANK
{
    public interface BBANKICustomer1AccountRepository
    {
        List<BBANKCustomer1Account> GetAllCustomer1Account();
        BBANKCustomer1Account GetCustomer1AccountById(int id);
        BBANKCustomer1Account PostCustomer1Account(BBANKCustomer1Account customer1Account);
        BBANKCustomer1Account PutCustomer1Account(BBANKCustomer1Account customer1Account);
        void DeleteCustomer1Account(int id);
    }
}
