using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.ABANK
{
    public interface ABANKICustomer1Account1ActivitiesRepository
    {
        List<ABANKCustomer1Account1Activities> GetAllCustomer1Account1Activities();
        ABANKCustomer1Account1Activities Customer1Account1ActivitiesById(int id);
    }
}
