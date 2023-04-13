using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract.ABANK
{
    public interface ABANKICustomer1Account2DetailsService
    {
        List<ABANKCustomer1Account2Details> GetAllCustomer1Account2Details();
        ABANKCustomer1Account2Details GetCustomer1Account2DetailsById(int id);
        ABANKCustomer1Account2Details PostCustomer1Account2Details(ABANKCustomer1Account2Details aBANKCustomer1Account2Details);
        ABANKCustomer1Account2Details PutCustomer1Account2Details(ABANKCustomer1Account2Details aBANKCustomer1Account2Details);
        void DeleteCustomer1Account2Details(int id);

    }
}
