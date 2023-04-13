using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Concrete.ABANK
{
    public class ABANKCustomer1Service : ABANKICustomer1Service
    {
        private ABANKCustomer1Repository repository = new ABANKCustomer1Repository();
        public List<ABANKCustomer1> GetAllCustomer1()
        {
            return repository.GetAllCustomer1().ToList();
        }
        public ABANKCustomer1 GetCustomer1ById(int id)
        {
            return repository.GetCustomer1ById(id);
        }
        public ABANKCustomer1 PostCustomer1(ABANKCustomer1 customer1)
        {
            return repository.PostCustomer1(customer1);
        }
        public ABANKCustomer1 PutCustomer1(ABANKCustomer1 customer1)
        {
            return repository.PutCustomer1(customer1);
        }
        public void DeleteCustomer1(int id)
        {
           repository.DeleteCustomer1(id);
        }


    }
}
