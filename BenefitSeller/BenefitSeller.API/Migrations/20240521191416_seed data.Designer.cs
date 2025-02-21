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
    [Migration("20240521191416_seed data")]
    partial class seeddata
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
                            Id = new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"),
                            Name = "StandardCompany"
                        },
                        new
                        {
                            Id = new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"),
                            Name = "PremiumCompany"
                        },
                        new
                        {
                            Id = new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"),
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
                            Id = new Guid("6d1c54f3-22a0-4efc-9722-8cf974b0cb16"),
                            DiscountPercentage = 12.5,
                            MerchantCategoryId = new Guid("4aa06b0f-a75c-4f20-8856-ed30599ffe51"),
                            Name = "Merchant1"
                        },
                        new
                        {
                            Id = new Guid("7cecf6c1-5769-45a2-af97-14bff65936d6"),
                            DiscountPercentage = 7.5,
                            MerchantCategoryId = new Guid("41706e95-912e-49cd-b159-43c9d793b3d3"),
                            Name = "Merchant2"
                        },
                        new
                        {
                            Id = new Guid("46ef13f1-e224-4246-9e86-0992854baa3d"),
                            MerchantCategoryId = new Guid("d2460aa2-8f34-45ed-8d90-2630c913b752"),
                            Name = "Merchant3"
                        },
                        new
                        {
                            Id = new Guid("6121e599-8014-4e82-a9ed-8cd3518910da"),
                            MerchantCategoryId = new Guid("81b2c9b0-537f-4153-adc4-5fd955bc4b0a"),
                            Name = "Merchant4"
                        },
                        new
                        {
                            Id = new Guid("3e555ccc-39ce-46c9-a889-00ea4efdc3d5"),
                            MerchantCategoryId = new Guid("ea5b0448-732d-48f6-92b4-5d4b7ad768f5"),
                            Name = "Merchant5"
                        },
                        new
                        {
                            Id = new Guid("79f06b3c-31fd-4f01-83e8-101652e9ac96"),
                            MerchantCategoryId = new Guid("f8211f11-c9ef-45e4-8da4-06679291ac99"),
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
                            Id = new Guid("4aa06b0f-a75c-4f20-8856-ed30599ffe51"),
                            MerchantCategoryGroupId = new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3"),
                            Name = "Restaurants"
                        },
                        new
                        {
                            Id = new Guid("41706e95-912e-49cd-b159-43c9d793b3d3"),
                            MerchantCategoryGroupId = new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3"),
                            Name = "Coffee shops"
                        },
                        new
                        {
                            Id = new Guid("d2460aa2-8f34-45ed-8d90-2630c913b752"),
                            MerchantCategoryGroupId = new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3"),
                            Name = "Fitness"
                        },
                        new
                        {
                            Id = new Guid("81b2c9b0-537f-4153-adc4-5fd955bc4b0a"),
                            MerchantCategoryGroupId = new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3"),
                            Name = "Sauna"
                        },
                        new
                        {
                            Id = new Guid("ea5b0448-732d-48f6-92b4-5d4b7ad768f5"),
                            MerchantCategoryGroupId = new Guid("dd240346-816a-4153-8636-7feabe1aed10"),
                            Name = "Courses"
                        },
                        new
                        {
                            Id = new Guid("f8211f11-c9ef-45e4-8da4-06679291ac99"),
                            MerchantCategoryGroupId = new Guid("dd240346-816a-4153-8636-7feabe1aed10"),
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("9a001141-bcf8-46d6-b736-fad01a257cf9"),
                            MerchantCategoryGroupId = new Guid("dd240346-816a-4153-8636-7feabe1aed10"),
                            Name = "Conferences"
                        },
                        new
                        {
                            Id = new Guid("b167e44e-7bf3-48eb-a9f8-2f3ab12093f4"),
                            MerchantCategoryGroupId = new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"),
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = new Guid("ffdcc4f4-dee5-4fd7-9079-9da572dca9ad"),
                            MerchantCategoryGroupId = new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"),
                            Name = "Museum"
                        },
                        new
                        {
                            Id = new Guid("7cd4858a-985d-4baf-bdee-79198e8ea2ca"),
                            MerchantCategoryGroupId = new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"),
                            Name = "Theater"
                        },
                        new
                        {
                            Id = new Guid("598e3758-3d24-4c02-b094-ebfeabbca8ad"),
                            MerchantCategoryGroupId = new Guid("510a7082-29ce-4155-b73c-528ba29875f3"),
                            Name = "Fuel"
                        },
                        new
                        {
                            Id = new Guid("714f01c2-796f-47b7-bf21-f44be23fb637"),
                            MerchantCategoryGroupId = new Guid("510a7082-29ce-4155-b73c-528ba29875f3"),
                            Name = "Plane tickets"
                        },
                        new
                        {
                            Id = new Guid("91661a10-d661-4091-89e7-be860647a72d"),
                            MerchantCategoryGroupId = new Guid("510a7082-29ce-4155-b73c-528ba29875f3"),
                            Name = "Train or bus tickets"
                        },
                        new
                        {
                            Id = new Guid("e45c40dc-fbfe-4ef0-adca-e33858c01515"),
                            MerchantCategoryGroupId = new Guid("510a7082-29ce-4155-b73c-528ba29875f3"),
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
                            Id = new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3"),
                            Name = "Food and drinks"
                        },
                        new
                        {
                            Id = new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3"),
                            Name = "Recreation"
                        },
                        new
                        {
                            Id = new Guid("dd240346-816a-4153-8636-7feabe1aed10"),
                            Name = "Education"
                        },
                        new
                        {
                            Id = new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7"),
                            Name = "Culture"
                        },
                        new
                        {
                            Id = new Guid("510a7082-29ce-4155-b73c-528ba29875f3"),
                            Name = "Traveling"
                        },
                        new
                        {
                            Id = new Guid("28c37842-82f1-479e-aedc-bcf9dca36092"),
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
                            Id = new Guid("dba735ac-78a6-44d2-8904-226f9e3fdc5f"),
                            Name = "Standard",
                            SubscriptionType = 0
                        },
                        new
                        {
                            Id = new Guid("d85e0cb1-acea-488e-b583-76cf88e272ed"),
                            Name = "Premium",
                            SubscriptionType = 1
                        },
                        new
                        {
                            Id = new Guid("daf621c3-2f1d-459a-b6ca-3207005fd585"),
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
                        .HasDefaultValue(new DateTime(2024, 5, 21, 21, 14, 15, 778, DateTimeKind.Local).AddTicks(4995));

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

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Id = new Guid("0de53f81-cb88-4251-bdfa-7e1fcba4988d"),
                            CompanyId = new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"),
                            Password = "password",
                            SubscriptionPlanId = new Guid("dba735ac-78a6-44d2-8904-226f9e3fdc5f"),
                            UserName = "StandardUser"
                        },
                        new
                        {
                            Id = new Guid("8cd0b9f0-5f18-4cc1-bcc9-965166292e3a"),
                            CompanyId = new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"),
                            Password = "password",
                            SubscriptionPlanId = new Guid("d85e0cb1-acea-488e-b583-76cf88e272ed"),
                            UserName = "PremiumUser"
                        },
                        new
                        {
                            Id = new Guid("453baa8a-67d8-4cdf-a5be-2854861f8de3"),
                            CompanyId = new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"),
                            Password = "password",
                            SubscriptionPlanId = new Guid("daf621c3-2f1d-459a-b6ca-3207005fd585"),
                            UserName = "PlatinumUser"
                        });
                });

            modelBuilder.Entity("BenefitSeller.API.Models.UserCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Balance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserCards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dc5bc907-af4b-4870-bf87-743c2a6148cd"),
                            Balance = 0.0,
                            UserId = new Guid("0de53f81-cb88-4251-bdfa-7e1fcba4988d")
                        },
                        new
                        {
                            Id = new Guid("1afe9403-26f6-4118-bae0-a93c0edbefbc"),
                            Balance = 0.0,
                            UserId = new Guid("8cd0b9f0-5f18-4cc1-bcc9-965166292e3a")
                        },
                        new
                        {
                            Id = new Guid("730db7eb-8962-4c4d-ae33-52d152b877a3"),
                            Balance = 0.0,
                            UserId = new Guid("453baa8a-67d8-4cdf-a5be-2854861f8de3")
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
                            CompaniesId = new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"),
                            MerchantCategoryGroupsId = new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3")
                        },
                        new
                        {
                            CompaniesId = new Guid("b6bcf870-e6e5-4fb5-bd2c-1533ce34a1c6"),
                            MerchantCategoryGroupsId = new Guid("284120ff-9afe-4cb4-9261-6beeac48b0b3")
                        },
                        new
                        {
                            CompaniesId = new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"),
                            MerchantCategoryGroupsId = new Guid("dd240346-816a-4153-8636-7feabe1aed10")
                        },
                        new
                        {
                            CompaniesId = new Guid("ca9387de-1455-443b-837a-bd1ac7555ef5"),
                            MerchantCategoryGroupsId = new Guid("9292e535-8b58-47dd-9bc9-fb01725da9b7")
                        },
                        new
                        {
                            CompaniesId = new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"),
                            MerchantCategoryGroupsId = new Guid("510a7082-29ce-4155-b73c-528ba29875f3")
                        },
                        new
                        {
                            CompaniesId = new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"),
                            MerchantCategoryGroupsId = new Guid("28c37842-82f1-479e-aedc-bcf9dca36092")
                        },
                        new
                        {
                            CompaniesId = new Guid("9714b373-aedf-420d-818c-c4a03d0bd55f"),
                            MerchantCategoryGroupsId = new Guid("16d45d48-801d-4a98-a23e-5bbc06e694d3")
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

            modelBuilder.Entity("BenefitSeller.API.Models.UserCard", b =>
                {
                    b.HasOne("BenefitSeller.API.Models.User", "User")
                        .WithMany("UserCards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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

            modelBuilder.Entity("BenefitSeller.API.Models.User", b =>
                {
                    b.Navigation("UserCards");
                });
#pragma warning restore 612, 618
        }
    }
}
