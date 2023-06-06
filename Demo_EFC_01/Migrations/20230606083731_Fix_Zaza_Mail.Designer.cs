﻿// <auto-generated />
using System;
using Demo_EFC_01.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo_EFC_01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230606083731_Fix_Zaza_Mail")]
    partial class Fix_Zaza_Mail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Demo_EFC_01.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Product_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Product", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("Demo_EFC_01.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Student_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Birth_Date");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Contact_Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("First_Name");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsValidate")
                        .HasColumnType("bit")
                        .HasColumnName("Validate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Last_Name");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int")
                        .HasColumnName("Contact_Number");

                    b.Property<long>("RegNat")
                        .HasColumnType("bigint");

                    b.HasKey("StudentId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("StudentId"));

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Contact_Email] IS NOT NULL");

                    b.ToTable("Student", (string)null);

                    b.HasCheckConstraint("CK_Student__Email", "Contact_Email LIKE '%@%'");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            BirthDate = new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "z.vanderquack@gmail.be",
                            FirstName = "Zaza",
                            Gender = 0,
                            IsValidate = true,
                            LastName = "Vanderquack",
                            RegNat = 95053012546L
                        },
                        new
                        {
                            StudentId = 2,
                            BirthDate = new DateTime(1960, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "b.picsou@gmail.com",
                            FirstName = "Balthazar",
                            Gender = 1,
                            IsValidate = true,
                            LastName = "Picsou",
                            RegNat = 60060112345L
                        },
                        new
                        {
                            StudentId = 3,
                            BirthDate = new DateTime(1981, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Miss",
                            Gender = 2,
                            IsValidate = false,
                            LastName = "Tick",
                            RegNat = 81030398765L
                        });
                });

            modelBuilder.Entity("Demo_EFC_01.Models.ClothingProduct", b =>
                {
                    b.HasBaseType("Demo_EFC_01.Models.Product");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ClothingProduct");
                });

            modelBuilder.Entity("Demo_EFC_01.Models.PerishableProduct", b =>
                {
                    b.HasBaseType("Demo_EFC_01.Models.Product");

                    b.Property<DateTime>("LimitDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Limit_Date");

                    b.HasDiscriminator().HasValue("PerishableProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
