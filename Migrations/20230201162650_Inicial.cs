﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace StroreAPPASPAPIMySQL.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Auth",
                columns: table => new
                {
                    IdAuth = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.IdAuth);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    IdCart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    PTotal = table.Column<float>(name: "P_Total", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.IdCart);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DNI = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Direction = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime(6)", maxLength: 100, nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime(6)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CodeApp",
                columns: table => new
                {
                    IdCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CodeAdmin = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeApp", x => x.IdCode);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    IdCompany = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameCompany = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NameOwner = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Direction = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    RUC = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NumDocument = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Serie1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Serie2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Document = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DB = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Iva = table.Column<float>(type: "float", maxLength: 50, nullable: false),
                    Coin = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime(6)", maxLength: 100, nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime(6)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.IdCompany);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetailCart",
                columns: table => new
                {
                    IdDetailCart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdCart = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    DateNow = table.Column<string>(name: "Date_Now", type: "varchar(50)", maxLength: 50, nullable: false),
                    HourNow = table.Column<string>(name: "Hour_Now", type: "varchar(50)", maxLength: 50, nullable: false),
                    Subtotal = table.Column<float>(type: "float", maxLength: 50, nullable: false),
                    Subtotal12 = table.Column<float>(type: "float", maxLength: 50, nullable: false),
                    SubTotal0 = table.Column<float>(type: "float", maxLength: 50, nullable: false),
                    IvaTotal = table.Column<float>(type: "float", maxLength: 50, nullable: false),
                    Total = table.Column<float>(type: "float", maxLength: 50, nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime(6)", maxLength: 100, nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime(6)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailCart", x => x.IdDetailCart);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NameProduct = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CodeProduct = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    PUnitary = table.Column<float>(name: "P_Unitary", type: "float", maxLength: 50, nullable: false),
                    PTotal = table.Column<float>(name: "P_Total", type: "float", maxLength: 50, nullable: false),
                    ImageProduct = table.Column<string>(name: "Image_Product", type: "varchar(50)", maxLength: 50, nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "datetime(6)", maxLength: 100, nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "datetime(6)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    IdReport = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdDetailCart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.IdReport);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auth");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "CodeApp");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "DetailCart");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reports");
        }
    }
}
