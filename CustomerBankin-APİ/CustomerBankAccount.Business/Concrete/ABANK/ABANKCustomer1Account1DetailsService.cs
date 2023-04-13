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
    public class ABANKCustomer1Account1DetailsService : ABANKICustomer1Account1DetailsService
    {
        private ABANKCustomer1Account1DetailsRepository deatailsRepository = new ABANKCustomer1Account1DetailsRepository();

        public void DeleteCustomer1Account1Details(int id)
        {
            deatailsRepository.DeleteCustomer1Account1Details(id);
        }

        public List<ABANKCustomer1Account1Details> GetAllCustomer1Account1Details()
        {
            return deatailsRepository.GetAllCustomer1AccountDetails().ToList();
        }

        public List<ABANKCustomer1Account1Details> GetAllCustomer1AccountDetails()
        {
            return deatailsRepository.GetAllCustomer1AccountDetails();
        }

        public ABANKCustomer1Account1Details GetCustomer1Account1DetailsById(int id)
        {
            return deatailsRepository.GetCustomer1Account1DetailsById(id);
        }

        public ABANKCustomer1Account1Details PostCustomer1Account1Details(ABANKCustomer1Account1Details aBANKCustomer1Account1Details)
        {
            return deatailsRepository.PostCustomer1Account1Details(aBANKCustomer1Account1Details);
        }

        public ABANKCustomer1Account1Details PutCustomer1Account1Details(ABANKCustomer1Account1Details aBANKCustomer1Account1Details)
        {
            return deatailsRepository.PutCustomer1Account1Details(aBANKCustomer1Account1Details);
        }
    }
}
