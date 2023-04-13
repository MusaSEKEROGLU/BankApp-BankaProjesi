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
    public class BBANKCustomer2Account2DetailsController : ControllerBase
    {
        BBANKCustomer2Account customer2 = new BBANKCustomer2Account();
        private BBANKICustomer2Account2DetailsService customer2Account2DetailsSAervice;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer2Account2DetailsController(BBANKICustomer2Account2DetailsService customer2Account2DetailsSAervice, IDataProtectionProvider provider)
        {
            this.customer2Account2DetailsSAervice = customer2Account2DetailsSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer2Account2Details()
        {
            var customer1Account2 = Customer2Account2Details();
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
        public IActionResult GetUnprotectCustomer2Account2Details(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer2Account2 = Customer2Account2Details();
            var ca1 = customer2Account2.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer2Account2);
        }
        private List<BBANKCustomer2Account2Details> Customer2Account2Details()
        {
            var customer2Account2 = new List<BBANKCustomer2Account2Details>();
            customer2Account2.Add(new BBANKCustomer2Account2Details()
            {
                Id = 2,
                HesapAdi = "HalkbankVadesizTL",
                HesapNo = "2204114308",
                IbanNo = "TR880008200190032204114308",
                HesapBakiye = 10000,
                SubeAdi = "HALKBANK/ANKARA/KEÇİÖREN",
                GünlükTransferLimiti = 2500,
                HesapAktifMi = true,
                SubeKodu = 2020,
                MusteriNo = "90807060",


            });
            return customer2Account2;
        }
        [HttpGet("GetAllCustomer2Account2Details")]
        public List<BBANKCustomer2Account2Details> GetAllCustomer2Account2Details()
        {
            return customer2Account2DetailsSAervice.GetAllCustomer2Account2Details().ToList(); ;
        }
        [HttpGet("{id}")]
        public BBANKCustomer2Account2Details GetCustomer1Account2DetailsById(int id)
        {
            return customer2Account2DetailsSAervice.GetCustomer2Account2DetailsById(id);
        }
        [HttpPost]
        public BBANKCustomer2Account2Details PostCustomer2Account2Details(BBANKCustomer2Account2Details bBANKCustomer2Account2Details)
        {
            return customer2Account2DetailsSAervice.PostCustomer2Account2Details(bBANKCustomer2Account2Details);
        }
        [HttpPut]
        public BBANKCustomer2Account2Details PutCustomer2Account2Details(BBANKCustomer2Account2Details bBANKCustomer2Account2Details)
        {
            return customer2Account2DetailsSAervice.PutCustomer2Account2Details(bBANKCustomer2Account2Details);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer2Account2Details(int id)
        {
            customer2Account2DetailsSAervice.DeleteCustomer2Account2Details(id);
        }
    }
}
