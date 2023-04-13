using CustomerBankAccount.DataAccess.Configurations;
using CustomerBankAccount.DataAccess.Configurations.ABANKConfigurations;
using CustomerBankAccount.DataAccess.Configurations.BBANKConfigurations;
using CustomerBankAccount.DataAccess.SeedData;
using CustomerBankAccount.DataAccess.SeedData.ABANKSeedData;
using CustomerBankAccount.DataAccess.SeedData.BBANKSeedData;
using CustomerBankAccount.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;


namespace CustomerBankAccount.DataAccess
{
    public class CBADbContext:DbContext
    {
        private static SqlConnection baglanti;
        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(@"Data Source=DESKTOP-THSSRI7\SQLEXPRESS;Initial Catalog=Dbo_MusteriBankaHesabı;Integrated Security=True;");
                }
                return baglanti;
            }
            set { baglanti = value; }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-THSSRI7\SQLEXPRESS;Initial Catalog=Dbo_MusteriBankaHesabı;Integrated Security=True;");
        }
       
      
        public DbSet<ABANKCustomer1> ABANKCustomer1 { get; set;}
        public DbSet<ABANKCustomer2> ABANKCustomer2 { get; set;}
        public DbSet<ABANKCustomer1Account> ABANKCustomer1Account { get; set;}               
        public DbSet<ABANKCustomer2Account> ABANKCustomer2Account { get; set;}               
        public DbSet<ABANKCustomer1Account1Details> ABANKcustomer1Account1Details { get; set;}
        public DbSet<ABANKCustomer2Account1Details> ABANKcustomer2Account1Details { get; set;}
        public DbSet<ABANKCustomer1Account2Details> ABANKcustomer1Account2Details { get; set;}
        public DbSet<ABANKCustomer2Account2Details> ABANKcustomer2Account2Details { get; set;}   
        public DbSet<ABANKCustomer1Account1Activities> ABANKcustomer1Account1Activities { get; set; }
        public DbSet<ABANKCustomer2Account1Activities> ABANKcustomer2Account1Activities { get; set; }
        public DbSet<ABANKCustomer1Account2Activities> ABANKcustomer1Account2Activities { get; set; }
        public DbSet<ABANKCustomer2Account2Activities> ABANKcustomer2Account2Activities { get; set; }
      
        public DbSet<CustomerLogin> CustomerLogins { get; set; }
       

        public DbSet<BBANKCustomer2> BBANKCustomer2 { get; set;}
        public DbSet<BBANKCustomer1> BBANKCustomer1 { get; set;}
        public DbSet<BBANKCustomer2Account> BBANKCustomer2Account { get; set;}               
        public DbSet<BBANKCustomer1Account> BBANKCustomer1Account { get; set;}               
        public DbSet<BBANKCustomer2Account1Details> BBANKcustomer2Account1Details { get; set; }
        public DbSet<BBANKCustomer1Account1Details> BBANKcustomer1Account1Details { get; set; }
        public DbSet<BBANKCustomer2Account2Details> BBANKcustomer2Account2Details { get; set; }
        public DbSet<BBANKCustomer1Account2Details> BBANKcustomer1Account2Details { get; set; }       
        public DbSet<BBANKCustomer2Account1Activities> BBANKcustomer2Account1Activities { get; set; }
        public DbSet<BBANKCustomer1Account1Activities> BBANKcustomer1Account1Activities { get; set; }
        public DbSet<BBANKCustomer2Account2Activities> BBANKcustomer2Account2Activities { get; set; }
        public DbSet<BBANKCustomer1Account2Activities> BBANKcustomer1Account2Activities { get; set; }                       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //SeedData'lar
            modelBuilder.ApplyConfiguration(new ABANKCustomer1SeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1AccountSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Account1DetailsSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Account2DetailsSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Account1ActivitiesSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Account2ActivitiesSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2SeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2AccountSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Account1DetailsSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Account2DetailsSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Account1ActivitiesSeedData());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Account2ActivitiesSeedData());
            modelBuilder.ApplyConfiguration(new CustomerLoginSeedData());          

            modelBuilder.ApplyConfiguration(new BBANKCustomer2SeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2AccountSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Account1DetailsSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Account2DetailsSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Account1ActivitiesSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Account2ActivitiesSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1SeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1AccountSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Account1DetailsSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Account2DetailsSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Account1ActivitiesSeedData());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Account2ActivitiesSeedData());           

            //Configuration Ayarları
            modelBuilder.ApplyConfiguration(new CustomerLoginConfiguration());            ;
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Configuration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1AccountConfiguration());           
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Account1DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Account2DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Account1ActivitiesConfiguration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer1Account2ActivitiesConfiguration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Configuration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2AccountConfiguration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Account1DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Account2DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Account1ActivitiesConfiguration());
            modelBuilder.ApplyConfiguration(new ABANKCustomer2Account2ActivitiesConfiguration());                       
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Configuration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2AccountConfiguration());                                                         
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Account1DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Account2DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Account1ActivitiesConfiguration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer2Account2ActivitiesConfiguration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Configuration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1AccountConfiguration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Account1DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Account2DetailsConfiguration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Account1ActivitiesConfiguration());
            modelBuilder.ApplyConfiguration(new BBANKCustomer1Account2ActivitiesConfiguration());            
        }
    }
}
