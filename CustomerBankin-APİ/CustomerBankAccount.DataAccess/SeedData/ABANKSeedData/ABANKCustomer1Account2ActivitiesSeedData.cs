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
    public class ABANKCustomer1Account2ActivitiesSeedData : IEntityTypeConfiguration<ABANKCustomer1Account2Activities>
    {
        public void Configure(EntityTypeBuilder<ABANKCustomer1Account2Activities> builder)
        {
            builder.HasData
            (new ABANKCustomer1Account2Activities
            {
                Id = 2,
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
