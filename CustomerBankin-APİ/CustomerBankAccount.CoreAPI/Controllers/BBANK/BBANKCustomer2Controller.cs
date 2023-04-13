using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.CoreAPI.Models;
using CustomerBankAccount.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace CustomerBankAccount.CoreAPI.Controllers.BBANK
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class BBANKCustomer2Controller : ControllerBase
    {
        private BBANKICustomer2Service customer2Service;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer2Controller(BBANKICustomer2Service customer2Service, IDataProtectionProvider provider)
        {
            this.customer2Service = customer2Service;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }
        [HttpGet("Protect")]
        public IActionResult GetProtectCustomer2()
        {
            var customer = GetCustomer2();
            var outPut = customer.Select(x => new
            {
                Id = dataProtector.Protect(x.Id.ToString()),
                AdiSoyadi = dataProtector.Protect(x.AdiSoyadi.ToString()),

                TCKimlikNo = dataProtector.Protect(x.TCKimlikNo.ToString()),
                MusteriNo = dataProtector.Protect(x.MusteriNo.ToString()),
                TelefonNo = dataProtector.Protect(x.TelefonNo.ToString()),
                EmailAdres = dataProtector.Protect(x.EmailAdres.ToString()),

            });
            return Ok(outPut);
        }
        [HttpGet("TCKimlikNo")]
        public IActionResult GetUnprotectCustomer2(string TCKimlikNo)
        {
            var OriginalTc = dataProtector.Unprotect(TCKimlikNo);
            var customer2 = GetCustomer2();
            var customer = customer2.Where(x => x.TCKimlikNo == OriginalTc).First();
            return Ok(customer2);

        }
        private List<BBANKCustomer2> GetCustomer2()
        {
            var customer = new List<BBANKCustomer2>();
            customer.Add(new BBANKCustomer2()
            {
                Id = 2,
                AdiSoyadi = "AYŞE SEKEROGLU",
                TCKimlikNo = "66775304200",
                MusteriNo = "90807060",
                Adres = "Pursaklar/ANKARA",
                TelefonNo = "05302938227",
                EmailAdres = "ayse_98@gmail.com",
                AktifMi = true
            });
            return customer;
        }
        [HttpGet("BBANKGetAllCustomer2")]
        public List<BBANKCustomer2> GetAllCustomer2()
        {
            return customer2Service.GetAllCustomer2().ToList();
        }
        [HttpGet("{id}")]
        public BBANKCustomer2 GetCustomer2ById(int id)
        {
            return customer2Service.GetCustomer2ById(id);
        }
        [HttpPost]
        public BBANKCustomer2 PostCustomer2(BBANKCustomer2 customer2)
        {
            return customer2Service.PostCustomer2(customer2);
        }
        [HttpPut]
        public BBANKCustomer2 PutCustomer2(BBANKCustomer2 customer2)
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
