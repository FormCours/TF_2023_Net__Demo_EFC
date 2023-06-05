using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EFC_01.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student_TFTIC",
                columns: table => new
                {
                    Student_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Contact_Number = table.Column<int>(type: "int", nullable: true),
                    Birth_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Validate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_TFTIC", x => x.Student_Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.CheckConstraint("CK_Student__Email", "Email LIKE '%@%'");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_TFTIC_Email",
                table: "Student_TFTIC",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_TFTIC");
        }
    }
}
