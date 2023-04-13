using CustomerBankAccount.CoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace CustomerBankAccount.CoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersRoleController : ControllerBase
    {
        //[Authorize]
        [HttpGet("Customers")]
        public IActionResult CustomersEndpoint()
        {
            var currentCustomer = GetCurrentCustomer();
            return Ok($"Merhaba {currentCustomer.TCKimlikNo},sen bir {currentCustomer.Role}");
        }
        private CustomerLoginModel GetCurrentCustomer()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var customerClaims = identity.Claims;
                return new CustomerLoginModel
                {
                    TCKimlikNo = customerClaims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value,
                    Role = customerClaims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value,
                };
            }
            return null;
        }
    }
}
