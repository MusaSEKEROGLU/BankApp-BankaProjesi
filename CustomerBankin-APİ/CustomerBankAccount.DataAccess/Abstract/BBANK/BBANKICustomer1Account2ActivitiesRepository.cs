using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.BBANK
{
    public interface BBANKICustomer1Account2ActivitiesRepository
    {
        List<BBANKCustomer1Account2Activities> GetAllCustomer1Account2Activities();
        BBANKCustomer1Account2Activities Customer1Account2ActivitiesById(int id);
    }
}
