﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SilkRoad.Date;

namespace SilkRoad.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220721232435_SilkRoad")]
    partial class SilkRoad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("SilkRoad.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("Name");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("Price");

                    b.Property<string>("UrlImage")
                        .HasColumnType("longtext")
                        .HasColumnName("UrlImage");

                    b.Property<double>("Weight")
                        .HasColumnType("double")
                        .HasColumnName("Weight");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
