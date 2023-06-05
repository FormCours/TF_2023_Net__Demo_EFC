using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EFC_01.Migrations
{
    public partial class Fix_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_TFTIC",
                table: "Student_TFTIC");

            migrationBuilder.DropIndex(
                name: "IX_Student_TFTIC_Email",
                table: "Student_TFTIC");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Student__Email",
                table: "Student_TFTIC");

            migrationBuilder.RenameTable(
                name: "Student_TFTIC",
                newName: "Student");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Student",
                newName: "Contact_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Student_Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Contact_Email",
                table: "Student",
                column: "Contact_Email",
                unique: true,
                filter: "[Contact_Email] IS NOT NULL");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Student__Email",
                table: "Student",
                sql: "Contact_Email LIKE '%@%'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Contact_Email",
                table: "Student");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Student__Email",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Student_TFTIC");

            migrationBuilder.RenameColumn(
                name: "Contact_Email",
                table: "Student_TFTIC",
                newName: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_TFTIC",
                table: "Student_TFTIC",
                column: "Student_Id")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_TFTIC_Email",
                table: "Student_TFTIC",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Student__Email",
                table: "Student_TFTIC",
                sql: "Email LIKE '%@%'");
        }
    }
}
