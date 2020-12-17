﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(FacebukDbContext))]
    [Migration("20201206220155_ActivityDomainAdded")]
    partial class ActivityDomainAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Venue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Domain.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 12, 6, 17, 1, 54, 613, DateTimeKind.Local).AddTicks(7062),
                            Summary = "Freezing",
                            TemperatureC = -15
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 12, 7, 17, 1, 54, 617, DateTimeKind.Local).AddTicks(5308),
                            Summary = "Chilly",
                            TemperatureC = 16
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2020, 12, 8, 17, 1, 54, 617, DateTimeKind.Local).AddTicks(5410),
                            Summary = "Cool",
                            TemperatureC = 20
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2020, 12, 9, 17, 1, 54, 617, DateTimeKind.Local).AddTicks(5419),
                            Summary = "Mild",
                            TemperatureC = 25
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2020, 12, 10, 17, 1, 54, 617, DateTimeKind.Local).AddTicks(5422),
                            Summary = "Warm",
                            TemperatureC = 30
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2020, 12, 11, 17, 1, 54, 617, DateTimeKind.Local).AddTicks(5426),
                            Summary = "Hot",
                            TemperatureC = 40
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2020, 12, 12, 17, 1, 54, 617, DateTimeKind.Local).AddTicks(5430),
                            Summary = "Scorching",
                            TemperatureC = 45
                        });
                });
#pragma warning restore 612, 618
        }
    }
}