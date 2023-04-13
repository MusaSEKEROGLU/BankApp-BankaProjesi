using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBankAccount.CoreAPI.Controllers.BBANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class BBANKCustomer2Account1DetailsController : ControllerBase
    {
        BBANKCustomer2Account customer2 = new BBANKCustomer2Account();
        private BBANKICustomer2Account1DetailsService customer2AccountDetailsSAervice;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer2Account1DetailsController(BBANKICustomer2Account1DetailsService customer2AccountDetailsSAervice, IDataProtectionProvider provider)
        {
            this.customer2AccountDetailsSAervice = customer2AccountDetailsSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer2Account1Details()
        {
            var customer1Account = Customer2Account1Details();
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
        public IActionResult GetUnprotectCustomer2Account1Details(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer2Account = Customer2Account1Details();
            var ca1 = customer2Account.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer2Account);
        }
        private List<BBANKCustomer2Account1Details> Customer2Account1Details()
        {
            var customer2Account = new List<BBANKCustomer2Account1Details>();
            customer2Account.Add(new BBANKCustomer2Account1Details()
            {
                Id = 1,
                HesapNo = "2204881106",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204881106",
                SubeAdi = "HALKBANK/ANKARA/KEÇİÖREN",
                HesapBakiye = 10000,
                MusteriNo = "90807060",
                HesapAktifMi = true,
                SubeKodu = 1010,
                GünlükTransferLimiti = 2500,


            });
            return customer2Account;
        }
        [HttpGet("BBANKGetAllCustomer2Account1Details")]
        public List<BBANKCustomer2Account1Details> GetAllCustomer2Account1Details()
        {
            return customer2AccountDetailsSAervice.GetAllCustomer2Account1Details(); 
        }
        [HttpGet("{id}")]
        public BBANKCustomer2Account1Details GetCustomer1Account1DetailsById(int id)
        {
            return customer2AccountDetailsSAervice.GetCustomer2Account1DetailsById(id);
        }
        [HttpPost]
        public BBANKCustomer2Account1Details PostCustomer2Account1Details(BBANKCustomer2Account1Details bBANKCustomer2Account1Details)
        {
            return customer2AccountDetailsSAervice.PostCustomer2Account1Details(bBANKCustomer2Account1Details);
        }
        [HttpPut]
        public BBANKCustomer2Account1Details PutCustomer2Account1Details(BBANKCustomer2Account1Details bBANKCustomer2Account1Details)
        {
            return customer2AccountDetailsSAervice.PutCustomer2Account1Details(bBANKCustomer2Account1Details);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer2Account1Details(int id)
        {
            customer2AccountDetailsSAervice.DeleteCustomer2Account1Details(id);
        }
    }
}
