using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.DataAccess.Concrete.BBANK;
using CustomerBankAccount.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.Business.Concrete.BBANK
{
    public class BBANKCustomer2Account1ActivitiesService : BBANKICustomer2Account1ActivitiesService
    {
        private BBANKCustomer2Account1ActivitiesRepository activitiesRepository = new BBANKCustomer2Account1ActivitiesRepository();
        public BBANKCustomer2Account1Activities Customer2Account1ActivitiesById(int id)
        {
            return activitiesRepository.Customer2Account1ActivitiesById(id);
        }
        public List<BBANKCustomer2Account1Activities> GetAllCustomer2Account1Activities()
        {
            return activitiesRepository.GetAllCustomer2Account1Activities();
        }
    }
}
