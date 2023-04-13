using CustomerBankAccount.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace CustomerBankAccount.DataAccess.SeedData.ABANKSeedData
{
    public class ABANKCustomer1Account1ActivitiesSeedData : IEntityTypeConfiguration<ABANKCustomer1Account1Activities>
    {
        public void Configure(EntityTypeBuilder<ABANKCustomer1Account1Activities> builder)
        {
            builder.HasData
            (new ABANKCustomer1Account1Activities
            {
                Id = 1,
                İslemTipi = "",
                GönderenAdSoyad = "",
                GönderenHesapNo = "",
                GönderenIbanNo = "",
                AlıcıHesapNo = "",
                AlıcıIbanNo = "",
                AlıcıAdSoyad = "",
                GönderilenTutar = 0,
                AlıcıSubeKodu = Convert.ToInt32(0),
                İşlemAçıklaması = "",
                GönderilenTarih = DateTime.Now,
                GelenTransferHesapNo = "",
                GelenTransferIbanNo = "",              
                GelenTransferTutarı = 0,
                GelenTransferTarih = DateTime.Now
            });
        }
    }
}
