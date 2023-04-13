using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.Business.Concrete.ABANK
{
    public class ABANKCustomer1Account1ActivitiesService : ABANKICustomer1Account1ActivitiesService
    {
        private ABANKCustomer1Account1ActivitiesRepository activitiesRepository = new ABANKCustomer1Account1ActivitiesRepository();
        public ABANKCustomer1Account1Activities Customer1Account1ActivitiesById(int id)
        {
            return activitiesRepository.Customer1Account1ActivitiesById(id);
        }
        public List<ABANKCustomer1Account1Activities> GetAllCustomer1Account1Activities()
        {
            return activitiesRepository.GetAllCustomer1Account1Activities();
        }
    }
}
