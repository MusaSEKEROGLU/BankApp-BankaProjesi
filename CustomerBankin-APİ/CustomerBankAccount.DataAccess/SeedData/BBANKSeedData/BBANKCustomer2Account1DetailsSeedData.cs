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
    public class BBANKCustomer2Account1DetailsSeedData : IEntityTypeConfiguration<BBANKCustomer2Account1Details>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer2Account1Details> builder)
        {
            builder.HasData
            (new BBANKCustomer2Account1Details
            {
                Id = 1,
                HesapAdi = "HalkbankVadesizTL",
                HesapNo = "2204881106",
                IbanNo = "TR880008200190032204881106",
                HesapBakiye = 10000,
                SubeAdi = "HALKBANK/ANKARA/KEÇİÖREN",
                GünlükTransferLimiti = 2500,
                HesapAktifMi = true,
                SubeKodu = 2020,
                MusteriNo = "90807060",

            });
        }
    }
}
