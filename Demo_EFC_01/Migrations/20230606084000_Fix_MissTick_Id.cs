using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EFC_01.Migrations
{
    public partial class Fix_MissTick_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Student_Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Student_Id", "Birth_Date", "Contact_Email", "First_Name", "Gender", "Validate", "Last_Name", "Contact_Number", "RegNat" },
                values: new object[] { 4, new DateTime(1981, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miss", 2, false, "Tick", null, 81030398765L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Student_Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Student_Id", "Birth_Date", "Contact_Email", "First_Name", "Gender", "Validate", "Last_Name", "Contact_Number", "RegNat" },
                values: new object[] { 3, new DateTime(1981, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miss", 2, false, "Tick", null, 81030398765L });
        }
    }
}
