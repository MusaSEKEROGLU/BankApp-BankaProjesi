using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABANKandBBANK.CustomersUI.Models
{
    public class CustomerLogin
    {
        public int Id { get; set; }
        public string TCKimlikNo { get; set; }
        public string Sifre { get; set; }
        public string Role { get; set; }

    }
}
