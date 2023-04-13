using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABANKandBBANK.CustomersUI.Models
{
    public class BBANKCustomer2
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; }
        public string MusteriNo { get; set; }
        public string TCKimlikNo { get; set; }
        public string EmailAdres { get; set; }
        public string Adres { get; set; }
        public string TelefonNo { get; set; }
        public bool AktifMi { get; set; }       
    }
}
