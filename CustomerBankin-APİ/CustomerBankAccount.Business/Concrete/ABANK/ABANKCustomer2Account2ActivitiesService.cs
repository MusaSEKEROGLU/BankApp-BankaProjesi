using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.Business.Concrete.ABANK
{
    public class ABANKCustomer2Account2ActivitiesService : ABANKICustomer2Account2ActivitiesService
    {
        private ABANKCustomer2Account2ActivitiesRepository activitiesRepository = new ABANKCustomer2Account2ActivitiesRepository();
        public ABANKCustomer2Account2Activities Customer2Account2ActivitiesById(int id)
        {
            return activitiesRepository.Customer2Account2ActivitiesById(id);
        }
        public List<ABANKCustomer2Account2Activities> GetAllCustomer2Account2Activities()
        {
            return activitiesRepository.GetAllCustomer2Account2Activities();
        }
    }
}
