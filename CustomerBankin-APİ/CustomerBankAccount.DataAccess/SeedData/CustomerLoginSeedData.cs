using CustomerBankAccount.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccount.DataAccess.SeedData
{
    public class CustomerLoginSeedData : IEntityTypeConfiguration<CustomerLogin>
    {
        public void Configure(EntityTypeBuilder<CustomerLogin> builder)
        {
            builder.HasData(
            new CustomerLogin
            {
                Id = 1,
                TCKimlikNo = "63862401392",
                Sifre = "Musa",
                Role = "Customer1"

            }, new CustomerLogin
            {

                Id = 2,
                TCKimlikNo = "60601536186",
                Sifre = "Deren",
                Role = "Customer2"

            },
            new CustomerLogin()
            {
                Id = 3,
                TCKimlikNo = "66775304200",
                Sifre = "Ayse",
                Role = "Customer1",

            },
            new CustomerLogin()
            {
                Id=4,
                TCKimlikNo = "66800491280",
                Sifre = "Tamay",
                Role = "Customer2",
            });
        }
    }
}
