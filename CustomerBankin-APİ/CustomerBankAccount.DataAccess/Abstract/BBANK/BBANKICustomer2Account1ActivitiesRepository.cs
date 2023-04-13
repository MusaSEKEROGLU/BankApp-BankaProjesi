using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Abstract.BBANK
{
    public interface BBANKICustomer2Account1ActivitiesRepository
    {
        List<BBANKCustomer2Account1Activities> GetAllCustomer2Account1Activities();
        BBANKCustomer2Account1Activities Customer2Account1ActivitiesById(int id);
    }
}
