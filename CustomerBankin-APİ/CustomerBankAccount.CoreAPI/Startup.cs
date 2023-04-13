using CustomerBankAccount.Business.Abstract;
using CustomerBankAccount.Business.Abstract.ABANK;
using CustomerBankAccount.Business.Abstract.BBANK;
using CustomerBankAccount.Business.Concrete;
using CustomerBankAccount.Business.Concrete.ABANK;
using CustomerBankAccount.Business.Concrete.BBANK;
using CustomerBankAccount.DataAccess;
using CustomerBankAccount.DataAccess.Abstract;
using CustomerBankAccount.DataAccess.Abstract.ABANK;
using CustomerBankAccount.DataAccess.Abstract.BBANK;
using CustomerBankAccount.DataAccess.Abstract.ITransfer;
using CustomerBankAccount.DataAccess.Concrete;
using CustomerBankAccount.DataAccess.Concrete.ABANK;
using CustomerBankAccount.DataAccess.Concrete.BBANK;
using CustomerBankAccount.DataAccess.Concrete.Transfer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace CustomerBankAccount.CoreAPI
{
    public class Startup
    {        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }        
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<CBADbContext>();
            services.AddCors();
            //Authentication ayarlarý
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey =true,
                    ValidIssuer=Configuration["Jwt:Issuer"],
                    ValidAudience=Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "CustomerBankAccount.CoreAPI", Version = "v1" });

                //Swagger Authorization Çözüm Paneli
            c.AddSecurityDefinition("Bearer",new OpenApiSecurityScheme
            {
                Name="Authorization",
                Type=SecuritySchemeType.ApiKey,
                Scheme="Bearer",
                BearerFormat="JWT",
                In=ParameterLocation.Header,
                Description= "JWT Kullananarak Swagger Arayüzünde Authorization "

            });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference=new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                        new string[]{}
                    }
                });

            });
            services.AddDataProtection();
            services.AddScoped<ICustomerLoginRepository, CustomerLoginRepository>();
            //Repositories   BBANK         
                     
            services.AddScoped<BBANKICustomer2Repository, BBANKCustomer2Repository>();
            services.AddScoped<BBANKICustomer2Account1DetailsRepository, BBANKCustomer2Account1DetailsRepository>();
            services.AddScoped<BBANKICustomer2Account2DetailsRepository, BBANKCustomer2Account2DetailsRepository>();
            services.AddScoped<BBANKICustomer2Account1ActivitiesRepository, BBANKCustomer2Account1ActivitiesRepository>();
            services.AddScoped<BBANKICustomer2Account2ActivitiesRepository, BBANKCustomer2Account2ActivitiesRepository>();            
            services.AddScoped<BBANKICustomer2AccountRepository, BBANKCustomer2AccountRepository>();
            services.AddScoped<BBANKICustomer1Repository, BBANKCustomer1Repository>();
            services.AddScoped<BBANKICustomer1Account1DetailsRepository, BBANKCustomer1Account1DetailsRepository>();
            services.AddScoped<BBANKICustomer1Account2DetailsRepository, BBANKCustomer1Account2DetailsRepository>();
            services.AddScoped<BBANKICustomer1Account1ActivitiesRepository, BBANKCustomer1Account1ActivitiesRepository>();
            services.AddScoped<BBANKICustomer1Account2ActivitiesRepository, BBANKCustomer1Account2ActivitiesRepository>();
            services.AddScoped<BBANKICustomer1AccountRepository, BBANKCustomer1AccountRepository>();
            //MONEY TRANSFER
           
            services.AddScoped<IMoneyTransferEFTRepository, MoneyTransferEFTRepository>();
            services.AddScoped<IMoneyTransferHavaleRepository, MoneyTransferHavaleRepository>();
          
                      
            //Repositories   ABANK 
                     
            services.AddScoped<ABANKICustomer1Repository, ABANKCustomer1Repository>();            
            services.AddScoped<ABANKICustomer1AccountRepository, ABANKCustomer1AccountRepository>();           
            services.AddScoped<ABANKICustomer1Account1ActivitiesRepository, ABANKCustomer1Account1ActivitiesRepository>();
            services.AddScoped<ABANKICustomer1Account2ActivitiesRepository, ABANKCustomer1Account2ActivitiesRepository>();                       
            services.AddScoped<ABANKICustomer1Account1DetailsRepository, ABANKCustomer1Account1DetailsRepository>();
            services.AddScoped<ABANKICustomer1Account2DetailsRepository, ABANKCustomer1Account2DetailsRepository>();
            services.AddScoped<ABANKICustomer2Repository, ABANKCustomer2Repository>();
            services.AddScoped<ABANKICustomer2AccountRepository, ABANKCustomer2AccountRepository>();
            services.AddScoped<ABANKICustomer2Account1ActivitiesRepository, ABANKCustomer2Account1ActivitiesRepository>();
            services.AddScoped<ABANKICustomer2Account2ActivitiesRepository, ABANKCustomer2Account2ActivitiesRepository>();
            services.AddScoped<ABANKICustomer2Account1DetailsRepository, ABANKCustomer2Account1DetailsRepository>();
            services.AddScoped<ABANKICustomer2Account2DetailsRepository, ABANKCustomer2Account2DetailsRepository>();
                                    
            services.AddScoped<ICustomerLoginService, CustomerLoginService>();
            //Services  ABANK
                    
            services.AddScoped<ABANKICustomer1Service, ABANKCustomer1Service>();            
            services.AddScoped<ABANKICustomer1AccountService, ABANKCustomer1AccountService>();          
            services.AddScoped<ABANKICustomer1Account1ActivitiesService, ABANKCustomer1Account1ActivitiesService>();
            services.AddScoped<ABANKICustomer1Account2ActivitiesService, ABANKCustomer1Account2ActivitiesService>();                       
            services.AddScoped<ABANKICustomer1Account1DetailsService, ABANKCustomer1Account1DetailsService>();
            services.AddScoped<ABANKICustomer1Account2DetailsService, ABANKCustomer1Account2DetailsService>();
            services.AddScoped<ABANKICustomer2Service, ABANKCustomer2Service>();
            services.AddScoped<ABANKICustomer2AccountService, ABANKCustomer2AccountService>();
            services.AddScoped<ABANKICustomer2Account1ActivitiesService, ABANKCustomer2Account1ActivitiesService>();
            services.AddScoped<ABANKICustomer2Account2ActivitiesService, ABANKCustomer2Account2ActivitiesService>();
            services.AddScoped<ABANKICustomer2Account1DetailsService, ABANKCustomer2Account1DetailsService>();
            services.AddScoped<ABANKICustomer2Account2DetailsService, ABANKCustomer2Account2DetailsService>();
            //Services  BBANK   
                    
            services.AddScoped<BBANKICustomer2AccountService, BBANKCustomer2AccountService>();
            services.AddScoped<BBANKICustomer2Service, BBANKCustomer2Service>();
            services.AddScoped<BBANKICustomer2Account1DetailsService, BBANKCustomer2Account1DetailsService>();
            services.AddScoped<BBANKICustomer2Account2DetailsService, BBANKCustomer2Account2DetailsService>();
            services.AddScoped<BBANKICustomer2Account1ActivitiesService, BBANKCustomer2Account1ActivitiesService>();
            services.AddScoped<BBANKICustomer2Account2ActivitiesService, BBANKCustomer2Account2ActivitiesService>();
            services.AddScoped<BBANKICustomer1AccountService, BBANKCustomer1AccountService>();
            services.AddScoped<BBANKICustomer1Service, BBANKCustomer1Service>();
            services.AddScoped<BBANKICustomer1Account1DetailsService, BBANKCustomer1Account1DetailsService>();
            services.AddScoped<BBANKICustomer1Account2DetailsService, BBANKCustomer1Account2DetailsService>();
            services.AddScoped<BBANKICustomer1Account1ActivitiesService, BBANKCustomer1Account1ActivitiesService>();
            services.AddScoped<BBANKICustomer1Account2ActivitiesService, BBANKCustomer1Account2ActivitiesService>();            
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CustomerBankAccount.CoreAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
