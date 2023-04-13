using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract.ABANK
{
    public interface ABANKICustomer2Account1ActivitiesService
    {
        List<ABANKCustomer2Account1Activities> GetAllCustomer2Account1Activities();
        ABANKCustomer2Account1Activities Customer2Account1ActivitiesById(int id);
    }
}
