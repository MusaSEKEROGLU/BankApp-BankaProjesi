
using CustomerBankAccount.Entities.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.SeedData.BBANKSeedData
{
    public class BBANKCustomer1AccountSeedData : IEntityTypeConfiguration<BBANKCustomer1Account>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer1Account> builder)
        {
            builder.HasData
            (new BBANKCustomer1Account
            {
                Id = 1,
                MusteriNo = "00002222",
                HesapNo = "2204881999",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204881999",
                SubeAdi = "HALKBANK/ANKARA/PURSAKLAR",
                HesapBakiye = 10000,
                SubeKodu = 3030,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            },
            new BBANKCustomer2Account
            {
                Id = 2,
                MusteriNo = "00002222",
                HesapNo = "2204114333",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204114333",
                SubeAdi = "HALKBANK/ANKARA/PURSAKLAR",
                HesapBakiye = 10000,
                SubeKodu = 3030,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            });
        }
    }
}
