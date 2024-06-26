﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Blazor.Data;

#nullable disable

namespace Blazor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240516171226_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.30");

            modelBuilder.Entity("Models.MainWeather", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("latitude")
                        .HasColumnType("REAL");

                    b.Property<float>("longitude")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("weathers");
                });
#pragma warning restore 612, 618
        }
    }
}
