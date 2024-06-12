﻿// <auto-generated />
using System;
using EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Models.Departnment", b =>
                {
                    b.Property<int>("PkDepartnemtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkDepartnemtId"));

                    b.Property<DateTime>("CretedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartnmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PkDepartnemtId");

                    b.ToTable("Departnment");
                });

            modelBuilder.Entity("Models.Models.Doctor", b =>
                {
                    b.Property<int>("PkDoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkDoctorId"));

                    b.Property<DateTime>("CretedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<int>("FkDepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INT");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.HasKey("PkDoctorId");

                    b.HasIndex("FkDepartmentId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Models.Models.user", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("FKDoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR");

                    b.HasKey("UserId");

                    b.HasIndex("FKDoctorId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Models.Models.Doctor", b =>
                {
                    b.HasOne("Models.Models.Departnment", "Departnment")
                        .WithMany("Doctors")
                        .HasForeignKey("FkDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departnment");
                });

            modelBuilder.Entity("Models.Models.user", b =>
                {
                    b.HasOne("Models.Models.Doctor", "Doctor")
                        .WithMany("Users")
                        .HasForeignKey("FKDoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Models.Models.Departnment", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Models.Models.Doctor", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
