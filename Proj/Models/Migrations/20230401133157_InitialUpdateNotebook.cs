using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proj.Models.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdateNotebook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Acctive",
                table: "PC",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acctive",
                table: "PC");
        }
    }
}
