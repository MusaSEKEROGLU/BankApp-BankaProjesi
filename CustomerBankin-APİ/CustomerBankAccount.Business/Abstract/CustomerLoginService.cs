using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract
{
    public interface ICustomerLoginService
    {
        List<CustomerLogin> GetAllCustomerLogin();
        CustomerLogin GetCustomerLoginById(int id);
        CustomerLogin PostCustomerLogin(CustomerLogin customerLogin);
        CustomerLogin PutCustomerLogin(CustomerLogin customerLogin);
        void DeleteCustomerLogin(int id);
    }
}
