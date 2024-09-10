﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagement.DB;

#nullable disable

namespace SchoolManagement.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240910104328_schoolDb")]
    partial class schoolDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolManagement.Models.School", b =>
                {
                    b.Property<int>("StId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StId"));

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StId");

                    b.ToTable("Schools");
                });
#pragma warning restore 612, 618
        }
    }
}