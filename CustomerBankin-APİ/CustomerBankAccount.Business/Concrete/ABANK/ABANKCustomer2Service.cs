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
    public class ABANKCustomer2Service : ABANKICustomer2Service
    {
        private ABANKCustomer2Repository repository = new ABANKCustomer2Repository();
        public List<ABANKCustomer2> GetAllCustomer2()
        {
            return repository.GetAllCustomer2().ToList();
        }
        public ABANKCustomer2 GetCustomer2ById(int id)
        {
            return repository.GetCustomer2ById(id);
        }
        public ABANKCustomer2 PostCustomer2(ABANKCustomer2 customer2)
        {
            return repository.PostCustomer2(customer2);
        }
        public ABANKCustomer2 PutCustomer2(ABANKCustomer2 customer2)
        {
            return repository.PutCustomer2(customer2);
        }
        public void DeleteCustomer2(int id)
        {
             repository.DeleteCustomer2(id);
        }


    }
}
