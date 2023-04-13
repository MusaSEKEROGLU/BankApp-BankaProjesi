using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace CustomerBankAccount.CoreAPI.Controllers.ABANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]

    public class ABANKCustomer2Controller : ControllerBase
    {
        private ABANKICustomer2Service customer2Service;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer2Controller(ABANKICustomer2Service customer2Service, IDataProtectionProvider provider)
        {
            this.customer2Service = customer2Service;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }
        [HttpGet("Protect")]
        public IActionResult GetProtectCustomer2()
        {
            var customer2 = GetCustomer2();
            var outPut = customer2.Select(x => new
            {
                Id = dataProtector.Protect(x.Id.ToString()),
                AdiSoyadi = dataProtector.Protect(x.AdiSoyadi.ToString()),
                TCKimlikNo = dataProtector.Protect(x.TCKimlikNo.ToString()),
                MusteriNo = dataProtector.Protect(x.MusteriNo.ToString()),
                TelefonNo = dataProtector.Protect(x.TelefonNo.ToString()),
                EmailAdres = dataProtector.Protect(x.EmailAdres.ToString()),
                AktifMi = dataProtector.Protect(x.AktifMi.ToString()),

            });
            return Ok(outPut);
        }
        [HttpGet("TCKimlikNo")]
        public IActionResult GetUnprotectCustomer2(string TCKimlikNo)
        {
            var OriginalTc = dataProtector.Unprotect(TCKimlikNo);
            var customer2 = GetCustomer2();
            var c1 = customer2.Where(x => x.TCKimlikNo == OriginalTc).First();
            return Ok(customer2);

        }
        private List<ABANKCustomer2> GetCustomer2()
        {
            var customer2 = new List<ABANKCustomer2>();
            customer2.Add(new ABANKCustomer2()
            {
                Id = 1,
                AdiSoyadi = "ELİF DEREN SEKEROGLU",
                TCKimlikNo = "60601536186",
                MusteriNo = "00001111",
                Adres = "Pursaklar/ANKARA",
                TelefonNo = "05520108651",
                EmailAdres = "drnmaskr2005@gmail.com",
                AktifMi = true,

            });
            return customer2;
        }

        [HttpGet("ABANKGetAllCustomer2")]
        public List<ABANKCustomer2> GetAllCustomer2()
        {
            return customer2Service.GetAllCustomer2().ToList();
        }
        [HttpGet("{id}")]
        public ABANKCustomer2 GetCustomer2ById(int id)
        {
            return customer2Service.GetCustomer2ById(id);
        }

        [HttpPost]
        public ABANKCustomer2 PostCustomer2(ABANKCustomer2 customer2)
        {
            return customer2Service.PostCustomer2(customer2);
        }
        [HttpPut]
        public ABANKCustomer2 PutCustomer2( ABANKCustomer2 customer2)
        {
            return customer2Service.PutCustomer2( customer2);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer2(int id)
        {
             customer2Service.DeleteCustomer2(id);
        }


    }
}
