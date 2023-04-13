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
    public class BBANKCustomer1Controller : ControllerBase
    {
        private BBANKICustomer1Service customer1Service;
        private readonly IDataProtector dataProtector;
        public BBANKCustomer1Controller(BBANKICustomer1Service customer1Service, IDataProtectionProvider provider)
        {
            this.customer1Service = customer1Service;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }
        [HttpGet("Protect")]
        public IActionResult GetProtectCustomer1()
        {
            var customer1 = GetCustomer1();
            var outPut = customer1.Select(x => new
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
        public IActionResult GetUnprotectCustomer1(string TCKimlikNo)
        {
            var OriginalTc = dataProtector.Unprotect(TCKimlikNo);
            var customer1 = GetCustomer1();
            var customer = customer1.Where(x => x.TCKimlikNo == OriginalTc).First();
            return Ok(customer1);

        }
        private List<BBANKCustomer1> GetCustomer1()
        {
            var customer1 = new List<BBANKCustomer1>();
            customer1.Add(new BBANKCustomer1()
            {
                Id = 2,
                AdiSoyadi = "TAMAY LİNA SEKEROGLU",
                TCKimlikNo = "62800491280",
                MusteriNo = "00002222",
                Adres = "Pursaklar/ANKARA",
                TelefonNo = "05302938227",
                EmailAdres = "ayse_98@gmail.com",
                AktifMi = true
            });
            return customer1;
        }
        [HttpGet("BBANKGetAllCustomer1")]
        public List<BBANKCustomer1> GetAllCustomer1()
        {
            return customer1Service.GetAllCustomer1().ToList();
        }
        [HttpGet("{id}")]
        public BBANKCustomer1 GetCustomer1ById(int id)
        {
            return customer1Service.GetCustomer1ById(id);
        }
        [HttpPost]
        public BBANKCustomer1 PostCustomer1(BBANKCustomer1 customer1)
        {
            return customer1Service.PostCustomer1(customer1);
        }
        [HttpPut]
        public BBANKCustomer1 PutCustomer1(BBANKCustomer1 customer1)
        {
            return customer1Service.PutCustomer1( customer1);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer1(int id)
        {
             customer1Service.DeleteCustomer1(id);
        }

    }
}
