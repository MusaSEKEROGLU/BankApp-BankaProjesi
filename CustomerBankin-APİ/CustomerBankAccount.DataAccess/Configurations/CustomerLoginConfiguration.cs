using CustomerBankAccount.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.Configurations
{
    public class CustomerLoginConfiguration : IEntityTypeConfiguration<CustomerLogin>
    {
        public void Configure(EntityTypeBuilder<CustomerLogin> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.TCKimlikNo).IsRequired().HasMaxLength(11);
            builder.Property(c => c.Sifre).IsRequired().HasMaxLength(6);
            builder.Property(c => c.Role).IsRequired().HasMaxLength(24);
        }
    }
}
