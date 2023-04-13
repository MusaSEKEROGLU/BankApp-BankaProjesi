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
    public class ABANKCustomer1Account2DetailsService : ABANKICustomer1Account2DetailsService
    {
        private ABANKCustomer1Account2DetailsRepository deatailsRepository = new ABANKCustomer1Account2DetailsRepository();

        public void DeleteCustomer1Account2Details(int id)
        {
            deatailsRepository.DeleteCustomer1Account2Details(id);
        }
        public List<ABANKCustomer1Account2Details> GetAllCustomer1Account2Details()
        {
            return deatailsRepository.GetAllCustomer1Account2Details().ToList();
        }
        public ABANKCustomer1Account2Details GetCustomer1Account2DetailsById(int id)
        {
            return deatailsRepository.GetCustomer1Account2DetailsById(id);
        }
        public ABANKCustomer1Account2Details PostCustomer1Account2Details(ABANKCustomer1Account2Details aBANKCustomer1Account2Details)
        {
            return deatailsRepository.PostCustomer1Account2Details(aBANKCustomer1Account2Details);
        }

        public ABANKCustomer1Account2Details PutCustomer1Account2Details(ABANKCustomer1Account2Details aBANKCustomer1Account2Details)
        {
            return deatailsRepository.PutCustomer1Account2Details(aBANKCustomer1Account2Details);
        }
    }
}
