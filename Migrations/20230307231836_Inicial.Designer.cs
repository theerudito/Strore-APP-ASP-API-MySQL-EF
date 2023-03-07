﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Strore_APP_ASP_API_MySQL.DB_Context;

#nullable disable

namespace Strore_APP_ASP_API_MySQL.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230307231836_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MAuth", b =>
                {
                    b.Property<int>("IdAuth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdAuth");

                    b.ToTable("Auth");
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MCart", b =>
                {
                    b.Property<int>("IdCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<float>("P_Total")
                        .HasColumnType("float");

                    b.HasKey("IdCart");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdProduct");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MClient", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("IdClient");

                    b.ToTable("Clients", (string)null);
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MCodeApp", b =>
                {
                    b.Property<int>("IdCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodeAdmin")
                        .HasColumnType("int");

                    b.HasKey("IdCode");

                    b.ToTable("CodeApp");
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MCompany", b =>
                {
                    b.Property<int>("IdCompany")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Coin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DB")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<float>("Iva")
                        .HasColumnType("float");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NameOwner")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("NumDocument")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("RUC")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Serie1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Serie2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("created_at")
                        .HasMaxLength(100)
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_at")
                        .HasMaxLength(100)
                        .HasColumnType("datetime(6)");

                    b.HasKey("IdCompany");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MDetailsCart", b =>
                {
                    b.Property<int>("IdDetailCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date_Now")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Hour_Now")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCart")
                        .HasColumnType("int");

                    b.Property<float>("IvaTotal")
                        .HasColumnType("float");

                    b.Property<float>("SubTotal0")
                        .HasColumnType("float");

                    b.Property<float>("Subtotal")
                        .HasColumnType("float");

                    b.Property<float>("Subtotal12")
                        .HasColumnType("float");

                    b.Property<float>("Total")
                        .HasColumnType("float");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("IdDetailCart");

                    b.HasIndex("IdCart");

                    b.ToTable("DetailCart", (string)null);
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MProduct", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CodeProduct")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Image_Product")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<float>("P_Total")
                        .HasColumnType("float");

                    b.Property<float>("P_Unitary")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("IdProduct");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MReport", b =>
                {
                    b.Property<int>("IdReport")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDetailCart")
                        .HasColumnType("int");

                    b.HasKey("IdReport");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MCart", b =>
                {
                    b.HasOne("Strore_APP_ASP_API_MySQL.Models.MClient", "Client")
                        .WithMany("Cart")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Strore_APP_ASP_API_MySQL.Models.MProduct", "Product")
                        .WithMany("Cart")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MDetailsCart", b =>
                {
                    b.HasOne("Strore_APP_ASP_API_MySQL.Models.MCart", "Cart")
                        .WithMany("DetailsCart")
                        .HasForeignKey("IdCart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MCart", b =>
                {
                    b.Navigation("DetailsCart");
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MClient", b =>
                {
                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Strore_APP_ASP_API_MySQL.Models.MProduct", b =>
                {
                    b.Navigation("Cart");
                });
#pragma warning restore 612, 618
        }
    }
}