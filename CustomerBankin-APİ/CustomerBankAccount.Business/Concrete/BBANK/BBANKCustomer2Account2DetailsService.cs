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
    public class BBANKCustomer2Account2DetailsService : BBANKICustomer2Account2DetailsService
    {
        private BBANKCustomer2Account2DetailsRepository deatailsRepository = new BBANKCustomer2Account2DetailsRepository();

        public void DeleteCustomer2Account2Details(int id)
        {
            deatailsRepository.DeleteCustomer2Account2Details(id);
        }
        public List<BBANKCustomer2Account2Details> GetAllCustomer2Account2Details()
        {
            return deatailsRepository.GetAllCustomer2Account2Details().ToList();
        }
        public BBANKCustomer2Account2Details GetCustomer2Account2DetailsById(int id)
        {
            return deatailsRepository.GetCustomer2Account2DetailsById(id);
        }
        public BBANKCustomer2Account2Details PostCustomer2Account2Details(BBANKCustomer2Account2Details bBANKCustomer2Account2Details)
        {
            return deatailsRepository.PostCustomer2Account2Details(bBANKCustomer2Account2Details);
        }
        public BBANKCustomer2Account2Details PutCustomer2Account2Details(BBANKCustomer2Account2Details bBANKCustomer2Account2Details)
        {
            return deatailsRepository.PutCustomer2Account2Details(bBANKCustomer2Account2Details);
        }
    }
}
