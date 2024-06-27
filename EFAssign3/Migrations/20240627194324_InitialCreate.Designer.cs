﻿// <auto-generated />
using System;
using EFAssign3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFAssign3.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240627194324_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("EFAssign3.Entities.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BlogTypeId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BlogTypeId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EFAssign3.Entities.BlogType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("BlogTypes");
                });

            modelBuilder.Entity("EFAssign3.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BlogId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PostTypeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("PostTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EFAssign3.Entities.PostType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PostTypes");
                });

            modelBuilder.Entity("EFAssign3.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFAssign3.Entities.Blog", b =>
                {
                    b.HasOne("EFAssign3.Entities.BlogType", "BlogType")
                        .WithMany("Blogs")
                        .HasForeignKey("BlogTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogType");
                });

            modelBuilder.Entity("EFAssign3.Entities.Post", b =>
                {
                    b.HasOne("EFAssign3.Entities.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFAssign3.Entities.PostType", "PostType")
                        .WithMany("Posts")
                        .HasForeignKey("PostTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFAssign3.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("PostType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFAssign3.Entities.Blog", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("EFAssign3.Entities.BlogType", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EFAssign3.Entities.PostType", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("EFAssign3.Entities.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
