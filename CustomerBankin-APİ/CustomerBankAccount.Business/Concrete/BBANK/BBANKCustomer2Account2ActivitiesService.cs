using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.DataAccess.Concrete.BBANK;
using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.Business.Concrete.BBANK
{
    public class BBANKCustomer2Account2ActivitiesService : BBANKICustomer2Account2ActivitiesService
    {
        private BBANKCustomer2Account2ActivitiesRepository activitiesRepository = new BBANKCustomer2Account2ActivitiesRepository();
        public BBANKCustomer2Account2Activities Customer2Account2ActivitiesById(int id)
        {
            return activitiesRepository.Customer2Account2ActivitiesById(id);
        }
        public List<BBANKCustomer2Account2Activities> GetAllCustomer2Account2Activities()
        {
            return activitiesRepository.GetAllCustomer2Account2Activities();
        }
    }
}
