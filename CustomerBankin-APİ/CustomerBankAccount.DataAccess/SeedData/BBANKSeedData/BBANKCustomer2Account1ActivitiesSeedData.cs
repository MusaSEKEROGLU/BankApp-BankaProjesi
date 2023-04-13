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
    public class BBANKCustomer2Account1ActivitiesSeedData : IEntityTypeConfiguration<BBANKCustomer2Account1Activities>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer2Account1Activities> builder)
        {
            builder.HasData
            (new BBANKCustomer2Account1Activities
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
