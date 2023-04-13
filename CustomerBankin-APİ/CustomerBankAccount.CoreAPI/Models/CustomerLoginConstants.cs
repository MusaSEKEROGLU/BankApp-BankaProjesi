using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerBankAccount.CoreAPI.Models
{
    public class CustomerLoginConstants
    {
        public static List<CustomerLoginModel> Customers = new List<CustomerLoginModel>()
        {
            new CustomerLoginModel()
            {
               
                TCKimlikNo="63862401392",
                Sifre="Musa",
                Role="Customer1",

            },
            new CustomerLoginModel()
            {
                TCKimlikNo="60601536186",
                Sifre="Deren",
                Role="Customer2",
            },
            new CustomerLoginModel()
            {
                TCKimlikNo="66775304200",
                Sifre="Ayse",
                Role="Customer1",

            },
            new CustomerLoginModel()
            {
                TCKimlikNo="66800491280",
                Sifre="Tamay",
                Role="Customer2",
            }
        };
    }
}

