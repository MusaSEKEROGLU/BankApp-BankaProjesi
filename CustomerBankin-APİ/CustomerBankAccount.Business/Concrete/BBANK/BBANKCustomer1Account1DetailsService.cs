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
    public class BBANKCustomer1Account1DetailsService : BBANKICustomer1Account1DetailsService
    {
        private BBANKCustomer1Account1DetailsRepository deatailsRepository = new BBANKCustomer1Account1DetailsRepository();

        public void DeleteCustomer1Account1Details(int id)
        {
            deatailsRepository.DeleteCustomer1Account1Details(id);
        }
        public List<BBANKCustomer1Account1Details> GetAllCustomer1Account1Details()
        {
            return deatailsRepository.GetAllCustomer1Account1Details().ToList();
        }
        public BBANKCustomer1Account1Details GetCustomer1Account1DetailsById(int id)
        {
            return deatailsRepository.GetCustomer1Account1DetailsById(id);
        }
        public BBANKCustomer1Account1Details PostCustomer1Account1Details(BBANKCustomer1Account1Details bBANKCustomer1Account1Details)
        {
            return deatailsRepository.PostCustomer1Account1Details(bBANKCustomer1Account1Details);
        }
        public BBANKCustomer1Account1Details PutCustomer1Account1Details(BBANKCustomer1Account1Details bBANKCustomer1Account1Details)
        {
            return deatailsRepository.PutCustomer1Account1Details(bBANKCustomer1Account1Details);
        }
    }
}
