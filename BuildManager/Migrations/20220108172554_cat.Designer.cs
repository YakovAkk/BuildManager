﻿// <auto-generated />
using System;
using BuildManager.Data.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BuildManager.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20220108172554_cat")]
    partial class cat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BuildManager.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BuildManager.Data.Models.DataMaterial", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("dateDeal")
                        .HasColumnType("datetime2");

                    b.Property<int>("material_id")
                        .HasColumnType("int");

                    b.Property<int>("materialid")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("materialid");

                    b.HasIndex("userid");

                    b.ToTable("DataMaterials");
                });

            modelBuilder.Entity("BuildManager.Data.Models.DataPerson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("dateDeal")
                        .HasColumnType("datetime2");

                    b.Property<int>("person_id")
                        .HasColumnType("int");

                    b.Property<int>("personid")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personid");

                    b.HasIndex("userid");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BuildManager.Data.Models.JobPerson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("JobPeople");
                });

            modelBuilder.Entity("BuildManager.Data.Models.Material", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("mesurableValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("BuildManager.Data.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("dataMaterial_id")
                        .HasColumnType("int");

                    b.Property<int>("dataPerson")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BuildManager.Data.Models.DataMaterial", b =>
                {
                    b.HasOne("BuildManager.Data.Models.Material", "material")
                        .WithMany()
                        .HasForeignKey("materialid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildManager.Data.Models.User", "user")
                        .WithMany("dataMaterial")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("material");

                    b.Navigation("user");
                });

            modelBuilder.Entity("BuildManager.Data.Models.DataPerson", b =>
                {
                    b.HasOne("BuildManager.Data.Models.JobPerson", "person")
                        .WithMany()
                        .HasForeignKey("personid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildManager.Data.Models.User", "user")
                        .WithMany("dataPeople")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("person");

                    b.Navigation("user");
                });

            modelBuilder.Entity("BuildManager.Data.Models.Material", b =>
                {
                    b.HasOne("BuildManager.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BuildManager.Data.Models.User", b =>
                {
                    b.Navigation("dataMaterial");

                    b.Navigation("dataPeople");
                });
#pragma warning restore 612, 618
        }
    }
}
