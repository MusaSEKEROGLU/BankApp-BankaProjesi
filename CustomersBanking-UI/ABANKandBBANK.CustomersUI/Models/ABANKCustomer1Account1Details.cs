using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABANKandBBANK.CustomersUI.Models
{
    public class ABANKCustomer1Account1Details
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
