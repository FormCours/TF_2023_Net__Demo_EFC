using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EFC_01.Migrations
{
    public partial class Fix_Zaza_Mail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Student_Id",
                keyValue: 1,
                column: "Contact_Email",
                value: "z.vanderquack@gmail.be");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Student_Id",
                keyValue: 1,
                column: "Contact_Email",
                value: "z.vanderquack@gmail.com");
        }
    }
}
