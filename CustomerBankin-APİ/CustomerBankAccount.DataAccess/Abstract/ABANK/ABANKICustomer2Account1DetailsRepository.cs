using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer2Account1DetailsRepository
    {
        List<ABANKCustomer2Account1Details> GetAllCustomer2AccountDetails();
        ABANKCustomer2Account1Details GetCustomer2Account1DetailsById(int id);
        ABANKCustomer2Account1Details PostCustomer2Account1Details(ABANKCustomer2Account1Details aBANKCustomer2Account1Details);
        ABANKCustomer2Account1Details PutCustomer2Account1Details(ABANKCustomer2Account1Details aBANKCustomer2Account1Details);
        void DeleteCustomer2Account1Details(int id);
    }
}
