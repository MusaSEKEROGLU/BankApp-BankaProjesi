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
    public class BBANKCustomer1Account2DetailsConfiguration : IEntityTypeConfiguration<BBANKCustomer1Account2Details>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer1Account2Details> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.HesapNo).IsRequired().HasMaxLength(12);
            builder.Property(c => c.HesapAdi).IsRequired().HasMaxLength(26);
            builder.Property(c => c.IbanNo).IsRequired().HasMaxLength(30);
            builder.Property(c => c.SubeAdi).IsRequired().HasMaxLength(30);
            builder.Property(c => c.HesapBakiye).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(c => c.GünlükTransferLimiti).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(c => c.SubeKodu).IsRequired();
            builder.Property(c => c.MusteriNo).IsRequired().HasMaxLength(12);
            builder.Property(c => c.HesapAktifMi).IsRequired();
            builder.ToTable("BBANKCustomer1Account2Details");

        }
    }
}
