using Demo_EFC_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFC_01.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PerishableProduct> PerishableProducts { get; set; }
        public DbSet<ClothingProduct> ClothingProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=Forma300\TFTIC;Initial Catalog=Demo_EFC_01;Persist Security Info=True;Trusted_Connection=True"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Config Fluent-API
            #region Student
            modelBuilder.Entity<Student>()
                .ToTable("Student");
            // - Id
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentId)
                .IsClustered();
            modelBuilder.Entity<Student>()
                .Property(s => s.StudentId)
                .HasColumnName("Student_Id")
                .ValueGeneratedOnAdd();
            // - Name
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .HasColumnName("First_Name")
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .HasColumnName("Last_Name")
                .HasMaxLength(50)
                .IsRequired();
            // - Email
            modelBuilder.Entity<Student>()
                .Property(s => s.Email)
                .HasColumnName("Contact_Email")
                .HasMaxLength(250);
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.Email)
                .IsUnique();
            modelBuilder.Entity<Student>()
                .HasCheckConstraint("CK_Student__Email", "Contact_Email LIKE '%@%'");
            // - PhoneNumber
            modelBuilder.Entity<Student>()
                .Property(s => s.PhoneNumber)
                .HasColumnName("Contact_Number");
            // - BirthDate
            modelBuilder.Entity<Student>()
                .Property(s => s.BirthDate)
                .HasColumnName("Birth_Date");
            // - IsValidate
            modelBuilder.Entity<Student>()
                .Property(s => s.IsValidate)
                .HasColumnName("Validate");

            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 1,
                    FirstName = "Zaza",
                    LastName = "Vanderquack",
                    BirthDate = new DateTime(1995, 5, 30),
                    Email = "z.vanderquack@gmail.be",
                    Gender = StudentGender.F,
                    IsValidate = true,
                    RegNat = 95053012546
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Balthazar",
                    LastName = "Picsou",
                    BirthDate = new DateTime(1960, 9, 1),
                    Email = "b.picsou@gmail.com",
                    Gender = StudentGender.M,
                    IsValidate = true,
                    RegNat = 60060112345
                },
                new Student
                {
                    StudentId = 4,
                    FirstName = "Miss",
                    LastName = "Tick",
                    BirthDate = new DateTime(1981, 3, 3),
                    Gender = StudentGender.X,
                    IsValidate = false,
                    RegNat = 81030398765
                });

            #endregion

            #region Product
            modelBuilder.Entity<Product>()
                .ToTable("Product");
            // - Product: Id
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>()
                .Property(p => p.ProductId)
                .HasColumnName("Product_Id")
                .ValueGeneratedOnAdd();
            // - PerishableProduct: Limit_Date
            modelBuilder.Entity<PerishableProduct>()
                .Property(pp => pp.LimitDate)
                .HasColumnName("Limit_Date");
            #endregion
        }
    }
}
