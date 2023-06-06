using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EFC_01.Migrations
{
    public partial class Add_More_Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Student_Id", "Birth_Date", "Contact_Email", "First_Name", "Gender", "Validate", "Last_Name", "Contact_Number", "RegNat" },
                values: new object[] { 2, new DateTime(1960, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b.picsou@gmail.com", "Balthazar", 1, true, "Picsou", null, 60060112345L });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Student_Id", "Birth_Date", "Contact_Email", "First_Name", "Gender", "Validate", "Last_Name", "Contact_Number", "RegNat" },
                values: new object[] { 3, new DateTime(1981, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miss", 2, false, "Tick", null, 81030398765L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Student_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Student_Id",
                keyValue: 3);
        }
    }
}
