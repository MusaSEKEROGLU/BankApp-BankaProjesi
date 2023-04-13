using System.Collections.Generic;
using System.Data.SqlTypes;

namespace CustomerBankAccount.Entities.Models
{
    public class ABANKCustomer1Account
    {       
        public int Id { get; set; }       
        public string MusteriNo { get; set; }
        public string HesapNo { get; set; }
        public string HesapAdi { get; set; }
        public string IbanNo { get; set; }
        public string SubeAdi { get; set; }
        public int SubeKodu { get; set; }
        public decimal HesapBakiye { get; set; }
        public decimal GünlükTransferLimiti { get; set; }
        public bool HesapAktifMi { get; set; }                       
    }
}
