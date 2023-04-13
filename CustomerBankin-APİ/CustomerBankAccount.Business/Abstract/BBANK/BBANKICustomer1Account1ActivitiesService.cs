using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Abstract.BBANK
{
    public interface BBANKICustomer1Account1ActivitiesService
    {
        List<BBANKCustomer1Account1Activities> GetAllCustomer1Account1Activities();
        BBANKCustomer1Account1Activities Customer1Account1ActivitiesById(int id);
    }
}
