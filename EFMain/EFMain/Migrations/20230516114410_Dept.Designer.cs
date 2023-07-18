﻿// <auto-generated />
using EFMain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFMain.Migrations
{
    [DbContext(typeof(Company))]
    [Migration("20230516114410_Dept")]
    partial class Dept
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFMain.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DepName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepName = "it",
                            Email = "it@gmail.com"
                        });
                });

            modelBuilder.Entity("EFMain.Models.Employee", b =>
                {
                    b.Property<int>("empId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasMaxLength(10)
                        .HasColumnType("bigint");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("empId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            empId = 1,
                            DepartmentId = 1,
                            Firstname = "Rohit",
                            Lastname = "Gabane",
                            Mobile = 8888421183L,
                            Salary = 570000f
                        },
                        new
                        {
                            empId = 2,
                            DepartmentId = 2,
                            Firstname = "Mayank",
                            Lastname = "Kapoor",
                            Mobile = 9011596791L,
                            Salary = 970000f
                        },
                        new
                        {
                            empId = 3,
                            DepartmentId = 3,
                            Firstname = "Mukunda",
                            Lastname = "Patil",
                            Mobile = 8975463210L,
                            Salary = 670000f
                        },
                        new
                        {
                            empId = 4,
                            DepartmentId = 4,
                            Firstname = "Hrushi",
                            Lastname = "Jawale",
                            Mobile = 7896541283L,
                            Salary = 270000f
                        },
                        new
                        {
                            empId = 5,
                            DepartmentId = 5,
                            Firstname = "Satish",
                            Lastname = "Patil",
                            Mobile = 8965321475L,
                            Salary = 480000f
                        },
                        new
                        {
                            empId = 6,
                            DepartmentId = 6,
                            Firstname = "Suraj",
                            Lastname = "Rana",
                            Mobile = 8521479635L,
                            Salary = 330000f
                        },
                        new
                        {
                            empId = 7,
                            DepartmentId = 7,
                            Firstname = "Aniket",
                            Lastname = "hurde",
                            Mobile = 8632145975L,
                            Salary = 420000f
                        },
                        new
                        {
                            empId = 8,
                            DepartmentId = 8,
                            Firstname = "Akash",
                            Lastname = "Digwa",
                            Mobile = 8965472319L,
                            Salary = 170000f
                        },
                        new
                        {
                            empId = 9,
                            DepartmentId = 9,
                            Firstname = "Sandeep",
                            Lastname = "Chikya",
                            Mobile = 9514783628L,
                            Salary = 530000f
                        },
                        new
                        {
                            empId = 10,
                            DepartmentId = 10,
                            Firstname = "vivek",
                            Lastname = "bhatt",
                            Mobile = 7895463254L,
                            Salary = 630000f
                        });
                });

            modelBuilder.Entity("EFMain.Models.Employee", b =>
                {
                    b.HasOne("EFMain.Models.Department", null)
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFMain.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
