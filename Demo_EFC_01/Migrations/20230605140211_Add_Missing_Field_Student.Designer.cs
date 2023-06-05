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
    [Migration("20230605140211_Add_Missing_Field_Student")]
    partial class Add_Missing_Field_Student
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<int>("RegNat")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("StudentId"));

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Contact_Email] IS NOT NULL");

                    b.ToTable("Student", (string)null);

                    b.HasCheckConstraint("CK_Student__Email", "Contact_Email LIKE '%@%'");
                });
#pragma warning restore 612, 618
        }
    }
}