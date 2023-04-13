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
    public class BBANKCustomer1Account2DetailsSeedData : IEntityTypeConfiguration<BBANKCustomer1Account2Details>
    {        
        public void Configure(EntityTypeBuilder<BBANKCustomer1Account2Details> builder)
        {
            builder.HasData
            (new BBANKCustomer1Account2Details
            {
                Id = 2,
                HesapAdi = "HalkbankVadesizTL",
                HesapNo = "2204114333",
                IbanNo = "TR880008200190032204114333",
                HesapBakiye = 10000,
                SubeAdi = "HALKBANK/ANKARA/PURSAKLAR",
                GünlükTransferLimiti = 2500,
                HesapAktifMi = true,
                SubeKodu = 3030,
                MusteriNo = "00002222",


            });
        }
    }
}
