using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
namespace CustomerBankAccount.Business.Abstract.ABANK
{
    public interface ABANKICustomer2AccountService
    {
        List<ABANKCustomer2Account> GetAllCustomer2Account();
        ABANKCustomer2Account GetCustomer2AccountById(int id);
        ABANKCustomer2Account PostCustomer2Account(ABANKCustomer2Account customer2Account);
        ABANKCustomer2Account PutCustomer2Account(ABANKCustomer2Account customer2Account);
        void DeleteCustomer2Account(int id);
    }
}
