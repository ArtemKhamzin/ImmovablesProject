﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sem.Models;

namespace Sem.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211225131708_Photo")]
    partial class Photo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Sem.Models.Immovable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<byte>("NumberOfRooms")
                        .HasColumnType("smallint");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoomArea")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SaleOrRent")
                        .HasColumnType("integer");

                    b.Property<string>("TypeOfImmovable")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Immovables");
                });

            modelBuilder.Entity("Sem.Models.Mortgage", b =>
                {
                    b.Property<int>("MortgageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bank")
                        .HasColumnType("text");

                    b.Property<int>("MonthlyPayment")
                        .HasColumnType("integer");

                    b.Property<int>("MortgageRate")
                        .HasColumnType("integer");

                    b.Property<byte>("Term")
                        .HasColumnType("smallint");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("MortgageId");

                    b.HasIndex("UserId");

                    b.ToTable("Mortgages");
                });

            modelBuilder.Entity("Sem.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ImmovableId")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RentBegin")
                        .HasColumnType("date");

                    b.Property<DateTime>("RentEnd")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ImmovableId");

                    b.HasIndex("UserId");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("Sem.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ImmovableId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PostingDate")
                        .HasColumnType("date");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ImmovableId");

                    b.HasIndex("UserId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Sem.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(20)");

                    b.Property<byte>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Surname")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Sem.Models.Mortgage", b =>
                {
                    b.HasOne("Sem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sem.Models.Rent", b =>
                {
                    b.HasOne("Sem.Models.Immovable", "Immovable")
                        .WithMany()
                        .HasForeignKey("ImmovableId");

                    b.HasOne("Sem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Immovable");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sem.Models.Sale", b =>
                {
                    b.HasOne("Sem.Models.Immovable", "Immovable")
                        .WithMany("Sales")
                        .HasForeignKey("ImmovableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Immovable");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sem.Models.Immovable", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
