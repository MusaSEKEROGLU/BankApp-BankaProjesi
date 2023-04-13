using CustomerBankAccount.CoreAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text;
using CustomerBankAccount.Business.Concrete;
using Microsoft.AspNetCore.DataProtection;

using System.Collections.Generic;
using System.Data;

namespace CustomerBankAccount.CoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerLoginController : ControllerBase
    {        
        private IConfiguration configuration;       
        public CustomerLoginController(IConfiguration configuration)
        {
            this.configuration = configuration;           
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] CustomerLogin customerLogin)
        {
            var customer = Authenticate(customerLogin);
            if (customer != null)
            {
                var token = Generate(customer);
                return Ok(token);
            }
            return NotFound("TCKimlikNo veya Sifre Hatalı");
        }
        private string Generate(CustomerLoginModel customer)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,customer.TCKimlikNo),
                new Claim(ClaimTypes.Role,customer.Role),
            };
            var token = new JwtSecurityToken
                (configuration["Jwt:Issuer"],
                configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddDays(1000),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private CustomerLoginModel Authenticate(CustomerLogin customerLogin)
        {
            var currentCustomer = CustomerLoginConstants.Customers.FirstOrDefault
                (x => x.TCKimlikNo.ToLower() == customerLogin.TCKimlikNo.ToLower() && x.Sifre == customerLogin.Sifre);
            if (currentCustomer != null)
            {
                return currentCustomer;
            }
            return null;
        }               
    }
}
