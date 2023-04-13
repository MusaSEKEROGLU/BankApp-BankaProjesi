using CustomerBankAccount.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CustomerBankAccount.DataAccess.SeedData.ABANKSeedData
{
    public class ABANKCustomer2AccountSeedData : IEntityTypeConfiguration<ABANKCustomer2Account>
    {
        public void Configure(EntityTypeBuilder<ABANKCustomer2Account> builder)
        {
            builder.HasData
            (new ABANKCustomer2Account
            {
                Id = 1,
                MusteriNo = "00001111",
                HesapNo = "1101177000",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101177000",
                SubeAdi = "DENİZBANK/ANKARA/KEÇİÖREN",
                HesapBakiye = 10000,
                SubeKodu = 2121,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,


            },
            new ABANKCustomer1Account
            {
                Id = 2,
                MusteriNo = "00001111",
                HesapNo = "1101166111",
                HesapAdi = "DenizbankVadesizTL",
                IbanNo = "TR670001200190031101166111",
                SubeAdi = "DENİZBANK/ANKARA/KEÇİÖREN",
                HesapBakiye = 10000,
                SubeKodu = 2121,
                HesapAktifMi = true,
                GünlükTransferLimiti = 2500,
            }); ;
        }
    }
}
