using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
namespace CustomerBankAccount.Business.Abstract.ABANK
{
    public interface ABANKICustomer1AccountService
    {
        List<ABANKCustomer1Account> GetAllCustomer1Account();
        ABANKCustomer1Account GetCustomer1AccountById(int id);
        ABANKCustomer1Account PostCustomer1Account(ABANKCustomer1Account customer1Account);
        ABANKCustomer1Account PutCustomer1Account(ABANKCustomer1Account customer1Account);
        void DeleteCustomer1Account(int id);
    }
}
