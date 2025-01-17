﻿// <auto-generated />
using System;
using EF_Task2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Task2.Migrations
{
    [DbContext(typeof(Taskcontext))]
    [Migration("20240922154911_v3")]
    partial class v3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Task2.Models.author", b =>
                {
                    b.Property<int>("autId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("autId"));

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<DateTime>("joinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("autId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("EF_Task2.Models.catalog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("EF_Task2.Models.news", b =>
                {
                    b.Property<int>("newId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("newId"));

                    b.Property<int>("authId")
                        .HasColumnType("int");

                    b.Property<string>("bref")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("catId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("descriptionNews")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("time")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("newId");

                    b.HasIndex("authId");

                    b.HasIndex("catId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("EF_Task2.Models.news", b =>
                {
                    b.HasOne("EF_Task2.Models.author", "author")
                        .WithMany("newss")
                        .HasForeignKey("authId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Task2.Models.catalog", "catlog")
                        .WithMany("newss")
                        .HasForeignKey("catId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("catlog");
                });

            modelBuilder.Entity("EF_Task2.Models.author", b =>
                {
                    b.Navigation("newss");
                });

            modelBuilder.Entity("EF_Task2.Models.catalog", b =>
                {
                    b.Navigation("newss");
                });
#pragma warning restore 612, 618
        }
    }
}
