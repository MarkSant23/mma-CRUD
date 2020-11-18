﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mmaCrudPin.Models;

namespace mmaCrudPin.Migrations
{
    [DbContext(typeof(mmaDbContext))]
    [Migration("20201116182749_addSalary")]
    partial class addSalary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("mmaCrudPin.Models.mmaFighter", b =>
                {
                    b.Property<int>("fighterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("category")
                        .HasColumnType("int");

                    b.Property<DateTime?>("created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("figtherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("worth_salary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fighterId");

                    b.ToTable("mmaFighters");
                });
#pragma warning restore 612, 618
        }
    }
}
