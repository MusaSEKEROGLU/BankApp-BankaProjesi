using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.Business.Concrete.ABANK
{
    public class ABANKCustomer1Account2ActivitiesService : ABANKICustomer1Account2ActivitiesService
    {
        private ABANKCustomer1Account2ActivitiesRepository activitiesRepository = new ABANKCustomer1Account2ActivitiesRepository();
        public ABANKCustomer1Account2Activities Customer1Account2ActivitiesById(int id)
        {
            return activitiesRepository.Customer1Account2ActivitiesById(id);
        }
        public List<ABANKCustomer1Account2Activities> GetAllCustomer1Account2Activities()
        {
            return activitiesRepository.GetAllCustomer1Account2Activities();
        }
    }
}
