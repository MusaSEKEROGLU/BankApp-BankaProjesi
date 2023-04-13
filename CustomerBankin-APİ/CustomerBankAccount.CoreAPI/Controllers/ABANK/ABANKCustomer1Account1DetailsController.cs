using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.CoreAPI.Controllers.ABANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ABANKCustomer1Account1DetailsController : ControllerBase
    {
        private ABANKICustomer1Account1DetailsService customer1AccountDetailsSAervice;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer1Account1DetailsController(ABANKICustomer1Account1DetailsService customer1AccountDetailsSAervice, IDataProtectionProvider provider)
        {
            this.customer1AccountDetailsSAervice = customer1AccountDetailsSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer1Account1Details()
        {
            var customer1Account = Customer1Account1Details();
            var outPut = customer1Account.Select(x => new
            {
                Id = dataProtector.Protect(x.Id.ToString()),
                HesapNo = dataProtector.Protect(x.HesapNo.ToString()),
                HesapAdi = dataProtector.Protect(x.HesapAdi.ToString()),
                IbanNo = dataProtector.Protect(x.IbanNo.ToString()),
                SubeAdi = dataProtector.Protect(x.SubeAdi.ToString()),
                HesapBakiye = dataProtector.Protect(x.HesapBakiye.ToString()),
                HesapAktifMi = dataProtector.Protect(x.HesapAktifMi.ToString()),
                SubeKodu = dataProtector.Protect(x.SubeKodu.ToString()),
                GünlükTransferLimiti = dataProtector.Protect(x.GünlükTransferLimiti.ToString()),
                MusteriNo = dataProtector.Protect(x.MusteriNo.ToString()),

            });
            return Ok(outPut);
        }
        [HttpGet("HesapNo")]
        public IActionResult GetUnprotectCustomer1Account1Details(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer1Account = Customer1Account1Details();
            var ca1 = customer1Account.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer1Account);
        }
        private List<ABANKCustomer1Account> Customer1Account1Details()
        {
            var customer1Account = new List<ABANKCustomer1Account>();
            customer1Account.Add(new ABANKCustomer1Account()
            {
                Id = 1,
                HesapNo = "1101177809",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101177809",
                SubeAdi = "DENİZBANK",
                HesapBakiye = 10000,
                HesapAktifMi = true,
                SubeKodu = 1010,
                GünlükTransferLimiti = 2500,
                MusteriNo = "10203040",

            });
            return customer1Account;
        }
        [HttpGet("GetAllCustomer1Account1Details")]
        public List<ABANKCustomer1Account1Details> GetAllCustomer1Account1Details()
        {
            return customer1AccountDetailsSAervice.GetAllCustomer1Account1Details().ToList(); 
        }
        [HttpGet("{id}")]
        public ABANKCustomer1Account1Details GetCustomer1Account1DetailsById(int id)
        {
            return customer1AccountDetailsSAervice.GetCustomer1Account1DetailsById(id);
        }

        [HttpPost]
        public ABANKCustomer1Account1Details PostCustomer1Account1Details(ABANKCustomer1Account1Details aBANKCustomer1Account1Details)
        {
            return customer1AccountDetailsSAervice.PostCustomer1Account1Details(aBANKCustomer1Account1Details);
        }
        [HttpPut]
        public ABANKCustomer1Account1Details PutCustomer1Account1Details(ABANKCustomer1Account1Details aBANKCustomer1Account1Details)
        {
            return customer1AccountDetailsSAervice.PutCustomer1Account1Details(aBANKCustomer1Account1Details);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer1Account1Details(int id)
        {
            customer1AccountDetailsSAervice.DeleteCustomer1Account1Details(id);
        }
    }
}
