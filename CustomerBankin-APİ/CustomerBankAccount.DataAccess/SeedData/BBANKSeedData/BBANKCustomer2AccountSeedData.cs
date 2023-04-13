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
    public class BBANKCustomer2AccountSeedData : IEntityTypeConfiguration<BBANKCustomer2Account>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer2Account> builder)
        {
            builder.HasData
            (new BBANKCustomer2Account
            {
                Id = 1,
                MusteriNo = "90807060",
                HesapNo = "2204881106",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204881106",
                SubeAdi = "HALKBANK/ANKARA/KEÇİÖREN",
                HesapBakiye = 10000,
                SubeKodu = 2020,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            },
            new BBANKCustomer2Account
            {
                Id = 2,

                MusteriNo = "90807060",
                HesapNo = "2204114308",
                HesapAdi = "HalkbankVadesizTL",
                IbanNo = "TR880008200190032204114308",
                SubeAdi = "HALKBANK/ANKARA/KEÇİÖREN",
                HesapBakiye = 10000,
                SubeKodu = 2020,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            });
        }
    }
}
