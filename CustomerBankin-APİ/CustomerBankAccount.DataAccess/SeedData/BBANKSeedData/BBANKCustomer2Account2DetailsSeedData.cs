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
    public class BBANKCustomer2Account2DetailsSeedData : IEntityTypeConfiguration<BBANKCustomer2Account2Details>
    {
        BBANKCustomer2Account customer2 = new BBANKCustomer2Account();
        public void Configure(EntityTypeBuilder<BBANKCustomer2Account2Details> builder)
        {
            builder.HasData
            (new BBANKCustomer2Account2Details
            {
                Id = 2,
                HesapAdi = "HalkbankVadesizTL",
                HesapNo = "2204114308",
                IbanNo = "TR880008200190032204114308",
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
