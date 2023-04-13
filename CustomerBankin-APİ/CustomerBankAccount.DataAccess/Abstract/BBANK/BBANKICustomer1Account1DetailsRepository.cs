using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.BBANK
{
    public interface BBANKICustomer1Account1DetailsRepository
    {
        List<BBANKCustomer1Account1Details> GetAllCustomer1Account1Details();
        BBANKCustomer1Account1Details GetCustomer1Account1DetailsById(int id);
        BBANKCustomer1Account1Details PostCustomer1Account1Details(BBANKCustomer1Account1Details bBANKCustomer1Account1Details);
        BBANKCustomer1Account1Details PutCustomer1Account1Details(BBANKCustomer1Account1Details bBANKCustomer1Account1Details);
        void DeleteCustomer1Account1Details(int id);
    }
}
