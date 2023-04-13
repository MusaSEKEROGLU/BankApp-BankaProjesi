using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.Business.Concrete.ABANK
{
    public class ABANKCustomer2Account1ActivitiesService : ABANKICustomer2Account1ActivitiesService
    {
        private ABANKCustomer2Account1ActivitiesRepository activitiesRepository = new ABANKCustomer2Account1ActivitiesRepository();
        public ABANKCustomer2Account1Activities Customer2Account1ActivitiesById(int id)
        {
            return activitiesRepository.Customer2Account1ActivitiesById(id);
        }
        public List<ABANKCustomer2Account1Activities> GetAllCustomer2Account1Activities()
        {
            return activitiesRepository.GetAllCustomer2Account1Activities();
        }
    }
}
