using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramming.Migrations.TodoDb
{
    /// <inheritdoc />
    public partial class changeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CprItems",
                table: "CprItems");

            migrationBuilder.RenameTable(
                name: "CprItems",
                newName: "Cprs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cprs",
                table: "Cprs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cprs",
                table: "Cprs");

            migrationBuilder.RenameTable(
                name: "Cprs",
                newName: "CprItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CprItems",
                table: "CprItems",
                column: "Id");
        }
    }
}
