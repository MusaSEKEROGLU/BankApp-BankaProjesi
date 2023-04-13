using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract.ABANK
{
    public interface ABANKICustomer2Account2ActivitiesService
    {
        List<ABANKCustomer2Account2Activities> GetAllCustomer2Account2Activities();
        ABANKCustomer2Account2Activities Customer2Account2ActivitiesById(int id);
    }
}
