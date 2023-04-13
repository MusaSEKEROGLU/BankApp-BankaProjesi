using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBankAccount.CoreAPI.Models
{
    public class CustomerLogin
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "TCKimliknNo alanı zorunludur")]
        public string TCKimlikNo { get; set; }

        [Required(ErrorMessage = "Sifre alanı zorunludur")]
        public string Sifre { get; set; }
        public string Role { get; set; }
    }
}
