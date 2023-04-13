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
    public class ABANKCustomer1Controller : ControllerBase
    {
        private ABANKICustomer1Service customer1Service;
        private readonly IDataProtector dataProtector;
        public ABANKCustomer1Controller(ABANKICustomer1Service customer1Service, IDataProtectionProvider provider)
        {
            this.customer1Service = customer1Service;
            dataProtector = provider.CreateProtector("musasekeroglu2005");
        }
        [HttpGet("Protect")]
        public IActionResult GetProtectCustomer1()
        {
            var customer = GetCustomer1();
            var outPut = customer.Select(x => new
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
        public IActionResult GetUnprotectCustomer1(string TCKimlikNo)
        {
            var OriginalTc = dataProtector.Unprotect(TCKimlikNo);
            var customer = GetCustomer1();
            var c1 = customer.Where(x => x.TCKimlikNo == OriginalTc).First();
            return Ok(customer);

        }
        private List<ABANKCustomer1> GetCustomer1()
        {
            var customer = new List<ABANKCustomer1>();
            customer.Add(new ABANKCustomer1()
            {
                Id = 1,
                AdiSoyadi = "MUSA SEKEROGLU",
                TCKimlikNo = "63862401392",
                MusteriNo = "10203040",
                Adres = "Pursaklar/ANKARA",
                TelefonNo = "05520108651",
                EmailAdres = "drnmaskr2005@gmail.com",
                AktifMi = true,

            });
            return customer;
        }

        [HttpGet("ABANKGetAllCustomer1")]
        public List<ABANKCustomer1> GetAllCustomer1()
        {
            return customer1Service.GetAllCustomer1().ToList();
        }
        [HttpGet("{id}")]
        public ABANKCustomer1 GetCustomer1ById(int id)
        {
            return customer1Service.GetCustomer1ById(id);
        }

        [HttpPost]
        public ABANKCustomer1 PostCustomer1(ABANKCustomer1 customer1)
        {
            return customer1Service.PostCustomer1(customer1);
        }
        [HttpPut]
        public ABANKCustomer1 PutCustomer1(ABANKCustomer1 customer1)
        {
            return customer1Service.PutCustomer1(customer1);
        }
        [HttpDelete("{id}")]
        public void DeleteCustomer1(int id)
        {
             customer1Service.DeleteCustomer1(id);
        }


    }
}
