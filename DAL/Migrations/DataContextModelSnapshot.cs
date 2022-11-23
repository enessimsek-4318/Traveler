﻿// <auto-generated />
using System;
using DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Traveler.Entity.Admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("adminId"), 1L, 1);

                    b.Property<string>("adminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adminPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("adminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Traveler.Entity.City", b =>
                {
                    b.Property<int>("cityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cityId"), 1L, 1);

                    b.Property<string>("cityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Traveler.Entity.Comment", b =>
                {
                    b.Property<int>("commentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("commentId"), 1L, 1);

                    b.Property<string>("commentDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("commentId");

                    b.HasIndex("postId");

                    b.HasIndex("userId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Traveler.Entity.Like", b =>
                {
                    b.Property<int>("likeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("likeId"), 1L, 1);

                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("likeId");

                    b.HasIndex("postId");

                    b.HasIndex("userId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Traveler.Entity.Photo", b =>
                {
                    b.Property<int>("photoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("photoId"), 1L, 1);

                    b.Property<string>("photoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.HasKey("photoId");

                    b.HasIndex("postId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Traveler.Entity.Post", b =>
                {
                    b.Property<int>("postId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("postId"), 1L, 1);

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("postDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("postDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("postId");

                    b.HasIndex("cityId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Traveler.Entity.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Traveler.Entity.Comment", b =>
                {
                    b.HasOne("Traveler.Entity.Post", "post")
                        .WithMany()
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveler.Entity.User", "user")
                        .WithMany("comments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("post");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Traveler.Entity.Like", b =>
                {
                    b.HasOne("Traveler.Entity.Post", "post")
                        .WithMany()
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Traveler.Entity.User", "user")
                        .WithMany("likes")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("post");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Traveler.Entity.Photo", b =>
                {
                    b.HasOne("Traveler.Entity.Post", "post")
                        .WithMany("photos")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("post");
                });

            modelBuilder.Entity("Traveler.Entity.Post", b =>
                {
                    b.HasOne("Traveler.Entity.City", "city")
                        .WithMany("posts")
                        .HasForeignKey("cityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("city");
                });

            modelBuilder.Entity("Traveler.Entity.City", b =>
                {
                    b.Navigation("posts");
                });

            modelBuilder.Entity("Traveler.Entity.Post", b =>
                {
                    b.Navigation("photos");
                });

            modelBuilder.Entity("Traveler.Entity.User", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("likes");
                });
#pragma warning restore 612, 618
        }
    }
}
