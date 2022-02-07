﻿// <auto-generated />
using AtmBanking.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AtmBanking.DAL.Migrations
{
    [DbContext(typeof(AtmDbContext))]
    [Migration("20220207150223_AccountDetailsModelCreation")]
    partial class AccountDetailsModelCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AtmBanking.Entity.Models.AccountDetails", b =>
                {
                    b.Property<int>("accountId_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("account_number")
                        .HasColumnType("int");

                    b.Property<string>("account_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("card_no")
                        .HasColumnType("int");

                    b.Property<string>("credit_fields")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("current_balance")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("accountId_no");

                    b.ToTable("accountDetails");
                });

            modelBuilder.Entity("AtmBanking.Entity.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("account_number")
                        .HasColumnType("int");

                    b.Property<string>("account_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("card_no")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("contact_info")
                        .HasColumnType("int");

                    b.Property<string>("email_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pin_no")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("AtmBanking.Entity.Models.CustomerInfo", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("account_number")
                        .HasColumnType("int");

                    b.Property<string>("account_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("card_no")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("contact_info")
                        .HasColumnType("int");

                    b.Property<string>("email_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pin_no")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("customerInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
