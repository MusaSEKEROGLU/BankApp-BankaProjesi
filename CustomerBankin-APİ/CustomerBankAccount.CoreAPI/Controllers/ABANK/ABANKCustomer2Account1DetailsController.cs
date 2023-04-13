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
    public class ABANKCustomer2Account1DetailsController : ControllerBase
    {
        private ABANKICustomer2Account1DetailsService customer2Account1DetailsSAervice;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer2Account1DetailsController(ABANKICustomer2Account1DetailsService customer2Account1DetailsSAervice, IDataProtectionProvider provider)
        {
            this.customer2Account1DetailsSAervice = customer2Account1DetailsSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer2Account1Details()
        {
            var customer2Account = Customer2Account1Details();
            var outPut = customer2Account.Select(x => new
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
        private List<ABANKCustomer2Account> Customer2Account1Details()
        {
            var customer2Account = new List<ABANKCustomer2Account>();
            customer2Account.Add(new ABANKCustomer2Account()
            {
                Id = 1,
                HesapNo = "1101177111",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101177111",
                SubeAdi = "DENİZBANK",
                HesapBakiye = 10000,
                HesapAktifMi = true,
                SubeKodu = 2121,
                GünlükTransferLimiti = 2500,
                MusteriNo = "00001111",

            });
            return customer2Account;
        }
        [HttpGet("ABANKGetAllCustomer2Account1Details")]
        public List<ABANKCustomer2Account1Details> GetAllCustomer2Account1Details()
        {
            return customer2Account1DetailsSAervice.GetAllCustomer2Account1Details().ToList(); ;
        }
        [HttpGet("{id}")]
        public ABANKCustomer2Account1Details GetCustomer2Account1DetailsById(int id)
        {
            return customer2Account1DetailsSAervice.GetCustomer2Account1DetailsById(id);
        }
        [HttpPost]
        public ABANKCustomer2Account1Details PostCustomer2Account1Details(ABANKCustomer2Account1Details aBANKCustomer2Account1Details)
        {
            return customer2Account1DetailsSAervice.PostCustomer2Account1Details(aBANKCustomer2Account1Details);
        }
        [HttpPut]
        public ABANKCustomer2Account1Details PutCustomer2Account1Details(ABANKCustomer2Account1Details aBANKCustomer2Account1Details)
        {
            return customer2Account1DetailsSAervice.PutCustomer2Account1Details(aBANKCustomer2Account1Details);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer2Account1Details(int id)
        {
            customer2Account1DetailsSAervice.DeleteCustomer2Account1Details(id);
        }
    }
}
