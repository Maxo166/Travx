﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travx.API.Models;

#nullable disable

namespace Travx.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220324095846_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Travx.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusnessName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dscription")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("IsOpenForApplications")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("JobType")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MaxSalary")
                        .HasColumnType("REAL");

                    b.Property<double>("MinSalary")
                        .HasColumnType("REAL");

                    b.Property<int>("SalaryType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WorkLoation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Travx.Models.JobCalegory", b =>
                {
                    b.Property<int>("JobCalegoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("JobCalegoryId");

                    b.ToTable("JobCalegories");
                });
#pragma warning restore 612, 618
        }
    }
}