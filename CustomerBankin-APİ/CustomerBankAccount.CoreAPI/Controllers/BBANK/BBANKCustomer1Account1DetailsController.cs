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
    public class BBANKCustomer1Account1DetailsController : ControllerBase
    {
        BBANKCustomer1Account customer1 = new BBANKCustomer1Account();
        private BBANKICustomer1Account1DetailsService customer1Account1DetailsSAervice;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer1Account1DetailsController(BBANKICustomer1Account1DetailsService customer1Account1DetailsSAervice, IDataProtectionProvider provider)
        {
            this.customer1Account1DetailsSAervice = customer1Account1DetailsSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer1Account1Details()
        {
            var customer1Account1 = Customer1Account1Details();
            var outPut = customer1Account1.Select(x => new
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
            var customer1Account1 = Customer1Account1Details();
            var ca1 = customer1Account1.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer1Account1);
        }
        private List<BBANKCustomer1Account1Details> Customer1Account1Details()
        {
            var customer1Account1 = new List<BBANKCustomer1Account1Details>();
            customer1Account1.Add(new BBANKCustomer1Account1Details()
            {
                Id = 1,
                HesapAdi = "HalkbankVadesizTL",
                HesapNo = "2204881999",
                IbanNo = "TR880008200190032204881999",
                HesapBakiye = 10000,
                SubeAdi = "HALKBANK/ANKARA/PURSAKLAR",
                GünlükTransferLimiti = 2500,
                HesapAktifMi = true,
                SubeKodu = 3030,
                MusteriNo = "00002222",


            });
            return customer1Account1;
        }
        [HttpGet("BBANKGetAllCustomer1Account1Details")]
        public List<BBANKCustomer1Account1Details> GetAllCustomer1Account1Details()
        {
            return customer1Account1DetailsSAervice.GetAllCustomer1Account1Details().ToList(); ;
        }
        [HttpGet("{id}")]
        public BBANKCustomer1Account1Details GetCustomer1Account1DetailsById(int id)
        {
            return customer1Account1DetailsSAervice.GetCustomer1Account1DetailsById(id);
        }
        [HttpPost]
        public BBANKCustomer1Account1Details PostCustomer1Account1Details(BBANKCustomer1Account1Details bBANKCustomer1Account1Details)
        {
            return customer1Account1DetailsSAervice.PostCustomer1Account1Details(bBANKCustomer1Account1Details);
        }
        [HttpPut]
        public BBANKCustomer1Account1Details PutCustomer1Account1Details(BBANKCustomer1Account1Details bBANKCustomer1Account1Details)
        {
            return customer1Account1DetailsSAervice.PutCustomer1Account1Details(bBANKCustomer1Account1Details);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer1Account1Details(int id)
        {
            customer1Account1DetailsSAervice.DeleteCustomer1Account1Details(id);
        }
    }
}
