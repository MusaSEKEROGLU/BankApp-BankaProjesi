using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.BBANK
{
    public interface BBANKICustomer2Account1DetailsRepository
    {
        List<BBANKCustomer2Account1Details> GetAllCustomer2Account1Details();
        BBANKCustomer2Account1Details GetCustomer2Account1DetailsById(int id);
        BBANKCustomer2Account1Details PostCustomer2Account1Details(BBANKCustomer2Account1Details bBANKCustomer2Account1Details);
        BBANKCustomer2Account1Details PutCustomer2Account1Details(BBANKCustomer2Account1Details bBANKCustomer2Account1Details);
        void DeleteCustomer2Account1Details(int id);
    }
}
