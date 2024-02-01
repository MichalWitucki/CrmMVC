﻿// <auto-generated />
using System;
using CrmMVC.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrmMVC.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrmMVC.Domain.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("VoivodeshipId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("VoivodeshipId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.CompanyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Biuro Projekotwe"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Wykonawca"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Zamawiający"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Dealer"
                        },
                        new
                        {
                            Id = 5,
                            Type = "Inny"
                        });
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ContactPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("RoleId");

                    b.ToTable("ContactPeople");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.PersonRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Role = "Przedstawiciel"
                        },
                        new
                        {
                            Id = 2,
                            Role = "Handlowiec"
                        },
                        new
                        {
                            Id = 3,
                            Role = "Projektant"
                        },
                        new
                        {
                            Id = 4,
                            Role = "Asystent"
                        },
                        new
                        {
                            Id = 5,
                            Role = "Kierownik"
                        },
                        new
                        {
                            Id = 6,
                            Role = "Dyrektor"
                        },
                        new
                        {
                            Id = 7,
                            Role = "Doradca"
                        },
                        new
                        {
                            Id = 8,
                            Role = "Właściciel"
                        },
                        new
                        {
                            Id = 9,
                            Role = "Inna"
                        });
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CatalogueNumber")
                        .HasColumnType("int");

                    b.Property<int>("DiameterId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOfferItem")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPipe")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.Property<double>("WeightPerUnitInKg")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DiameterId");

                    b.HasIndex("UnitId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProductDiameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diameter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductDiameters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Diameter = "100"
                        },
                        new
                        {
                            Id = 2,
                            Diameter = "150"
                        },
                        new
                        {
                            Id = 3,
                            Diameter = "200"
                        },
                        new
                        {
                            Id = 4,
                            Diameter = "250"
                        },
                        new
                        {
                            Id = 5,
                            Diameter = "300"
                        },
                        new
                        {
                            Id = 6,
                            Diameter = "400"
                        },
                        new
                        {
                            Id = 7,
                            Diameter = "500"
                        },
                        new
                        {
                            Id = 8,
                            Diameter = "600"
                        },
                        new
                        {
                            Id = 9,
                            Diameter = "800"
                        });
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProductInProject", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("ProjectId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsInProjects");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProductUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductUnits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Unit = "M."
                        },
                        new
                        {
                            Id = 2,
                            Unit = "SZT."
                        });
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContractorId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<int?>("EngineeringOfficeId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IssuingAgencyId")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("TenderText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("VoivodeshipId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContractorId");

                    b.HasIndex("EngineeringOfficeId");

                    b.HasIndex("IssuingAgencyId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.HasIndex("VoivodeshipId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProjectStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Nowy"
                        },
                        new
                        {
                            Id = 2,
                            Status = "W opracowaniu"
                        },
                        new
                        {
                            Id = 3,
                            Status = "Planowany"
                        },
                        new
                        {
                            Id = 4,
                            Status = "Zapytanie"
                        },
                        new
                        {
                            Id = 5,
                            Status = "Zgłoszony"
                        },
                        new
                        {
                            Id = 6,
                            Status = "Zrealizowany"
                        },
                        new
                        {
                            Id = 7,
                            Status = "Utracony"
                        },
                        new
                        {
                            Id = 8,
                            Status = "Nie dotyczy"
                        },
                        new
                        {
                            Id = 9,
                            Status = "Zdublowany"
                        });
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProjectType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Projektuj"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Buduj"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Projektuj i buduj"
                        });
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Voivodeship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Voivodeships");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Donośląskie"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kujawsko-Pomorskie"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lubelskie"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lubuskie"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Łódzkie"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Małopolskie"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Mazowieckie"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Opolskie"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Podkarpackie"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Podlaskie"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Pomorskie"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Śląskie"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Świętokrzyskie"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Warmińsko-Mazurskie"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Wielkopolskie"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Zachodniopomorskie"
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Company", b =>
                {
                    b.HasOne("CrmMVC.Domain.Model.CompanyType", "Type")
                        .WithMany("Companies")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrmMVC.Domain.Model.Voivodeship", "Voivodeship")
                        .WithMany("Companies")
                        .HasForeignKey("VoivodeshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");

                    b.Navigation("Voivodeship");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ContactPerson", b =>
                {
                    b.HasOne("CrmMVC.Domain.Model.Company", "Company")
                        .WithMany("ContactPeople")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrmMVC.Domain.Model.PersonRole", "Role")
                        .WithMany("ContactPeople")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Product", b =>
                {
                    b.HasOne("CrmMVC.Domain.Model.ProductDiameter", "Diameter")
                        .WithMany("Products")
                        .HasForeignKey("DiameterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrmMVC.Domain.Model.ProductUnit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diameter");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProductInProject", b =>
                {
                    b.HasOne("CrmMVC.Domain.Model.Product", "Product")
                        .WithMany("ProductsInProjects")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrmMVC.Domain.Model.Project", "Project")
                        .WithMany("ProductsInProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Project", b =>
                {
                    b.HasOne("CrmMVC.Domain.Model.Company", "Contractor")
                        .WithMany("InProjecAsContractor")
                        .HasForeignKey("ContractorId");

                    b.HasOne("CrmMVC.Domain.Model.Company", "EngineeringOffice")
                        .WithMany("InProjecAsEngineeringOffice")
                        .HasForeignKey("EngineeringOfficeId");

                    b.HasOne("CrmMVC.Domain.Model.Company", "IssuingAgency")
                        .WithMany("InProjecAsIssuinAgency")
                        .HasForeignKey("IssuingAgencyId");

                    b.HasOne("CrmMVC.Domain.Model.ProjectStatus", "Status")
                        .WithMany("Projects")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrmMVC.Domain.Model.ProjectType", "Type")
                        .WithMany("Projects")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrmMVC.Domain.Model.Voivodeship", "Voivodeship")
                        .WithMany("Projects")
                        .HasForeignKey("VoivodeshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contractor");

                    b.Navigation("EngineeringOffice");

                    b.Navigation("IssuingAgency");

                    b.Navigation("Status");

                    b.Navigation("Type");

                    b.Navigation("Voivodeship");
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

            modelBuilder.Entity("CrmMVC.Domain.Model.Company", b =>
                {
                    b.Navigation("ContactPeople");

                    b.Navigation("InProjecAsContractor");

                    b.Navigation("InProjecAsEngineeringOffice");

                    b.Navigation("InProjecAsIssuinAgency");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.CompanyType", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.PersonRole", b =>
                {
                    b.Navigation("ContactPeople");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Product", b =>
                {
                    b.Navigation("ProductsInProjects");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProductDiameter", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProductUnit", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Project", b =>
                {
                    b.Navigation("ProductsInProjects");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProjectStatus", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.ProjectType", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("CrmMVC.Domain.Model.Voivodeship", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
