using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFsecond.Migrations
{
    /// <inheritdoc />
    public partial class StoreDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Store2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Store1",
                columns: table => new
                {
                    Store1tId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dateopening = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store1", x => x.Store1tId);
                    table.ForeignKey(
                        name: "FK_Store1_Store2_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store2",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Store1_StoreId",
                table: "Store1",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Store1");

            migrationBuilder.DropTable(
                name: "Store2");
        }
    }
}
