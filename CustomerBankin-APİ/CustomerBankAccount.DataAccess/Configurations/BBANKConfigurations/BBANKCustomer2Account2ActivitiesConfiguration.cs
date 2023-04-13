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
    public class BBANKCustomer2Account2ActivitiesConfiguration : IEntityTypeConfiguration<BBANKCustomer2Account2Activities>
    {
        public void Configure(EntityTypeBuilder<BBANKCustomer2Account2Activities> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.İslemTipi).IsRequired();
            builder.Property(c => c.GönderenAdSoyad).IsRequired().HasMaxLength(30);
            builder.Property(c => c.GönderenHesapNo).IsRequired().HasMaxLength(12);
            builder.Property(c => c.GönderenIbanNo).IsRequired().HasMaxLength(30);
            builder.Property(c => c.AlıcıSubeKodu).IsRequired();
            builder.Property(c => c.AlıcıHesapNo).IsRequired().HasMaxLength(12);
            builder.Property(c => c.AlıcıIbanNo).IsRequired().HasMaxLength(30);
            builder.Property(c => c.AlıcıAdSoyad).IsRequired().HasMaxLength(30);
            builder.Property(c => c.GönderilenTutar).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(c => c.İşlemAçıklaması).IsRequired();
            builder.Property(c => c.GönderilenTarih).IsRequired().HasColumnType("date");
            builder.Property(c => c.GelenTransferHesapNo).IsRequired().HasMaxLength(12);
            builder.Property(c => c.GelenTransferIbanNo).IsRequired().HasMaxLength(30);
            builder.Property(c => c.GelenTransferTutarı).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(c => c.GelenTransferTarih).IsRequired().HasColumnType("date");
            builder.ToTable("BBANKCustomer2Account2Activities");

        }
    }
}
