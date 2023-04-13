using CustomerBankAccount.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBankAccount.CoreAPI.Models
{
    public class CustomerLoginModel
    {
        [Required(ErrorMessage = "TCKimlikNo alani zorunludur")]
        public string TCKimlikNo { get; set; }

        [Required(ErrorMessage = "Sifre alani zorunludur")]
        public string Sifre { get; set; }
        public string Role { get; set; }
    }
}
