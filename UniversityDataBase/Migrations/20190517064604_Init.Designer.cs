﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UniversityDataBase.Models;

namespace UniversityDataBase.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20190517064604_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("UniversityDataBase.Models.Cafedra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Cafedras");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("StudentId");

                    b.Property<int>("TeacherId");

                    b.Property<string>("Theme")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Diplomas");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BeginDate");

                    b.Property<int>("CafedraId");

                    b.Property<int>("Hours");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Semester");

                    b.Property<int>("Stage");

                    b.Property<int>("TeacherId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CafedraId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Disertation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TeacherId");

                    b.Property<string>("Theme")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Disertations");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("UniversityDataBase.Models.FacultyCafedra", b =>
                {
                    b.Property<int>("CafedraId");

                    b.Property<int>("FacultyId");

                    b.HasKey("CafedraId", "FacultyId");

                    b.HasIndex("FacultyId");

                    b.ToTable("FacultyCafedras");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Group", b =>
                {
                    b.Property<int>("GroupNum")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BeginYear");

                    b.Property<int>("FacultyId");

                    b.Property<int>("Stage");

                    b.HasKey("GroupNum");

                    b.HasIndex("FacultyId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("UniversityDataBase.Models.GroupsDisciplines", b =>
                {
                    b.Property<int>("GroupId");

                    b.Property<int>("DisciplineId");

                    b.HasKey("GroupId", "DisciplineId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("GroupsDisciplines");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Journal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DisciplineId");

                    b.Property<int>("Mark");

                    b.Property<int>("SessionId");

                    b.Property<int>("StudentId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("SessionId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Journals");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<int>("Award");

                    b.Property<DateTime>("Birth");

                    b.Property<bool>("Child");

                    b.Property<int>("GroupNum");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<char>("Sex");

                    b.HasKey("Id");

                    b.HasIndex("GroupNum");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("Birth");

                    b.Property<int>("CafedraId");

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<int>("Childs");

                    b.Property<int>("FacultyId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Salary");

                    b.Property<char>("Sex");

                    b.HasKey("Id");

                    b.HasIndex("CafedraId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("UniversityDataBase.Models.Diploma", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Student", "Student")
                        .WithMany("Diplomas")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniversityDataBase.Models.Teacher", "Teacher")
                        .WithMany("Diplomas")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniversityDataBase.Models.Discipline", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Cafedra", "Cafedra")
                        .WithMany("Disciplines")
                        .HasForeignKey("CafedraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniversityDataBase.Models.Teacher", "Teacher")
                        .WithMany("Disciplines")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniversityDataBase.Models.Disertation", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Teacher", "Teacher")
                        .WithMany("Disertations")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniversityDataBase.Models.FacultyCafedra", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Cafedra", "Cafedra")
                        .WithMany("FacultyCafedras")
                        .HasForeignKey("CafedraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniversityDataBase.Models.Faculty", "Faculty")
                        .WithMany("FacultyCafedras")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniversityDataBase.Models.Group", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniversityDataBase.Models.GroupsDisciplines", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Discipline", "Discipline")
                        .WithMany("GroupsDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniversityDataBase.Models.Group", "Group")
                        .WithMany("GroupsDisciplines")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniversityDataBase.Models.Journal", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Discipline", "Discipline")
                        .WithMany("Journals")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniversityDataBase.Models.Session", "Session")
                        .WithMany("Journals")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniversityDataBase.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniversityDataBase.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniversityDataBase.Models.Student", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupNum")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniversityDataBase.Models.Teacher", b =>
                {
                    b.HasOne("UniversityDataBase.Models.Cafedra", "Cafedra")
                        .WithMany("Teachers")
                        .HasForeignKey("CafedraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniversityDataBase.Models.Faculty", "Faculty")
                        .WithMany("Teachers")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
