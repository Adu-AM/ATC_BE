﻿// <auto-generated />
using System;
using ATC_BE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ATC_BE.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ATC_BE.Models.BuildingModel", b =>
                {
                    b.Property<int>("BuildingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuildingId"), 1L, 1);

                    b.Property<string>("BuildingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FloorCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuildingId");

                    b.ToTable("BuildingModels");
                });

            modelBuilder.Entity("ATC_BE.Models.DeskModel", b =>
                {
                    b.Property<int>("DeskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeskId"), 1L, 1);

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Vacancy")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("DeskId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("UserEmail")
                        .IsUnique()
                        .HasFilter("[UserEmail] IS NOT NULL");

                    b.ToTable("DeskModels");
                });

            modelBuilder.Entity("ATC_BE.Models.OfficeModel", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfficeId"), 1L, 1);

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<string>("BuildingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("OfficeAdmin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalDeskCount")
                        .HasColumnType("int");

                    b.Property<int>("UsableDeskCount")
                        .HasColumnType("int");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("OfficeId");

                    b.HasIndex("BuildingId");

                    b.ToTable("OfficeModels");
                });

            modelBuilder.Entity("ATC_BE.Models.RequestRemoteModel", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"), 1L, 1);

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RemotePercentage")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RequestId");

                    b.HasIndex("UserEmail");

                    b.ToTable("RequestRemoteModel");
                });

            modelBuilder.Entity("ATC_BE.Models.UserModel", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("Date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(24)");

                    b.Property<int>("RemotePercentage")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Email");

                    b.ToTable("UserDetails");

                    b.HasData(
                        new
                        {
                            Email = "admin@example.com",
                            AccountId = "1",
                            AccountStatus = "Active",
                            BirthDate = new DateTime(1990, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Corina",
                            Gender = "Female",
                            LastName = "Popescu",
                            Nationality = "Romanian",
                            RemotePercentage = 0,
                            Role = "Administrator"
                        },
                        new
                        {
                            Email = "office@example.com",
                            AccountId = "2",
                            AccountStatus = "Active",
                            BirthDate = new DateTime(1985, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Matei",
                            Gender = "Male",
                            LastName = "Ionescu",
                            Nationality = "British",
                            RemotePercentage = 0,
                            Role = "OfficeAdministrator"
                        },
                        new
                        {
                            Email = "employee@example.com",
                            AccountId = "3",
                            AccountStatus = "Active",
                            BirthDate = new DateTime(1995, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mirela",
                            Gender = "Female",
                            LastName = "Pavaliuc",
                            Nationality = "Romanian",
                            RemotePercentage = 0,
                            Role = "Employee"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "c98b2fae-026a-427c-9f85-82146e7fe78f",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "152c5394-ad3b-40e8-9ea2-f09d05bec211",
                            Name = "OfficeAdministrator",
                            NormalizedName = "OFFICEADMINISTRATOR"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "e5f3e7fa-6dda-4905-b2a5-2f75eb7399c1",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

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

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0a421d8b-cbef-4375-a42e-95b0e937ca76",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENXrZ1bo4Y2v0vzdUKEsCoV8XV5YsuPmy3NzlGVRZ0EWWXJSN+nwv0U7NcsD8OvzgQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c1337d10-1644-4b62-973e-cfee1283c23a",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "179dbaf3-0c93-4590-948f-0183566b645c",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "OFFICE@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEG5IaS5vResdL18Y5KJpqDUWHwOm/dCRYeDbeuE23E1A2DndIiI+yqDeg+VJxQ7ujg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fe831e33-8949-4050-bd99-34f022f345b8",
                            TwoFactorEnabled = false,
                            UserName = "office@example.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "66ba23a2-4ba6-4ccf-810c-d63ffceb268f",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "EMPLOYEE@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEF0PnBq8svEuvIYjaZwpWnjwkUQQYBGAqBkldqwynSfB23IKiat8I+Z1kgQJwERjHA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e736cb46-9d10-4d79-a64d-fb1df796238b",
                            TwoFactorEnabled = false,
                            UserName = "employee@example.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        });
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

            modelBuilder.Entity("ATC_BE.Models.DeskModel", b =>
                {
                    b.HasOne("ATC_BE.Models.OfficeModel", "Office")
                        .WithMany("DeskList")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ATC_BE.Models.UserModel", "User")
                        .WithOne("Desk")
                        .HasForeignKey("ATC_BE.Models.DeskModel", "UserEmail");

                    b.Navigation("Office");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ATC_BE.Models.OfficeModel", b =>
                {
                    b.HasOne("ATC_BE.Models.BuildingModel", "Building")
                        .WithMany("OfficeList")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("ATC_BE.Models.RequestRemoteModel", b =>
                {
                    b.HasOne("ATC_BE.Models.UserModel", "User")
                        .WithMany("RemoteRequests")
                        .HasForeignKey("UserEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ATC_BE.Models.BuildingModel", b =>
                {
                    b.Navigation("OfficeList");
                });

            modelBuilder.Entity("ATC_BE.Models.OfficeModel", b =>
                {
                    b.Navigation("DeskList");
                });

            modelBuilder.Entity("ATC_BE.Models.UserModel", b =>
                {
                    b.Navigation("Desk");

                    b.Navigation("RemoteRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
