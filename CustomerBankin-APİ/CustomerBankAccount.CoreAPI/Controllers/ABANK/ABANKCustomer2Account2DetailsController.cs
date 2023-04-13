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
    public class ABANKCustomer2Account2DetailsController : ControllerBase
    {
        ABANKCustomer2Account customer2 = new ABANKCustomer2Account();
        private ABANKICustomer2Account2DetailsService customer2Account2DetailsSAervice;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer2Account2DetailsController(ABANKICustomer2Account2DetailsService customer2Account2DetailsSAervice, IDataProtectionProvider provider)
        {
            this.customer2Account2DetailsSAervice = customer2Account2DetailsSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer2Account2Details()
        {
            var customer2Account2Details = Customer2Account2Details();
            var outPut = customer2Account2Details.Select(x => new
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
            var customer2Account2Details = Customer2Account2Details();
            var ca1 = customer2Account2Details.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer2Account2Details);
        }
        private List<ABANKCustomer2Account2Details> Customer2Account2Details()
        {
            var customer2Account = new List<ABANKCustomer2Account2Details>();
            customer2Account.Add(new ABANKCustomer2Account2Details()
            {
                Id = 2,
                HesapAdi = "DenizbankVadesizTL",
                HesapNo = "1101166111",
                IbanNo = "TR670001200190031101166111",
                HesapBakiye = 10000,
                SubeAdi = "DENİZBANK/ANKARA/KEÇİÖREN",
                MusteriNo = "00001111",
                HesapAktifMi = true,
                SubeKodu = 2121,
                GünlükTransferLimiti = 2500,
            });
            return customer2Account;
        }
        [HttpGet("ABANKGetAllCustomer2Account2Details")]
        public List<ABANKCustomer2Account2Details> GetAllCustomer2Account2Details()
        {
            return customer2Account2DetailsSAervice.GetAllCustomer2Account2Details().ToList(); ;
        }
        [HttpGet("{id}")]
        public ABANKCustomer2Account2Details GetCustomer2Account2DetailsById(int id)
        {
            return customer2Account2DetailsSAervice.GetCustomer2Account2DetailsById(id);
        }
        [HttpPost]
        public ABANKCustomer2Account2Details PostCustomer2Account2Details(ABANKCustomer2Account2Details aBANKCustomer2Account2Details)
        {
            return customer2Account2DetailsSAervice.PostCustomer2Account2Details(aBANKCustomer2Account2Details);
        }
        [HttpPut]
        public ABANKCustomer2Account2Details PutCustomer2Account2Details(ABANKCustomer2Account2Details aBANKCustomer2Account2Details)
        {
            return customer2Account2DetailsSAervice.PutCustomer2Account2Details(aBANKCustomer2Account2Details);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer2Account2Details(int id)
        {
            customer2Account2DetailsSAervice.DeleteCustomer2Account2Details(id);
        }
    }
}
