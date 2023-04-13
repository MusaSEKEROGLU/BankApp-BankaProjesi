using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer2Account2DetailsRepository
    {
        List<ABANKCustomer2Account2Details> GetAllCustomer2Account2Details();
        ABANKCustomer2Account2Details GetCustomer2Account2DetailsById(int id);
        ABANKCustomer2Account2Details PostCustomer2Account2Details(ABANKCustomer2Account2Details aBANKCustomer2Account2Details);
        ABANKCustomer2Account2Details PutCustomer2Account2Details(ABANKCustomer2Account2Details aBANKCustomer2Account2Details);
        void DeleteCustomer2Account2Details(int id);
    }
}
