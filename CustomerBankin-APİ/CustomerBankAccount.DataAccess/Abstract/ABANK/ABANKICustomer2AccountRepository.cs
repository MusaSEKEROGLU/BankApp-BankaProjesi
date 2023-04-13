using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer2AccountRepository
    {
        List<ABANKCustomer2Account> GetAllCustomer2Account();
        ABANKCustomer2Account GetCustomer2AccountById(int id);
        ABANKCustomer2Account PostCustomer2Account(ABANKCustomer2Account customer2Account);
        ABANKCustomer2Account PutCustomer2Account(ABANKCustomer2Account customer2Account);
        void DeleteCustomer2Account(int id);
    }
}
