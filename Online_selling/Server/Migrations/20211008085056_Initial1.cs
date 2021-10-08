using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_selling.Server.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Class1Set");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Class1Set",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Class1Set",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Gmail",
                table: "Class1Set",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Class1Set",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gmail",
                table: "Class1Set");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Class1Set");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Class1Set",
                newName: "name");

            migrationBuilder.AlterColumn<int>(
                name: "name",
                table: "Class1Set",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "Class1Set",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
