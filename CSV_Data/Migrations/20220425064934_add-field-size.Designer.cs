﻿// <auto-generated />
using System;
using CSV_Import_Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CSV_Import_Data.Migrations
{
    [DbContext(typeof(OrdersDbContext))]
    [Migration("20220425064934_add-field-size")]
    partial class addfieldsize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CSV_Import_Data.Orders", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BuyerAddress1")
                        .HasColumnType("text");

                    b.Property<string>("BuyerAddress2")
                        .HasColumnType("text");

                    b.Property<string>("BuyerCity")
                        .HasColumnType("text");

                    b.Property<string>("BuyerCountry")
                        .HasColumnType("text");

                    b.Property<string>("BuyerName")
                        .HasColumnType("text");

                    b.Property<string>("BuyerNote")
                        .HasColumnType("text");

                    b.Property<string>("BuyerSate")
                        .HasColumnType("text");

                    b.Property<string>("BuyerUserName")
                        .HasColumnType("text");

                    b.Property<string>("BuyerZip")
                        .HasColumnType("text");

                    b.Property<string>("CustomLabel")
                        .HasColumnType("text");

                    b.Property<string>("ItemNumber")
                        .HasColumnType("text");

                    b.Property<string>("ItemTitle")
                        .HasColumnType("text");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.Property<string>("ShipToAddress1")
                        .HasColumnType("text");

                    b.Property<string>("ShipToAddress2")
                        .HasColumnType("text");

                    b.Property<string>("ShipToCity")
                        .HasColumnType("text");

                    b.Property<string>("ShipToCountry")
                        .HasColumnType("text");

                    b.Property<string>("ShipToName")
                        .HasColumnType("text");

                    b.Property<string>("ShipToPhone")
                        .HasColumnType("text");

                    b.Property<string>("ShipToState")
                        .HasColumnType("text");

                    b.Property<string>("ShipToZip")
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("OrderNumber")
                        .IsUnique();

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
