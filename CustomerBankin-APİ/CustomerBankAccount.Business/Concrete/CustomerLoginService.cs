using CustomerBankAccount.Business.Abstract;
using CustomerBankAccount.DataAccess.Abstract;
using CustomerBankAccount.DataAccess.Concrete;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.DataAccess.Concrete.BBANK;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Concrete
{
    public class CustomerLoginService : ICustomerLoginService
    {
        private CustomerLoginRepository customerLoginRepository = new CustomerLoginRepository();
        public void DeleteCustomerLogin(int id)
        {
             customerLoginRepository.DeleteCustomerLogin(id);
        }
        public List<CustomerLogin> GetAllCustomerLogin()
        {
            return customerLoginRepository.GetAllCustomerLogin().ToList();
        }
        public CustomerLogin GetCustomerLoginById(int id)
        {
            return customerLoginRepository.GetCustomerLoginById(id);
        }
        public CustomerLogin PostCustomerLogin(CustomerLogin customerLogin)
        {
            return customerLoginRepository.PostCustomerLogin(customerLogin);
        }
        public CustomerLogin PutCustomerLogin(CustomerLogin customerLogin)
        {
            return customerLoginRepository.PutCustomerLogin(customerLogin);
        }
    }
}
