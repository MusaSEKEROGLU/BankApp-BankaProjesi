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
    public class ABANKCustomer2Account1DetailsSeedData : IEntityTypeConfiguration<ABANKCustomer2Account1Details>
    {
        ABANKCustomer2Account customer1 = new ABANKCustomer2Account();
        public void Configure(EntityTypeBuilder<ABANKCustomer2Account1Details> builder)
        {
            builder.HasData
            (new ABANKCustomer2Account1Details
            {
                Id = 1,
                HesapAdi = "DenizbankVadesizTL",
                HesapNo = "1101177000",
                IbanNo = "TR670001200190031101177000",
                HesapBakiye = 10000,
                SubeAdi = "DENİZBANK/ANKARA/KEÇİÖREN",
                MusteriNo = "00001111",
                HesapAktifMi = true,
                SubeKodu = 1111,
                GünlükTransferLimiti = 2500,

            });
        }
    }
}
