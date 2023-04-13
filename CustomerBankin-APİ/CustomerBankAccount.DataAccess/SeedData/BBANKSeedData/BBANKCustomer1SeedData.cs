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
    public class BBANKCustomer1SeedData : IEntityTypeConfiguration<BBANKCustomer1>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer1> builder)
        {
            builder.HasData(new BBANKCustomer1
            {
                Id = 1,
                AdiSoyadi = "TAMAY LİNA SEKEROGLU",
                TCKimlikNo = "62800491280",
                MusteriNo = "00002222",
                Adres = "Pursaklar/ANKARA",
                TelefonNo = "05302938227",
                EmailAdres = "ayse_98@gmail.com",
                AktifMi = true
            });
        }
    }
}
