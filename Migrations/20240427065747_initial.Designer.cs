﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReadApi.Data;

#nullable disable

namespace ReadApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240427065747_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ReadApi.Models.Course", b =>
                {
                    b.Property<string>("CourseID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("CatagoryID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Duration")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LevelID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Validity")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.HasIndex("CatagoryID");

                    b.HasIndex("LevelID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ReadApi.Models.CourseCatagory", b =>
                {
                    b.Property<string>("CatagoryID")
                        .HasColumnType("varchar(95)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CatagoryID");

                    b.ToTable("CourseCategory");
                });

            modelBuilder.Entity("ReadApi.Models.CourseLevel", b =>
                {
                    b.Property<string>("LevelID")
                        .HasColumnType("varchar(95)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LevelID");

                    b.ToTable("CourseLevels");
                });

            modelBuilder.Entity("ReadApi.Models.Material", b =>
                {
                    b.Property<string>("MaterialID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("CourseID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Filepath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TopicID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MaterialID");

                    b.HasIndex("CourseID");

                    b.HasIndex("TopicID");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("ReadApi.Models.Topic", b =>
                {
                    b.Property<string>("TopicID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("CourseID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TopicID");

                    b.HasIndex("CourseID");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("ReadApi.Models.UserProgress", b =>
                {
                    b.Property<string>("UserProgressID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("CourseID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<bool>("IsWatched")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MaterialID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("TopicID")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<TimeOnly>("TotalTime")
                        .HasColumnType("time(0)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<TimeOnly>("WatchTime")
                        .HasColumnType("time(0)");

                    b.HasKey("UserProgressID");

                    b.HasIndex("CourseID");

                    b.HasIndex("MaterialID");

                    b.HasIndex("TopicID");

                    b.ToTable("UserProgress");
                });

            modelBuilder.Entity("ReadApi.Models.Course", b =>
                {
                    b.HasOne("ReadApi.Models.CourseCatagory", "Catagory")
                        .WithMany("Course")
                        .HasForeignKey("CatagoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadApi.Models.CourseLevel", "Level")
                        .WithMany("Courses")
                        .HasForeignKey("LevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catagory");

                    b.Navigation("Level");
                });

            modelBuilder.Entity("ReadApi.Models.Material", b =>
                {
                    b.HasOne("ReadApi.Models.Course", "Course")
                        .WithMany("Materials")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadApi.Models.Topic", "Topic")
                        .WithMany("Materials")
                        .HasForeignKey("TopicID");

                    b.Navigation("Course");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("ReadApi.Models.Topic", b =>
                {
                    b.HasOne("ReadApi.Models.Course", "Course")
                        .WithMany("Topics")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ReadApi.Models.UserProgress", b =>
                {
                    b.HasOne("ReadApi.Models.Course", "Course")
                        .WithMany("Userprogress")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadApi.Models.Material", "Material")
                        .WithMany("users")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadApi.Models.Topic", "Topic")
                        .WithMany("UsersProgress")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Material");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("ReadApi.Models.Course", b =>
                {
                    b.Navigation("Materials");

                    b.Navigation("Topics");

                    b.Navigation("Userprogress");
                });

            modelBuilder.Entity("ReadApi.Models.CourseCatagory", b =>
                {
                    b.Navigation("Course");
                });

            modelBuilder.Entity("ReadApi.Models.CourseLevel", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ReadApi.Models.Material", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("ReadApi.Models.Topic", b =>
                {
                    b.Navigation("Materials");

                    b.Navigation("UsersProgress");
                });
#pragma warning restore 612, 618
        }
    }
}