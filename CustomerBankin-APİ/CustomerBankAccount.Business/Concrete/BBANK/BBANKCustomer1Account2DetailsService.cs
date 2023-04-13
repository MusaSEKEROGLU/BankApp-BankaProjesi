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
    public class BBANKCustomer1Account2DetailsService : BBANKICustomer1Account2DetailsService
    {
        private BBANKCustomer1Account2DetailsRepository deatailsRepository = new BBANKCustomer1Account2DetailsRepository();

        public void DeleteCustomer1Account2Details(int id)
        {
            deatailsRepository.DeleteCustomer1Account2Details(id);
        }
        public List<BBANKCustomer1Account2Details> GetAllCustomer1Account2Details()
        {
            return deatailsRepository.GetAllCustomer1Account2Details().ToList();
        }
        public BBANKCustomer1Account2Details GetCustomer1Account2DetailsById(int id)
        {
            return deatailsRepository.GetCustomer1Account2DetailsById(id);
        }
        public BBANKCustomer1Account2Details PostCustomer1Account2Details(BBANKCustomer1Account2Details bBANKCustomer1Account2Details)
        {
            return deatailsRepository.PostCustomer1Account2Details(bBANKCustomer1Account2Details);
        }
        public BBANKCustomer1Account2Details PutCustomer1Account2Details(BBANKCustomer1Account2Details bBANKCustomer1Account2Details)
        {
            return deatailsRepository.PutCustomer1Account2Details(bBANKCustomer1Account2Details);
        }
    }
}
