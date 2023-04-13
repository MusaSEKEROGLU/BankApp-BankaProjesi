using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.DataAccess.Concrete.BBANK;
using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.Business.Concrete.BBANK
{
    public class BBANKCustomer1Account2ActivitiesService : BBANKICustomer1Account2ActivitiesService
    {
        private BBANKCustomer1Account2ActivitiesRepository activitiesRepository = new BBANKCustomer1Account2ActivitiesRepository();
        public BBANKCustomer1Account2Activities Customer1Account2ActivitiesById(int id)
        {
            return activitiesRepository.Customer1Account2ActivitiesById(id);
        }
        public List<BBANKCustomer1Account2Activities> GetAllCustomer1Account2Activities()
        {
            return activitiesRepository.GetAllCustomer1Account2Activities();
        }
    }
}
