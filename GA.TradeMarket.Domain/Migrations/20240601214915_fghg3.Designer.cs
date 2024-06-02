﻿// <auto-generated />
using System;
using GA.TradeMarket.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GA.TradeMarket.Domain.Migrations
{
    [DbContext(typeof(TradeMarketDbContext))]
    [Migration("20240601214915_fghg3")]
    partial class fghg3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.BonusProgram", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bonuses");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Coupon", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "GE343451634435",
                            DiscountValue = 45m,
                            ExpiryDate = new DateTime(2024, 7, 24, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2182)
                        },
                        new
                        {
                            Id = 2L,
                            Code = "GE343424934435",
                            DiscountValue = 467m,
                            ExpiryDate = new DateTime(2025, 7, 19, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2234)
                        },
                        new
                        {
                            Id = 3L,
                            Code = "GE343410734435",
                            DiscountValue = 457m,
                            ExpiryDate = new DateTime(2025, 2, 8, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2237)
                        },
                        new
                        {
                            Id = 4L,
                            Code = "GE343412934435",
                            DiscountValue = 48m,
                            ExpiryDate = new DateTime(2024, 8, 10, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2240)
                        },
                        new
                        {
                            Id = 5L,
                            Code = "GE343446534435",
                            DiscountValue = 45m,
                            ExpiryDate = new DateTime(2025, 9, 23, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2242)
                        },
                        new
                        {
                            Id = 6L,
                            Code = "GE343448234435",
                            DiscountValue = 25m,
                            ExpiryDate = new DateTime(2025, 10, 7, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2245)
                        },
                        new
                        {
                            Id = 7L,
                            Code = "GE343452734435",
                            DiscountValue = 15m,
                            ExpiryDate = new DateTime(2025, 3, 21, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2247)
                        },
                        new
                        {
                            Id = 8L,
                            Code = "GE343439934435",
                            DiscountValue = 78m,
                            ExpiryDate = new DateTime(2025, 2, 15, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(2251)
                        });
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DiscountValue")
                        .IsDescending();

                    b.HasIndex("OperationDate")
                        .IsDescending();

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.ExchangeRate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Buy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LogTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Sell")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ExchangeRates");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Buy = 2.7m,
                            Currency = "USD",
                            LogTime = new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1854),
                            Sell = 2.8m
                        },
                        new
                        {
                            Id = 2L,
                            Buy = 2.9m,
                            Currency = "EUR",
                            LogTime = new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1870),
                            Sell = 2.85m
                        },
                        new
                        {
                            Id = 3L,
                            Buy = 2.65m,
                            Currency = "GBP",
                            LogTime = new DateTime(2024, 6, 2, 1, 49, 14, 331, DateTimeKind.Local).AddTicks(1871),
                            Sell = 2.85m
                        });
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Notification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NotificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderDate")
                        .IsDescending();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Payment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("paymentMethodId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("paymentMethodId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.PaymentMethod", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("ProductCategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ProductName");

                    b.HasKey("Id");

                    b.HasIndex("Price")
                        .IsDescending();

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductName")
                        .IsDescending();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryName")
                        .IsDescending();

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Receipt", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsCheckedOut")
                        .HasColumnType("bit");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IsCheckedOut")
                        .IsDescending();

                    b.HasIndex("OrderId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.ReceiptDetail", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("ReceiptId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("DiscountUnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ReceiptId");

                    b.HasIndex("DiscountUnitPrice")
                        .IsDescending();

                    b.HasIndex("Quantity")
                        .IsDescending();

                    b.HasIndex("ReceiptId");

                    b.HasIndex("UnitPrice")
                        .IsDescending();

                    b.ToTable("ReceiptDetails");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.ReturnRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("ReturnRequests");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Review", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Shipping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Carrier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrackingNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Shippings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.BonusProgram", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Customer", "Customer")
                        .WithMany("bonuses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Customer", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Person", "Person")
                        .WithOne("Customer")
                        .HasForeignKey("GA.TradeMarket.Domain.Entitites.Customer", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Notification", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Customer", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Order", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Payment", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Order", "Order")
                        .WithMany("payments")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GA.TradeMarket.Domain.Entitites.PaymentMethod", "method")
                        .WithMany("Payments")
                        .HasForeignKey("paymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("method");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Product", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Receipt", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Order", "order")
                        .WithMany("Receipts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.ReceiptDetail", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Product", "Product")
                        .WithMany("ReceiptDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GA.TradeMarket.Domain.Entitites.Receipt", "Receipt")
                        .WithMany("ReceiptDetails")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.ReturnRequest", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Order", "Order")
                        .WithOne("ReturnRequest")
                        .HasForeignKey("GA.TradeMarket.Domain.Entitites.ReturnRequest", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Review", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GA.TradeMarket.Domain.Entitites.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Shipping", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Order", "Order")
                        .WithOne("Shipping")
                        .HasForeignKey("GA.TradeMarket.Domain.Entitites.Shipping", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GA.TradeMarket.Domain.Entitites.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GA.TradeMarket.Domain.Entitites.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Customer", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("bonuses");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Order", b =>
                {
                    b.Navigation("Receipts");

                    b.Navigation("ReturnRequest")
                        .IsRequired();

                    b.Navigation("Shipping")
                        .IsRequired();

                    b.Navigation("payments");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.PaymentMethod", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Person", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Product", b =>
                {
                    b.Navigation("ReceiptDetails");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("GA.TradeMarket.Domain.Entitites.Receipt", b =>
                {
                    b.Navigation("ReceiptDetails");
                });
#pragma warning restore 612, 618
        }
    }
}