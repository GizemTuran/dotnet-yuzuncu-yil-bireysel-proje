﻿// <auto-generated />
using System;
using DotnetYuzuncuYilBireyselProje.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotnetYuzuncuYilBireyselProje.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DotnetYuzuncuYilBireyselProje.Core.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Clients", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientName = "Gizem",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "gizemturan@gmail.com",
                            Password = "123456",
                            StoreId = 1,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ClientName = "Ecem",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ecemturan@gmail.com",
                            Password = "564821",
                            StoreId = 2,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ClientName = "Burcu",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "burcudag@gmail.com",
                            Password = "546218",
                            StoreId = 3,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ClientName = "Bahar",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "baharkoc@gmail.com",
                            Password = "9856124",
                            StoreId = 4,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DotnetYuzuncuYilBireyselProje.Core.Models.ClientProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("StoreId");

                    b.ToTable("ClientProfiles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            FirstName = "Gizem",
                            LastName = "Turan"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            FirstName = "Ecem",
                            LastName = "Turan"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 3,
                            FirstName = "Burcu",
                            LastName = "Dağ"
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 4,
                            FirstName = "Bahar",
                            LastName = "Koç"
                        });
                });

            modelBuilder.Entity("DotnetYuzuncuYilBireyselProje.Core.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Stores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 12, 15, 56, 47, 234, DateTimeKind.Local).AddTicks(4763),
                            StoreName = "Zara",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 12, 15, 56, 47, 234, DateTimeKind.Local).AddTicks(4772),
                            StoreName = "Mango",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 12, 15, 56, 47, 234, DateTimeKind.Local).AddTicks(4773),
                            StoreName = "Stradivarious",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 12, 15, 56, 47, 234, DateTimeKind.Local).AddTicks(4774),
                            StoreName = "Bershka",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DotnetYuzuncuYilBireyselProje.Core.Models.Client", b =>
                {
                    b.HasOne("DotnetYuzuncuYilBireyselProje.Core.Models.Store", "store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("store");
                });

            modelBuilder.Entity("DotnetYuzuncuYilBireyselProje.Core.Models.ClientProfile", b =>
                {
                    b.HasOne("DotnetYuzuncuYilBireyselProje.Core.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotnetYuzuncuYilBireyselProje.Core.Models.Store", null)
                        .WithMany("Client")
                        .HasForeignKey("StoreId");

                    b.Navigation("client");
                });

            modelBuilder.Entity("DotnetYuzuncuYilBireyselProje.Core.Models.Store", b =>
                {
                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
