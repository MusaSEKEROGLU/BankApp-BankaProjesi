using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerBankAccount.DataAccess.Migrations
{
    public partial class dboMBH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: " BBANKCustomer2Account1Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ BBANKCustomer2Account1Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdiSoyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EmailAdres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TelefonNo = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer1Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer1Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer1Account1Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GönderenAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderenHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GönderenIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderilenTutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GönderilenTarih = table.Column<DateTime>(type: "date", nullable: false),
                    AlıcıHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    AlıcıIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıSubeKodu = table.Column<int>(type: "int", nullable: false),
                    GelenTransferHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GelenTransferIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GelenTransferTutarı = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GelenTransferTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer1Account1Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer1Account1Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer1Account1Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer1Account2Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GönderenAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderenHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GönderenIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderilenTutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GönderilenTarih = table.Column<DateTime>(type: "date", nullable: false),
                    AlıcıHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    AlıcıIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıSubeKodu = table.Column<int>(type: "int", nullable: false),
                    GelenTransferHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GelenTransferIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GelenTransferTutarı = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GelenTransferTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer1Account2Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer1Account2Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer1Account2Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdiSoyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EmailAdres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TelefonNo = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer2Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer2Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer2Account1Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GönderenAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderenHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GönderenIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderilenTutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GönderilenTarih = table.Column<DateTime>(type: "date", nullable: false),
                    AlıcıHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    AlıcıIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıSubeKodu = table.Column<int>(type: "int", nullable: false),
                    GelenTransferHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GelenTransferIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GelenTransferTutarı = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GelenTransferTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer2Account1Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer2Account1Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer2Account1Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer2Account2Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GönderenAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderenHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GönderenIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderilenTutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GönderilenTarih = table.Column<DateTime>(type: "date", nullable: false),
                    AlıcıHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    AlıcıIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıSubeKodu = table.Column<int>(type: "int", nullable: false),
                    GelenTransferHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GelenTransferIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GelenTransferTutarı = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GelenTransferTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer2Account2Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ABANKCustomer2Account2Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABANKCustomer2Account2Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdiSoyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EmailAdres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TelefonNo = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer1Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer1Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer1Account1Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GönderenAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderenHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GönderenIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderilenTutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GönderilenTarih = table.Column<DateTime>(type: "date", nullable: false),
                    AlıcıHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    AlıcıIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıSubeKodu = table.Column<int>(type: "int", nullable: false),
                    GelenTransferHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GelenTransferIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GelenTransferTutarı = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GelenTransferTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer1Account1Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer1Account1Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer1Account1Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer1Account2Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GönderenAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderenHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GönderenIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderilenTutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GönderilenTarih = table.Column<DateTime>(type: "date", nullable: false),
                    AlıcıHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    AlıcıIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıSubeKodu = table.Column<int>(type: "int", nullable: false),
                    GelenTransferHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GelenTransferIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GelenTransferTutarı = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GelenTransferTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer1Account2Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer1Account2Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer1Account2Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdiSoyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EmailAdres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TelefonNo = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer2Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer2Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer2Account1Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GönderenAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderenHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GönderenIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderilenTutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GönderilenTarih = table.Column<DateTime>(type: "date", nullable: false),
                    AlıcıHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    AlıcıIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıSubeKodu = table.Column<int>(type: "int", nullable: false),
                    GelenTransferHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GelenTransferIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GelenTransferTutarı = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GelenTransferTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer2Account1Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer2Account2Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İşlemAçıklaması = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GönderenAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderenHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GönderenIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GönderilenTutar = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GönderilenTarih = table.Column<DateTime>(type: "date", nullable: false),
                    AlıcıHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    AlıcıIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıAdSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlıcıSubeKodu = table.Column<int>(type: "int", nullable: false),
                    GelenTransferHesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GelenTransferIbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GelenTransferTutarı = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    GelenTransferTarih = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer2Account2Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBANKCustomer2Account2Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    HesapNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HesapBakiye = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SubeKodu = table.Column<int>(type: "int", nullable: false),
                    GünlükTransferLimiti = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HesapAktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBANKCustomer2Account2Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLogins", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: " BBANKCustomer2Account1Details",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[] { 1, 2500m, "HalkbankVadesizTL", true, 10000m, "2204881106", "TR880008200190032204881106", "90807060", "HALKBANK/ANKARA/KEÇİÖREN", 2020 });

            migrationBuilder.InsertData(
                table: "ABANKCustomer1",
                columns: new[] { "Id", "AdiSoyadi", "Adres", "AktifMi", "EmailAdres", "MusteriNo", "TCKimlikNo", "TelefonNo" },
                values: new object[] { 1, "MUSA SEKEROGLU", "Pursaklar/ANKARA", true, "drnmaskr2005@gmail.com", "10203040", "63862401392", "05520108651" });

            migrationBuilder.InsertData(
                table: "ABANKCustomer1Account",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[,]
                {
                    { 1, 2500m, "DenizbankVadesizTL", true, 10000m, "1101177809", "TR670001200190031101177809", "10203040", "DENİZBANK/ANKARA/PURSAKLAR", 1010 },
                    { 2, 2500m, "DenizbankVadesizTL", true, 10000m, "1101166820", "TR670001200190031101166820", "10203040", "DENİZBANK/ANKARA/PURSAKLAR", 1010 }
                });

            migrationBuilder.InsertData(
                table: "ABANKCustomer1Account1Activities",
                columns: new[] { "Id", "AlıcıAdSoyad", "AlıcıHesapNo", "AlıcıIbanNo", "AlıcıSubeKodu", "GelenTransferHesapNo", "GelenTransferIbanNo", "GelenTransferTarih", "GelenTransferTutarı", "GönderenAdSoyad", "GönderenHesapNo", "GönderenIbanNo", "GönderilenTarih", "GönderilenTutar", "İslemTipi", "İşlemAçıklaması" },
                values: new object[] { 1, "", "", "", 0, "", "", new DateTime(2023, 3, 7, 1, 31, 9, 297, DateTimeKind.Local).AddTicks(8387), 0m, "", "", "", new DateTime(2023, 3, 7, 1, 31, 9, 296, DateTimeKind.Local).AddTicks(1956), 0m, "", "" });

            migrationBuilder.InsertData(
                table: "ABANKCustomer1Account1Details",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[] { 1, 2500m, "DenizbankVadesizTL", true, 10000m, "1101177809", "TR670001200190031101177809", "10203040", "DENİZBANK/ANKARA/PURSAKLAR", 1010 });

            migrationBuilder.InsertData(
                table: "ABANKCustomer1Account2Activities",
                columns: new[] { "Id", "AlıcıAdSoyad", "AlıcıHesapNo", "AlıcıIbanNo", "AlıcıSubeKodu", "GelenTransferHesapNo", "GelenTransferIbanNo", "GelenTransferTarih", "GelenTransferTutarı", "GönderenAdSoyad", "GönderenHesapNo", "GönderenIbanNo", "GönderilenTarih", "GönderilenTutar", "İslemTipi", "İşlemAçıklaması" },
                values: new object[] { 2, "", "", "", 0, "", "", new DateTime(2023, 3, 7, 1, 31, 9, 298, DateTimeKind.Local).AddTicks(4497), 0m, "", "", "", new DateTime(2023, 3, 7, 1, 31, 9, 298, DateTimeKind.Local).AddTicks(3750), 0m, "", "" });

            migrationBuilder.InsertData(
                table: "ABANKCustomer1Account2Details",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[] { 2, 2500m, "DenizbankVadesizTL", true, 10000m, "1101166820", "TR670001200190031101166820", "10203040", "DENİZBANK/ANKARA/PURSAKLAR", 1010 });

            migrationBuilder.InsertData(
                table: "ABANKCustomer2",
                columns: new[] { "Id", "AdiSoyadi", "Adres", "AktifMi", "EmailAdres", "MusteriNo", "TCKimlikNo", "TelefonNo" },
                values: new object[] { 1, "ELİF DEREN SEKEROGLU", "Pursaklar/ANKARA", true, "drnmaskr2005@gmail.com", "00001111", "60601536186", "05520108651" });

            migrationBuilder.InsertData(
                table: "ABANKCustomer2Account",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[,]
                {
                    { 1, 2500m, "DenizbankVadesizTL", true, 10000m, "1101177000", "TR670001200190031101177000", "00001111", "DENİZBANK/ANKARA/KEÇİÖREN", 2121 },
                    { 2, 2500m, "DenizbankVadesizTL", true, 10000m, "1101166111", "TR670001200190031101166111", "00001111", "DENİZBANK/ANKARA/KEÇİÖREN", 2121 }
                });

            migrationBuilder.InsertData(
                table: "ABANKCustomer2Account1Activities",
                columns: new[] { "Id", "AlıcıAdSoyad", "AlıcıHesapNo", "AlıcıIbanNo", "AlıcıSubeKodu", "GelenTransferHesapNo", "GelenTransferIbanNo", "GelenTransferTarih", "GelenTransferTutarı", "GönderenAdSoyad", "GönderenHesapNo", "GönderenIbanNo", "GönderilenTarih", "GönderilenTutar", "İslemTipi", "İşlemAçıklaması" },
                values: new object[] { 1, "", "", "", 0, "", "", new DateTime(2023, 3, 7, 1, 31, 9, 300, DateTimeKind.Local).AddTicks(5799), 0m, "", "", "", new DateTime(2023, 3, 7, 1, 31, 9, 300, DateTimeKind.Local).AddTicks(5109), 0m, "", "" });

            migrationBuilder.InsertData(
                table: "ABANKCustomer2Account1Details",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[] { 1, 2500m, "DenizbankVadesizTL", true, 10000m, "1101177000", "TR670001200190031101177000", "00001111", "DENİZBANK/ANKARA/KEÇİÖREN", 1111 });

            migrationBuilder.InsertData(
                table: "ABANKCustomer2Account2Activities",
                columns: new[] { "Id", "AlıcıAdSoyad", "AlıcıHesapNo", "AlıcıIbanNo", "AlıcıSubeKodu", "GelenTransferHesapNo", "GelenTransferIbanNo", "GelenTransferTarih", "GelenTransferTutarı", "GönderenAdSoyad", "GönderenHesapNo", "GönderenIbanNo", "GönderilenTarih", "GönderilenTutar", "İslemTipi", "İşlemAçıklaması" },
                values: new object[] { 2, "", "", "", 0, "", "", new DateTime(2023, 3, 7, 1, 31, 9, 301, DateTimeKind.Local).AddTicks(832), 0m, "", "", "", new DateTime(2023, 3, 7, 1, 31, 9, 301, DateTimeKind.Local).AddTicks(181), 0m, "", "" });

            migrationBuilder.InsertData(
                table: "ABANKCustomer2Account2Details",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[] { 2, 2500m, "DenizbankVadesizTL", true, 10000m, "1101166111", "TR670001200190031101166111", "00001111", "DENİZBANK/ANKARA/KEÇİÖREN", 2121 });

            migrationBuilder.InsertData(
                table: "BBANKCustomer1",
                columns: new[] { "Id", "AdiSoyadi", "Adres", "AktifMi", "EmailAdres", "MusteriNo", "TCKimlikNo", "TelefonNo" },
                values: new object[] { 1, "TAMAY LİNA SEKEROGLU", "Pursaklar/ANKARA", true, "ayse_98@gmail.com", "00002222", "62800491280", "05302938227" });

            migrationBuilder.InsertData(
                table: "BBANKCustomer1Account",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[,]
                {
                    { 1, 2500m, "HalkbankVadesizTL", true, 10000m, "2204881999", "TR880008200190032204881999", "00002222", "HALKBANK/ANKARA/PURSAKLAR", 3030 },
                    { 2, 2500m, "HalkbankVadesizTL", true, 10000m, "2204114333", "TR880008200190032204114333", "00002222", "HALKBANK/ANKARA/PURSAKLAR", 3030 }
                });

            migrationBuilder.InsertData(
                table: "BBANKCustomer1Account1Activities",
                columns: new[] { "Id", "AlıcıAdSoyad", "AlıcıHesapNo", "AlıcıIbanNo", "AlıcıSubeKodu", "GelenTransferHesapNo", "GelenTransferIbanNo", "GelenTransferTarih", "GelenTransferTutarı", "GönderenAdSoyad", "GönderenHesapNo", "GönderenIbanNo", "GönderilenTarih", "GönderilenTutar", "İslemTipi", "İşlemAçıklaması" },
                values: new object[] { 1, "", "", "", 0, "", "", new DateTime(2023, 3, 7, 1, 31, 9, 308, DateTimeKind.Local).AddTicks(7939), 0m, "", "", "", new DateTime(2023, 3, 7, 1, 31, 9, 308, DateTimeKind.Local).AddTicks(5105), 0m, "", "" });

            migrationBuilder.InsertData(
                table: "BBANKCustomer1Account1Details",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[] { 1, 2500m, "HalkbankVadesizTL", true, 10000m, "2204881999", "TR880008200190032204881999", "00002222", "HALKBANK/ANKARA/PURSAKLAR", 3030 });

            migrationBuilder.InsertData(
                table: "BBANKCustomer1Account2Activities",
                columns: new[] { "Id", "AlıcıAdSoyad", "AlıcıHesapNo", "AlıcıIbanNo", "AlıcıSubeKodu", "GelenTransferHesapNo", "GelenTransferIbanNo", "GelenTransferTarih", "GelenTransferTutarı", "GönderenAdSoyad", "GönderenHesapNo", "GönderenIbanNo", "GönderilenTarih", "GönderilenTutar", "İslemTipi", "İşlemAçıklaması" },
                values: new object[] { 2, "", "", "", 0, "", "", new DateTime(2023, 3, 7, 1, 31, 9, 309, DateTimeKind.Local).AddTicks(7608), 0m, "", "", "", new DateTime(2023, 3, 7, 1, 31, 9, 309, DateTimeKind.Local).AddTicks(6827), 0m, "", "" });

            migrationBuilder.InsertData(
                table: "BBANKCustomer1Account2Details",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[] { 2, 2500m, "HalkbankVadesizTL", true, 10000m, "2204114333", "TR880008200190032204114333", "00002222", "HALKBANK/ANKARA/PURSAKLAR", 3030 });

            migrationBuilder.InsertData(
                table: "BBANKCustomer2",
                columns: new[] { "Id", "AdiSoyadi", "Adres", "AktifMi", "EmailAdres", "MusteriNo", "TCKimlikNo", "TelefonNo" },
                values: new object[] { 2, "AYŞE SEKEROGLU", "Pursaklar/ANKARA", true, "ayse_98@gmail.com", "90807060", "66775304200", "05302938227" });

            migrationBuilder.InsertData(
                table: "BBANKCustomer2Account",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[,]
                {
                    { 1, 2500m, "HalkbankVadesizTL", true, 10000m, "2204881106", "TR880008200190032204881106", "90807060", "HALKBANK/ANKARA/KEÇİÖREN", 2020 },
                    { 2, 2500m, "HalkbankVadesizTL", true, 10000m, "2204114308", "TR880008200190032204114308", "90807060", "HALKBANK/ANKARA/KEÇİÖREN", 2020 }
                });

            migrationBuilder.InsertData(
                table: "BBANKCustomer2Account1Activities",
                columns: new[] { "Id", "AlıcıAdSoyad", "AlıcıHesapNo", "AlıcıIbanNo", "AlıcıSubeKodu", "GelenTransferHesapNo", "GelenTransferIbanNo", "GelenTransferTarih", "GelenTransferTutarı", "GönderenAdSoyad", "GönderenHesapNo", "GönderenIbanNo", "GönderilenTarih", "GönderilenTutar", "İslemTipi", "İşlemAçıklaması" },
                values: new object[] { 1, "", "", "", 0, "", "", new DateTime(2023, 3, 7, 1, 31, 9, 303, DateTimeKind.Local).AddTicks(7456), 0m, "", "", "", new DateTime(2023, 3, 7, 1, 31, 9, 303, DateTimeKind.Local).AddTicks(6597), 0m, "", "" });

            migrationBuilder.InsertData(
                table: "BBANKCustomer2Account2Activities",
                columns: new[] { "Id", "AlıcıAdSoyad", "AlıcıHesapNo", "AlıcıIbanNo", "AlıcıSubeKodu", "GelenTransferHesapNo", "GelenTransferIbanNo", "GelenTransferTarih", "GelenTransferTutarı", "GönderenAdSoyad", "GönderenHesapNo", "GönderenIbanNo", "GönderilenTarih", "GönderilenTutar", "İslemTipi", "İşlemAçıklaması" },
                values: new object[] { 2, "", "", "", 0, "", "", new DateTime(2023, 3, 7, 1, 31, 9, 304, DateTimeKind.Local).AddTicks(6954), 0m, "", "", "", new DateTime(2023, 3, 7, 1, 31, 9, 304, DateTimeKind.Local).AddTicks(5979), 0m, "", "" });

            migrationBuilder.InsertData(
                table: "BBANKCustomer2Account2Details",
                columns: new[] { "Id", "GünlükTransferLimiti", "HesapAdi", "HesapAktifMi", "HesapBakiye", "HesapNo", "IbanNo", "MusteriNo", "SubeAdi", "SubeKodu" },
                values: new object[] { 2, 2500m, "HalkbankVadesizTL", true, 10000m, "2204114308", "TR880008200190032204114308", "90807060", "HALKBANK/ANKARA/KEÇİÖREN", 2020 });

            migrationBuilder.InsertData(
                table: "CustomerLogins",
                columns: new[] { "Id", "Role", "Sifre", "TCKimlikNo" },
                values: new object[,]
                {
                    { 3, "Customer1", "Ayse", "66775304200" },
                    { 1, "Customer1", "Musa", "63862401392" },
                    { 2, "Customer2", "Deren", "60601536186" },
                    { 4, "Customer2", "Tamay", "66800491280" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: " BBANKCustomer2Account1Details");

            migrationBuilder.DropTable(
                name: "ABANKCustomer1");

            migrationBuilder.DropTable(
                name: "ABANKCustomer1Account");

            migrationBuilder.DropTable(
                name: "ABANKCustomer1Account1Activities");

            migrationBuilder.DropTable(
                name: "ABANKCustomer1Account1Details");

            migrationBuilder.DropTable(
                name: "ABANKCustomer1Account2Activities");

            migrationBuilder.DropTable(
                name: "ABANKCustomer1Account2Details");

            migrationBuilder.DropTable(
                name: "ABANKCustomer2");

            migrationBuilder.DropTable(
                name: "ABANKCustomer2Account");

            migrationBuilder.DropTable(
                name: "ABANKCustomer2Account1Activities");

            migrationBuilder.DropTable(
                name: "ABANKCustomer2Account1Details");

            migrationBuilder.DropTable(
                name: "ABANKCustomer2Account2Activities");

            migrationBuilder.DropTable(
                name: "ABANKCustomer2Account2Details");

            migrationBuilder.DropTable(
                name: "BBANKCustomer1");

            migrationBuilder.DropTable(
                name: "BBANKCustomer1Account");

            migrationBuilder.DropTable(
                name: "BBANKCustomer1Account1Activities");

            migrationBuilder.DropTable(
                name: "BBANKCustomer1Account1Details");

            migrationBuilder.DropTable(
                name: "BBANKCustomer1Account2Activities");

            migrationBuilder.DropTable(
                name: "BBANKCustomer1Account2Details");

            migrationBuilder.DropTable(
                name: "BBANKCustomer2");

            migrationBuilder.DropTable(
                name: "BBANKCustomer2Account");

            migrationBuilder.DropTable(
                name: "BBANKCustomer2Account1Activities");

            migrationBuilder.DropTable(
                name: "BBANKCustomer2Account2Activities");

            migrationBuilder.DropTable(
                name: "BBANKCustomer2Account2Details");

            migrationBuilder.DropTable(
                name: "CustomerLogins");
        }
    }
}
