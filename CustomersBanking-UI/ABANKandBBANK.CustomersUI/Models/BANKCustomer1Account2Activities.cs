using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABANKandBBANK.CustomersUI.Models
{
    public class BBANKCustomer1Account2Activities
    {
        public int Id { get; set; }
        public string İslemTipi { get; set; }
        public string İşlemAçıklaması { get; set; }
        public string GönderenAdSoyad { get; set; }
        public string GönderenHesapNo { get; set; }
        public string GönderenIbanNo { get; set; }
        public decimal GönderilenTutar { get; set; }
        public DateTime GönderilenTarih { get; set; }
        public string AlıcıHesapNo { get; set; }
        public string AlıcıIbanNo { get; set; }
        public string AlıcıAdSoyad { get; set; }
        public int AlıcıSubeKodu { get; set; }
        public string GelenTransferHesapNo { get; set; }
        public string GelenTransferIbanNo { get; set; }
        public decimal GelenTransferTutarı { get; set; }
        public DateTime GelenTransferTarih { get; set; }
    }
}
