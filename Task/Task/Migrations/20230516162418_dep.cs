using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.Migrations
{
    /// <inheritdoc />
    public partial class dep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_emp",
                table: "emp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dep",
                table: "Dep");

            migrationBuilder.RenameTable(
                name: "emp",
                newName: "Emps");

            migrationBuilder.RenameTable(
                name: "Dep",
                newName: "Deps");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emps",
                table: "Emps",
                column: "empid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deps",
                table: "Deps",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emps",
                table: "Emps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deps",
                table: "Deps");

            migrationBuilder.RenameTable(
                name: "Emps",
                newName: "emp");

            migrationBuilder.RenameTable(
                name: "Deps",
                newName: "Dep");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emp",
                table: "emp",
                column: "empid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dep",
                table: "Dep",
                column: "Id");
        }
    }
}
