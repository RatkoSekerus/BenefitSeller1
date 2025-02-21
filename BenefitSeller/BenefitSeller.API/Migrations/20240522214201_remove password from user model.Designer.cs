﻿// <auto-generated />
using System;
using BenefitSeller.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BenefitSeller.API.Migrations
{
    [DbContext(typeof(BenefitSellerDbContext))]
    [Migration("20240522214201_remove password from user model")]
    partial class removepasswordfromusermodel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BenefitSeller.API.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"),
                            Name = "StandardCompany"
                        },
                        new
                        {
                            Id = new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"),
                            Name = "PremiumCompany"
                        },
                        new
                        {
                            Id = new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"),
                            Name = "PlatinumCompany"
                        });
                });

            modelBuilder.Entity("BenefitSeller.API.Models.Merchant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<double>("Earnings")
                        .HasColumnType("float");

                    b.Property<Guid>("MerchantCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MerchantCategoryId");

                    b.ToTable("Merchants");

                    b.HasData(
                        new
                        {
                            Id = new Guid("668dc37d-4fa9-41e4-a49d-c2c72b9b8821"),
                            DiscountPercentage = 12.5,
                            Earnings = 0.0,
                            MerchantCategoryId = new Guid("058cf432-c25d-4f46-9607-226ff0a51bf6"),
                            Name = "Merchant1"
                        },
                        new
                        {
                            Id = new Guid("08279196-ff85-4712-81ac-714f435b3dbf"),
                            DiscountPercentage = 7.5,
                            Earnings = 0.0,
                            MerchantCategoryId = new Guid("b474b3ee-cbaa-4217-b544-278cb9ad6da2"),
                            Name = "Merchant2"
                        },
                        new
                        {
                            Id = new Guid("6947fefc-5c7b-49bd-aa1a-39c5dece97e9"),
                            Earnings = 0.0,
                            MerchantCategoryId = new Guid("e797b656-11b6-4cd1-9324-c84dba20a0fa"),
                            Name = "Merchant3"
                        },
                        new
                        {
                            Id = new Guid("726b887c-2522-4d8a-b32b-cb0cd520a429"),
                            Earnings = 0.0,
                            MerchantCategoryId = new Guid("b6dba513-44ab-4212-a3d0-eebd84ed303e"),
                            Name = "Merchant4"
                        },
                        new
                        {
                            Id = new Guid("e7becafc-e057-4981-8f07-4023ed72bca5"),
                            Earnings = 0.0,
                            MerchantCategoryId = new Guid("4d188449-589d-4662-85b1-86e3ca67a3b9"),
                            Name = "Merchant5"
                        },
                        new
                        {
                            Id = new Guid("f07f87c0-0e2b-45e4-8bce-5068c876a42b"),
                            Earnings = 0.0,
                            MerchantCategoryId = new Guid("43e123e2-3ba0-47d9-b148-5c5c0d5313b0"),
                            Name = "Merchant6"
                        });
                });

            modelBuilder.Entity("BenefitSeller.API.Models.MerchantCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MerchantCategoryGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MerchantCategoryGroupId");

                    b.ToTable("MerchantCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("058cf432-c25d-4f46-9607-226ff0a51bf6"),
                            MerchantCategoryGroupId = new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b"),
                            Name = "Restaurants"
                        },
                        new
                        {
                            Id = new Guid("b474b3ee-cbaa-4217-b544-278cb9ad6da2"),
                            MerchantCategoryGroupId = new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b"),
                            Name = "Coffee shops"
                        },
                        new
                        {
                            Id = new Guid("e797b656-11b6-4cd1-9324-c84dba20a0fa"),
                            MerchantCategoryGroupId = new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7"),
                            Name = "Fitness"
                        },
                        new
                        {
                            Id = new Guid("b6dba513-44ab-4212-a3d0-eebd84ed303e"),
                            MerchantCategoryGroupId = new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7"),
                            Name = "Sauna"
                        },
                        new
                        {
                            Id = new Guid("4d188449-589d-4662-85b1-86e3ca67a3b9"),
                            MerchantCategoryGroupId = new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"),
                            Name = "Courses"
                        },
                        new
                        {
                            Id = new Guid("43e123e2-3ba0-47d9-b148-5c5c0d5313b0"),
                            MerchantCategoryGroupId = new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"),
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("de9ffa95-2f0e-450d-bd36-a6e0da6c7ef7"),
                            MerchantCategoryGroupId = new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"),
                            Name = "Conferences"
                        },
                        new
                        {
                            Id = new Guid("bdee9bc0-835e-457b-bd50-4682593dbf4b"),
                            MerchantCategoryGroupId = new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"),
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = new Guid("e998394e-ce58-4c63-9c80-66058f996794"),
                            MerchantCategoryGroupId = new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"),
                            Name = "Museum"
                        },
                        new
                        {
                            Id = new Guid("ec671a57-d222-440f-867d-f34c8004eb3d"),
                            MerchantCategoryGroupId = new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"),
                            Name = "Theater"
                        },
                        new
                        {
                            Id = new Guid("fa5c3fd4-9d4e-439c-9b4a-cf215175b334"),
                            MerchantCategoryGroupId = new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"),
                            Name = "Fuel"
                        },
                        new
                        {
                            Id = new Guid("f0fdbbba-97b3-4fb2-9f05-477aa973bdd7"),
                            MerchantCategoryGroupId = new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"),
                            Name = "Plane tickets"
                        },
                        new
                        {
                            Id = new Guid("fe657679-8cc5-4df4-80d9-90e98204e055"),
                            MerchantCategoryGroupId = new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"),
                            Name = "Train or bus tickets"
                        },
                        new
                        {
                            Id = new Guid("65c692b0-99f4-4d2b-9b88-db73bfb52517"),
                            MerchantCategoryGroupId = new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"),
                            Name = "Taxi"
                        });
                });

            modelBuilder.Entity("BenefitSeller.API.Models.MerchantCategoryGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MerchantCategoryGroups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b"),
                            Name = "Food and drinks"
                        },
                        new
                        {
                            Id = new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7"),
                            Name = "Recreation"
                        },
                        new
                        {
                            Id = new Guid("7c3f5f20-35ae-4699-8637-014b774acc76"),
                            Name = "Education"
                        },
                        new
                        {
                            Id = new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876"),
                            Name = "Culture"
                        },
                        new
                        {
                            Id = new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e"),
                            Name = "Traveling"
                        },
                        new
                        {
                            Id = new Guid("ad66e86b-69f0-48db-b95b-65f892f1ba08"),
                            Name = "Shopping"
                        });
                });

            modelBuilder.Entity("BenefitSeller.API.Models.SubscriptionPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubscriptionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionPlans");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a208be69-33fa-4fd3-9df0-014c7cc21d05"),
                            Name = "Standard",
                            SubscriptionType = 0
                        },
                        new
                        {
                            Id = new Guid("87ee4d8e-8ed7-457a-bf1c-ff509e2d3d06"),
                            Name = "Premium",
                            SubscriptionType = 1
                        },
                        new
                        {
                            Id = new Guid("dea5afbc-0bd3-4369-b5db-2a9b98bdceef"),
                            Name = "Platinum",
                            SubscriptionType = 2
                        });
                });

            modelBuilder.Entity("BenefitSeller.API.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<Guid>("MerchantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TransactionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 5, 22, 23, 42, 0, 960, DateTimeKind.Local).AddTicks(4539));

                    b.Property<int>("TransactionStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MerchantId");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("BenefitSeller.API.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Balance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubscriptionPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SubscriptionPlanId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b66e8fec-a94f-4acc-9552-68f2e6eeb8d0"),
                            Balance = 100.0,
                            CompanyId = new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"),
                            SubscriptionPlanId = new Guid("a208be69-33fa-4fd3-9df0-014c7cc21d05"),
                            UserName = "StandardUser"
                        },
                        new
                        {
                            Id = new Guid("5490a20c-e8f9-41aa-9606-2944813f0e31"),
                            Balance = 100.0,
                            CompanyId = new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"),
                            SubscriptionPlanId = new Guid("87ee4d8e-8ed7-457a-bf1c-ff509e2d3d06"),
                            UserName = "PremiumUser"
                        },
                        new
                        {
                            Id = new Guid("9ca58ef1-a790-414d-9421-de6023758d02"),
                            Balance = 100.0,
                            CompanyId = new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"),
                            SubscriptionPlanId = new Guid("dea5afbc-0bd3-4369-b5db-2a9b98bdceef"),
                            UserName = "PlatinumUser"
                        });
                });

            modelBuilder.Entity("CompanyMerchantCategoryGroup", b =>
                {
                    b.Property<Guid>("CompaniesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MerchantCategoryGroupsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CompaniesId", "MerchantCategoryGroupsId");

                    b.HasIndex("MerchantCategoryGroupsId");

                    b.ToTable("CompanyBenefit", (string)null);

                    b.HasData(
                        new
                        {
                            CompaniesId = new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"),
                            MerchantCategoryGroupsId = new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b")
                        },
                        new
                        {
                            CompaniesId = new Guid("562f495d-f7eb-4be9-a1b1-fe73ec12ec9b"),
                            MerchantCategoryGroupsId = new Guid("0dfb8498-ef19-46fd-bd74-e63a42130fa7")
                        },
                        new
                        {
                            CompaniesId = new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"),
                            MerchantCategoryGroupsId = new Guid("7c3f5f20-35ae-4699-8637-014b774acc76")
                        },
                        new
                        {
                            CompaniesId = new Guid("a2083c81-c5b6-4825-8ca6-13f67a7ce3ec"),
                            MerchantCategoryGroupsId = new Guid("b16472ad-15bc-4678-85b2-99ff33e4d876")
                        },
                        new
                        {
                            CompaniesId = new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"),
                            MerchantCategoryGroupsId = new Guid("33ec85de-d419-470c-abfb-c46cdd7b788e")
                        },
                        new
                        {
                            CompaniesId = new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"),
                            MerchantCategoryGroupsId = new Guid("ad66e86b-69f0-48db-b95b-65f892f1ba08")
                        },
                        new
                        {
                            CompaniesId = new Guid("75b7c3d7-e43c-4048-90ca-72cedd59b10c"),
                            MerchantCategoryGroupsId = new Guid("5b030f72-8e8a-4f94-bcfb-fed58c312f2b")
                        });
                });

            modelBuilder.Entity("BenefitSeller.API.Models.Merchant", b =>
                {
                    b.HasOne("BenefitSeller.API.Models.MerchantCategory", "MerchantCategory")
                        .WithMany()
                        .HasForeignKey("MerchantCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerchantCategory");
                });

            modelBuilder.Entity("BenefitSeller.API.Models.MerchantCategory", b =>
                {
                    b.HasOne("BenefitSeller.API.Models.MerchantCategoryGroup", "MerchantCategoryGroup")
                        .WithMany()
                        .HasForeignKey("MerchantCategoryGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MerchantCategoryGroup");
                });

            modelBuilder.Entity("BenefitSeller.API.Models.Transaction", b =>
                {
                    b.HasOne("BenefitSeller.API.Models.Merchant", "Merchant")
                        .WithMany()
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenefitSeller.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Merchant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BenefitSeller.API.Models.User", b =>
                {
                    b.HasOne("BenefitSeller.API.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenefitSeller.API.Models.SubscriptionPlan", "SubscriptionPlan")
                        .WithMany()
                        .HasForeignKey("SubscriptionPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("SubscriptionPlan");
                });

            modelBuilder.Entity("CompanyMerchantCategoryGroup", b =>
                {
                    b.HasOne("BenefitSeller.API.Models.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenefitSeller.API.Models.MerchantCategoryGroup", null)
                        .WithMany()
                        .HasForeignKey("MerchantCategoryGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BenefitSeller.API.Models.Company", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
