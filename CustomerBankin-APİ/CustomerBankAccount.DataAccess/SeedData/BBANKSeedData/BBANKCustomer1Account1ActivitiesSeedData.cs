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
    public class BBANKCustomer1Account1ActivitiesSeedData : IEntityTypeConfiguration<BBANKCustomer1Account1Activities>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer1Account1Activities> builder)
        {
            builder.HasData
            (new BBANKCustomer1Account1Activities
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
