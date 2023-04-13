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
    public class ABANKCustomer2SeedData : IEntityTypeConfiguration<ABANKCustomer2>
    {
        public void Configure(EntityTypeBuilder<ABANKCustomer2> builder)
        {
            builder.HasData(new ABANKCustomer2
            {
                Id = 1,
                AdiSoyadi = "ELİF DEREN SEKEROGLU",
                TCKimlikNo = "60601536186",
                MusteriNo = "00001111",
                Adres = "Pursaklar/ANKARA",
                TelefonNo = "05520108651",
                EmailAdres = "drnmaskr2005@gmail.com",
                AktifMi = true,
            });
        }
    }
}
