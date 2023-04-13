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
    public class ABANKCustomer1Account1DetailsSeedData : IEntityTypeConfiguration<ABANKCustomer1Account1Details>
    {
        ABANKCustomer1Account customer1 = new ABANKCustomer1Account();
        public void Configure(EntityTypeBuilder<ABANKCustomer1Account1Details> builder)
        {
            builder.HasData
            (new ABANKCustomer1Account1Details
            {
                Id = 1,
                HesapAdi = "DenizbankVadesizTL",
                HesapNo = "1101177809",
                IbanNo = "TR670001200190031101177809",
                HesapBakiye = 10000,
                SubeAdi = "DENİZBANK/ANKARA/PURSAKLAR",
                MusteriNo = "10203040",
                HesapAktifMi = true,
                SubeKodu = 1010,
                GünlükTransferLimiti = 2500,

            });
        }
    }
}
