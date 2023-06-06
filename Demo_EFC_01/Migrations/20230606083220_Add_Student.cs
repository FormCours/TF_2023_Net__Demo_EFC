using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EFC_01.Migrations
{
    public partial class Add_Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "RegNat",
                table: "Student",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Student_Id", "Birth_Date", "Contact_Email", "First_Name", "Gender", "Validate", "Last_Name", "Contact_Number", "RegNat" },
                values: new object[] { 1, new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "z.vanderquack@gmail.com", "Zaza", 0, true, "Vanderquack", null, 95053012546L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Student_Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "RegNat",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
