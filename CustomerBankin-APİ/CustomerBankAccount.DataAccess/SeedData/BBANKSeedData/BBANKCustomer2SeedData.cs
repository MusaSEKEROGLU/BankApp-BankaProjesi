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
    public class BBANKCustomer2SeedData : IEntityTypeConfiguration<BBANKCustomer2>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer2> builder)
        {
            builder.HasData(new BBANKCustomer2
            {
                Id = 2,
                AdiSoyadi = "AYŞE SEKEROGLU",
                TCKimlikNo = "66775304200",
                MusteriNo = "90807060",
                Adres = "Pursaklar/ANKARA",
                TelefonNo = "05302938227",
                EmailAdres = "ayse_98@gmail.com",
                AktifMi = true
            });
        }
    }
}
