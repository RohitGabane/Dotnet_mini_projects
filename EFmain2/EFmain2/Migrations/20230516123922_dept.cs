﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFmain2.Migrations
{
    /// <inheritdoc />
    public partial class dept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    empId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<long>(type: "bigint", maxLength: 10, nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.empId);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "DepName", "Email" },
                values: new object[,]
                {
                    { 1, "it", "it@gmail.com" },
                    { 2, "it", "it@gmail.com" },
                    { 3, "mkt", "mkt@gmail.com" },
                    { 4, "hr", "it@gmail.com" },
                    { 5, "BA", "it@gmail.com" },
                    { 6, "QA", "it@gmail.com" },
                    { 7, "TA", "it@gmail.com" },
                    { 8, "Comp", "it@gmail.com" },
                    { 9, "Mech", "it@gmail.com" },
                    { 10, "Civil", "it@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "empId", "DepartmentId", "Firstname", "Lastname", "Mobile", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "Rohit", "Gabane", 8888421183L, 570000f },
                    { 2, 2, "Mayank", "Kapoor", 9011596791L, 970000f },
                    { 3, 3, "Mukunda", "Patil", 8975463210L, 670000f },
                    { 4, 4, "Hrushi", "Jawale", 7896541283L, 270000f },
                    { 5, 5, "Satish", "Patil", 8965321475L, 480000f },
                    { 6, 6, "Suraj", "Rana", 8521479635L, 330000f },
                    { 7, 7, "Aniket", "hurde", 8632145975L, 420000f },
                    { 8, 8, "Akash", "Digwa", 8965472319L, 170000f },
                    { 9, 9, "Sandeep", "Chikya", 9514783628L, 530000f },
                    { 10, 10, "vivek", "bhatt", 7895463254L, 630000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
