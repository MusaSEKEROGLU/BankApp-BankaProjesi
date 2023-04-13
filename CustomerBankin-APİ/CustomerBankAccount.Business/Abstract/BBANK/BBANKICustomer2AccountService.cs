using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract.BBANK
{
    public interface BBANKICustomer2AccountService
    {
        List<BBANKCustomer2Account> GetAllCustomer2Account();
        BBANKCustomer2Account GetCustomer2AccountById(int id);
        BBANKCustomer2Account PostCustomer2Account(BBANKCustomer2Account customer2Account);
        BBANKCustomer2Account PutCustomer2Account(BBANKCustomer2Account customer2Account);
        void DeleteCustomer2Account(int id);
    }
}
