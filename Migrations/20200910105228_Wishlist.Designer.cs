﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValkyraECommerce.DataBase;

namespace ValkyraECommerce.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20200910105228_Wishlist")]
    partial class Wishlist
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<DateTime>("Created");

                    b.Property<int>("CustomerBasketId");

                    b.Property<int?>("ProductId");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CustomerBasketId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressType");

                    b.Property<int?>("CountryId");

                    b.Property<DateTime>("Created");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAddresses");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerBasket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("CustomerId");

                    b.Property<decimal>("TotalGrossAmount");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerBaskets");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerOrders");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerWebAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.Property<bool>("Verified");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("WebAccounts");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerWebToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("CustomerWebAccountId");

                    b.Property<DateTime>("Expire");

                    b.Property<string>("Token");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CustomerWebAccountId");

                    b.ToTable("CustomerWebTokens");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerWishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("CustomerWebAccountId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CustomerWebAccountId");

                    b.ToTable("CustomerWishLists");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.EmailValidation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("CustomerWebAccountId");

                    b.Property<DateTime>("ExpiredDate");

                    b.Property<DateTime>("Updated");

                    b.Property<Guid>("ValidationId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerWebAccountId");

                    b.ToTable("EmailValidations");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.ShopProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("ShopProducts");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.ShopUILanguageItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CtrlName");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("ShopUILanguageItems");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.WishListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int?>("CustomerWishListId");

                    b.Property<int?>("ShopProductId");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CustomerWishListId");

                    b.HasIndex("ShopProductId");

                    b.ToTable("WishListItem");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.BasketItem", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.CustomerBasket", "CustomerBasket")
                        .WithMany("BasketItems")
                        .HasForeignKey("CustomerBasketId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.ShopProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerAddress", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerBasket", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerOrder", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerWebAccount", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerWebToken", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.CustomerWebAccount", "CustomerWebAccount")
                        .WithMany()
                        .HasForeignKey("CustomerWebAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.CustomerWishList", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.CustomerWebAccount", "CustomerWebAccount")
                        .WithMany()
                        .HasForeignKey("CustomerWebAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.EmailValidation", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.CustomerWebAccount", "CustomerWebAccount")
                        .WithMany()
                        .HasForeignKey("CustomerWebAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.ShopUILanguageItem", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("ValkyraECommerce.DatabaseDto.Shop.WishListItem", b =>
                {
                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.CustomerWishList")
                        .WithMany("WishListItems")
                        .HasForeignKey("CustomerWishListId");

                    b.HasOne("ValkyraECommerce.DatabaseDto.Shop.ShopProduct", "ShopProduct")
                        .WithMany()
                        .HasForeignKey("ShopProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
