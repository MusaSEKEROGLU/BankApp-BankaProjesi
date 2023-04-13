using CustomerBankAccount.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.SeedData.ABANKSeedData
{
    public class ABANKCustomer2Account2DetailsSeedData : IEntityTypeConfiguration<ABANKCustomer2Account2Details>
    {
        ABANKCustomer2Account customer1 = new ABANKCustomer2Account();
        public void Configure(EntityTypeBuilder<ABANKCustomer2Account2Details> builder)
        {
            builder.HasData
            (new ABANKCustomer2Account2Details
            {
                Id = 2,
                HesapAdi = "DenizbankVadesizTL",
                HesapNo = "1101166111",
                IbanNo = "TR670001200190031101166111",
                HesapBakiye = 10000,
                SubeAdi = "DENİZBANK/ANKARA/KEÇİÖREN",
                MusteriNo = "00001111",
                HesapAktifMi = true,
                SubeKodu = 2121,
                GünlükTransferLimiti = 2500,

            });
        }
    }
}
