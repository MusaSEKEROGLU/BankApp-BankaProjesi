using CustomerBankAccount.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CustomerBankAccount.DataAccess.SeedData.ABANKSeedData
{
    public class ABANKCustomer1AccountSeedData : IEntityTypeConfiguration<ABANKCustomer1Account>
    {
        public void Configure(EntityTypeBuilder<ABANKCustomer1Account> builder)
        {
            builder.HasData
            (new ABANKCustomer1Account
            {
                Id = 1,
                MusteriNo = "10203040",
                HesapNo = "1101177809",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101177809",
                SubeAdi = "DENİZBANK/ANKARA/PURSAKLAR",
                HesapBakiye = 10000,
                SubeKodu = 1010,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,


            },
            new ABANKCustomer1Account
            {
                Id = 2,
                MusteriNo = "10203040",
                HesapNo = "1101166820",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101166820",
                SubeAdi = "DENİZBANK/ANKARA/PURSAKLAR",
                HesapBakiye = 10000,
                SubeKodu = 1010,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            }); ;
        }
    }
}
