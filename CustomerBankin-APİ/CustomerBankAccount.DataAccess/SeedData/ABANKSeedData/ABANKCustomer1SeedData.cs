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
    public class ABANKCustomer1SeedData : IEntityTypeConfiguration<ABANKCustomer1>
    {
        public void Configure(EntityTypeBuilder<ABANKCustomer1> builder)
        {
            builder.HasData(new ABANKCustomer1
            {
                Id = 1,
                AdiSoyadi = "MUSA SEKEROGLU",
                TCKimlikNo = "63862401392",
                MusteriNo = "10203040",
                Adres = "Pursaklar/ANKARA",
                TelefonNo = "05520108651",
                EmailAdres = "drnmaskr2005@gmail.com",
                AktifMi = true,
            });
        }
    }
}
