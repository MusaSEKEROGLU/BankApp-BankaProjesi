using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Concrete.ABANK
{
    public class ABANKCustomer2Account1DetailsService : ABANKICustomer2Account1DetailsService
    {
        private ABANKCustomer2Account1DetailsRepository deatailsRepository = new ABANKCustomer2Account1DetailsRepository();

        public void DeleteCustomer2Account1Details(int id)
        {
            deatailsRepository.DeleteCustomer2Account1Details(id);
        }
        public List<ABANKCustomer2Account1Details> GetAllCustomer2Account1Details()
        {
            return deatailsRepository.GetAllCustomer2AccountDetails().ToList();
        }       
        public ABANKCustomer2Account1Details GetCustomer2Account1DetailsById(int id)
        {
            return deatailsRepository.GetCustomer2Account1DetailsById(id);
        }
        public ABANKCustomer2Account1Details PostCustomer2Account1Details(ABANKCustomer2Account1Details aBANKCustomer2Account1Details)
        {
            return deatailsRepository.PostCustomer2Account1Details(aBANKCustomer2Account1Details);
        }
        public ABANKCustomer2Account1Details PutCustomer2Account1Details(ABANKCustomer2Account1Details aBANKCustomer2Account1Details)
        {
            return deatailsRepository.PutCustomer2Account1Details(aBANKCustomer2Account1Details);
        }
    }
}
