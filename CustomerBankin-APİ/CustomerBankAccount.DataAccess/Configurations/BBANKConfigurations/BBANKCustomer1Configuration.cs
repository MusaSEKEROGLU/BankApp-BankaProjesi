using CustomerBankAccount.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Configurations.BBANKConfigurations
{
    public class BBANKCustomer1Configuration : IEntityTypeConfiguration<BBANKCustomer1>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer1> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.TCKimlikNo).IsRequired().HasMaxLength(11);
            builder.Property(c => c.AdiSoyadi).IsRequired().HasMaxLength(20);
            builder.Property(c => c.MusteriNo).IsRequired().HasMaxLength(12);
            builder.Property(c => c.Adres).HasMaxLength(250);
            builder.Property(c => c.TelefonNo).HasMaxLength(24);
            builder.Property(c => c.EmailAdres).IsRequired().HasMaxLength(50);
            builder.Property(c => c.AktifMi).IsRequired();
            builder.ToTable("BBANKCustomer1");
        }
    }
}
