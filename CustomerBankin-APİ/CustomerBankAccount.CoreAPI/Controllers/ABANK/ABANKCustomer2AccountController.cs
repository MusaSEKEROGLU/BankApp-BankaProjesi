using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.DataAccess;
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
    public class ABANKCustomer2AccountController : ControllerBase
    {
        private ABANKICustomer2AccountService customer2AccountSAervice;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer2AccountController(ABANKICustomer2AccountService customer2AccountSAervice, IDataProtectionProvider provider)
        {
            this.customer2AccountSAervice = customer2AccountSAervice;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }

        [HttpGet("Protect")]
        public IActionResult GetCustomer2Account()
        {
            var customer2Account = Customer2Account();
            var outPut = customer2Account.Select(x => new
            {
                Id = dataProtector.Protect(x.Id.ToString()),
                MusteriNo = dataProtector.Protect(x.MusteriNo.ToString()),
                HesapNo = dataProtector.Protect(x.HesapNo.ToString()),
                HesapAdi = dataProtector.Protect(x.HesapAdi.ToString()),
                IbanNo = dataProtector.Protect(x.IbanNo.ToString()),
                SubeAdi = dataProtector.Protect(x.SubeAdi.ToString()),
                SubeKodu = dataProtector.Protect(x.SubeKodu.ToString()),
                HesapBakiye = dataProtector.Protect(x.HesapBakiye.ToString()),
                AktifMi = dataProtector.Protect(x.HesapAktifMi.ToString()),
                GünlükTransferLimiti = dataProtector.Protect(x.GünlükTransferLimiti.ToString()),

                //Customer1 = dataProtector.Protect(x.Customer1.ToString()),
                //Customer1AccountActivities = dataProtector.Protect(x.Customer1AccountActivities.ToString()),

            });
            return Ok(outPut);
        }
        [HttpGet("HesapNo")]
        public IActionResult GetUnprotectCustomer2Account(string HesapNo)
        {
            var OriginalMN = dataProtector.Unprotect(HesapNo);
            var customer2Account = Customer2Account();
            var ca1 = customer2Account.Where(x => x.HesapNo == OriginalMN).First();
            return Ok(customer2Account);
        }
        private List<ABANKCustomer2Account> Customer2Account()
        {
            var customer2Account = new List<ABANKCustomer2Account>();
            customer2Account.Add(new ABANKCustomer2Account()
            {
                Id = 1,
                MusteriNo = "00001111",
                HesapNo = "1101177000",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101177000",
                SubeAdi = "DENİZBANK/ANKARA/KEÇİÖREN",
                HesapBakiye = 10000,
                SubeKodu = 2121,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            });
            customer2Account.Add(new ABANKCustomer2Account()
            {
                Id = 2,
                MusteriNo = "00001111",
                HesapNo = "1101166111",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101166111",
                SubeAdi = "DENİZBANK/ANKARA/KEÇİÖREN",
                HesapBakiye = 10000,
                SubeKodu = 2121,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,

            });
            return customer2Account;
        }
        [HttpGet("ABANKGetAllCustomer2Account")]
        public List<ABANKCustomer2Account> GetAllCustomer2Account()
        {
            return customer2AccountSAervice.GetAllCustomer2Account().ToList();
        }
        [HttpGet("{id}")]
        public ABANKCustomer2Account GetCustomer2AccountById(int id)
        {
            return customer2AccountSAervice.GetCustomer2AccountById(id);
        }
        [HttpPost]
        public ABANKCustomer2Account PostCustomer2Account(ABANKCustomer2Account customer2Account)
        {
            return customer2AccountSAervice.PostCustomer2Account(customer2Account);
        }
        [HttpPut]
        public ABANKCustomer2Account PutCustomer2Account(ABANKCustomer2Account customer2Account)
        {
            return customer2AccountSAervice.PutCustomer2Account( customer2Account);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer2Account(int id)
        {
             customer2AccountSAervice.DeleteCustomer2Account(id);
        }
    }
}
