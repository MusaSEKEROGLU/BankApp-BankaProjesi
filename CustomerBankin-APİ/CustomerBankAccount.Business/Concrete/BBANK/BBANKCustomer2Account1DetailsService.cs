using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.DataAccess.Concrete.BBANK;
using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Business.Concrete.BBANK
{
    public class BBANKCustomer2Account1DetailsService : BBANKICustomer2Account1DetailsService
    {
        private BBANKCustomer2Account1DetailsRepository deatailsRepository = new BBANKCustomer2Account1DetailsRepository();

        public void DeleteCustomer2Account1Details(int id)
        {
            deatailsRepository.DeleteCustomer2Account1Details(id);
        }
        public List<BBANKCustomer2Account1Details> GetAllCustomer2Account1Details()
        {
            return deatailsRepository.GetAllCustomer2Account1Details();
        }
        public BBANKCustomer2Account1Details GetCustomer2Account1DetailsById(int id)
        {
            return deatailsRepository.GetCustomer2Account1DetailsById(id);
        }
        public BBANKCustomer2Account1Details PostCustomer2Account1Details(BBANKCustomer2Account1Details bBANKCustomer2Account1Details)
        {
            return deatailsRepository.PostCustomer2Account1Details(bBANKCustomer2Account1Details);
        }
        public BBANKCustomer2Account1Details PutCustomer2Account1Details(BBANKCustomer2Account1Details bBANKCustomer2Account1Details)
        {
            return deatailsRepository.PutCustomer2Account1Details(bBANKCustomer2Account1Details);
        }
    }
}
