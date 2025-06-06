﻿// <auto-generated />
using System;
using BulkyWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240914171636_Addforeignkey")]
    partial class Addforeignkey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BulkyWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Sci-fi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Art"
                        });
                });

            modelBuilder.Entity("BulkyWeb.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("double");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Suzanne Collins",
                            CategoryId = 1,
                            Description = "The Hunger Games is a dystopian novel by Suzanne Collins where teenagers are forced to participate in a deadly televised competition in a totalitarian society.",
                            ISBN = "9780545791878",
                            Price = 499.0,
                            Title = "The Hunger Games"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Frank Herbert",
                            CategoryId = 2,
                            Description = "Dune by Frank Herbert is a science fiction epic set on a desert planet, exploring themes of politics, religion,and ecological survival.",
                            ISBN = "9780425027066",
                            Price = 799.0,
                            Title = "Dune"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Dan Brown",
                            CategoryId = 3,
                            Description = "The Da Vinci Code by Dan Brown is a mystery-thriller that follows a symbologist as he uncovers a hidden religious secret through a series of historical and cryptic clues.",
                            ISBN = "9780385513227",
                            Price = 399.0,
                            Title = "The Da Vinci Code"
                        });
                });

            modelBuilder.Entity("BulkyWeb.Models.Product", b =>
                {
                    b.HasOne("BulkyWeb.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
