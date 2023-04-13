using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer1Account2ActivitiesRepository
    {
        List<ABANKCustomer1Account2Activities> GetAllCustomer1Account2Activities();
        ABANKCustomer1Account2Activities Customer1Account2ActivitiesById(int id);
    }
}
