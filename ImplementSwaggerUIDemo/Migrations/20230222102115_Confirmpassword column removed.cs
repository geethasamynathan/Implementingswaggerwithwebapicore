using Microsoft.EntityFrameworkCore.Migrations;

namespace ImplementSwaggerUIDemo.Migrations
{
    public partial class Confirmpasswordcolumnremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
