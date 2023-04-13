using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.DataAccess.Concrete.BBANK;
using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.Business.Concrete.BBANK
{
    public class BBANKCustomer1Account1ActivitiesService : BBANKICustomer1Account1ActivitiesService
    {
        private BBANKCustomer1Account1ActivitiesRepository activitiesRepository = new BBANKCustomer1Account1ActivitiesRepository();
        public BBANKCustomer1Account1Activities Customer1Account1ActivitiesById(int id)
        {
            return activitiesRepository.Customer1Account1ActivitiesById(id);
        }
        public List<BBANKCustomer1Account1Activities> GetAllCustomer1Account1Activities()
        {
            return activitiesRepository.GetAllCustomer1Account1Activities();
        }
    }
}
