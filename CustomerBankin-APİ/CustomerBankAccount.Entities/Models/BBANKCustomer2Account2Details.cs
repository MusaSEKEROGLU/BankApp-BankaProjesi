using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.Entities.Models
{
    public class BBANKCustomer2Account2Details
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string HesapNo { get; set; }
        public string IbanNo { get; set; }
        public decimal HesapBakiye { get; set; }
        public string HesapAdi { get; set; }
        public string SubeAdi { get; set; }
        public int SubeKodu { get; set; }
        public decimal GünlükTransferLimiti { get; set; }
        public bool HesapAktifMi { get; set; }


    }
}
