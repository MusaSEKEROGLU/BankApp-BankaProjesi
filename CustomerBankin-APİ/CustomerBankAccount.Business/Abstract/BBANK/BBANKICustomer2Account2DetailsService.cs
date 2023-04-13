using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract.BBANK
{
    public interface BBANKICustomer2Account2DetailsService
    {
        List<BBANKCustomer2Account2Details> GetAllCustomer2Account2Details();
        BBANKCustomer2Account2Details GetCustomer2Account2DetailsById(int id);
        BBANKCustomer2Account2Details PostCustomer2Account2Details(BBANKCustomer2Account2Details bBANKCustomer2Account2Details);
        BBANKCustomer2Account2Details PutCustomer2Account2Details(BBANKCustomer2Account2Details bBANKCustomer2Account2Details);
        void DeleteCustomer2Account2Details(int id);

    }
}
