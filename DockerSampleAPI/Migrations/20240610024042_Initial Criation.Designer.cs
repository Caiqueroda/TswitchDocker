﻿// <auto-generated />
using System;
using DockerSampleAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DockerSampleAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240610024042_Initial Criation")]
    partial class InitialCriation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DockerSampleAPI.Models.Msg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("LocalDate")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("LocalTime")
                        .HasColumnType("time");

                    b.Property<int>("MCC")
                        .HasColumnType("int");

                    b.Property<int>("Pan")
                        .HasColumnType("int");

                    b.Property<int>("Refnum")
                        .HasColumnType("int");

                    b.Property<int>("RespCode")
                        .HasColumnType("int");

                    b.Property<int>("Trace")
                        .HasColumnType("int");

                    b.Property<decimal>("TranAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateOnly>("TranDate")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("TranTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Msgs");
                });
#pragma warning restore 612, 618
        }
    }
}
