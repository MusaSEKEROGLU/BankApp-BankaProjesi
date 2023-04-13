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
    public class BBANKCustomer1Account2DetailsController : ControllerBase
    {
        BBANKCustomer1Account customer1 = new BBANKCustomer1Account();
        private BBANKICustomer1Account2DetailsService customer1Account2DetailsSAervice;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer1Account2DetailsController(BBANKICustomer1Account2DetailsService customer1Account2DetailsSAervice, IDataProtectionProvider provider)
        {
            this.customer1Account2DetailsSAervice = customer1Account2DetailsSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer1Account2Details()
        {
            var customer1Account2 = Customer1Account2Details();
            var outPut = customer1Account2.Select(x => new
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
        public IActionResult GetUnprotectCustomer1Account2Details(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer1Account2 = Customer1Account2Details();
            var ca1 = customer1Account2.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer1Account2);
        }
        private List<BBANKCustomer1Account2Details> Customer1Account2Details()
        {
            var customer1Account2 = new List<BBANKCustomer1Account2Details>();
            customer1Account2.Add(new BBANKCustomer1Account2Details()
            {
                Id = 2,
                MusteriNo = "00002222",
                HesapNo = "2204114333",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204114333",
                SubeAdi = "HALKBANK/ANKARA/PURSAKALAR",
                HesapBakiye = 10000,
                SubeKodu = 3030,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,

            });
            return customer1Account2;
        }
        [HttpGet("BBANKGetAllCustomer1Account2Details")]
        public List<BBANKCustomer1Account2Details> GetAllCustomer1Account2Details()
        {
            return customer1Account2DetailsSAervice.GetAllCustomer1Account2Details().ToList(); ;
        }
        [HttpGet("{id}")]
        public BBANKCustomer1Account2Details GetCustomer1Account2DetailsById(int id)
        {
            return customer1Account2DetailsSAervice.GetCustomer1Account2DetailsById(id);
        }
        [HttpPost]
        public BBANKCustomer1Account2Details PostCustomer1Account2Details(BBANKCustomer1Account2Details bBANKCustomer1Account2Details)
        {
            return customer1Account2DetailsSAervice.PostCustomer1Account2Details(bBANKCustomer1Account2Details);
        }
        [HttpPut]
        public BBANKCustomer1Account2Details PutCustomer1Account2Details(BBANKCustomer1Account2Details bBANKCustomer1Account2Details)
        {
            return customer1Account2DetailsSAervice.PutCustomer1Account2Details(bBANKCustomer1Account2Details);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer1Account2Details(int id)
        {
            customer1Account2DetailsSAervice.DeleteCustomer1Account2Details(id);
        }
    }
}
