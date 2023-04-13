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
    public class ABANKCustomer2Account2DetailsService : ABANKICustomer2Account2DetailsService
    {
        private ABANKCustomer2Account2DetailsRepository deatailsRepository = new ABANKCustomer2Account2DetailsRepository();
        public void DeleteCustomer2Account2Details(int id)
        {
            deatailsRepository.DeleteCustomer2Account2Details(id);
        }
        public List<ABANKCustomer2Account2Details> GetAllCustomer2Account2Details()
        {
            return deatailsRepository.GetAllCustomer2Account2Details().ToList();
        }
        public ABANKCustomer2Account2Details GetCustomer2Account2DetailsById(int id)
        {
            return deatailsRepository.GetCustomer2Account2DetailsById(id);
        }
        public ABANKCustomer2Account2Details PostCustomer2Account2Details(ABANKCustomer2Account2Details aBANKCustomer2Account2Details)
        {
            return deatailsRepository.PostCustomer2Account2Details(aBANKCustomer2Account2Details);
        }
        public ABANKCustomer2Account2Details PutCustomer2Account2Details(ABANKCustomer2Account2Details aBANKCustomer2Account2Details)
        {
            return deatailsRepository.PutCustomer2Account2Details(aBANKCustomer2Account2Details);
        }
    }
}
