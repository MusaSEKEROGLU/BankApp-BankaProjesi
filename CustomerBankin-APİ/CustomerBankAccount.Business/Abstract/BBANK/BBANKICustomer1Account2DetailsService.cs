using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract.BBANK
{
    public interface BBANKICustomer1Account2DetailsService
    {
        List<BBANKCustomer1Account2Details> GetAllCustomer1Account2Details();
        BBANKCustomer1Account2Details GetCustomer1Account2DetailsById(int id);
        BBANKCustomer1Account2Details PostCustomer1Account2Details(BBANKCustomer1Account2Details bBANKCustomer1Account2Details);
        BBANKCustomer1Account2Details PutCustomer1Account2Details(BBANKCustomer1Account2Details bBANKCustomer1Account2Details);
        void DeleteCustomer1Account2Details(int id);

    }
}
