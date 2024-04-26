﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReadApi.Data;

#nullable disable

namespace ReadApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ReadApi.Models.FeedbackQuestion", b =>
                {
                    b.Property<Guid>("FeedbackQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuestionNo")
                        .HasColumnType("int");

                    b.HasKey("FeedbackQuestionId");

                    b.ToTable("FeedbackQuestions");
                });

            modelBuilder.Entity("ReadApi.Models.FeedbackResponse", b =>
                {
                    b.Property<Guid>("FeedbackResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("FeedbackQuestionId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FeedbackResponseId");

                    b.HasIndex("FeedbackQuestionId");

                    b.ToTable("FeedbackResponses");
                });

            modelBuilder.Entity("ReadApi.Models.QuestionOption", b =>
                {
                    b.Property<Guid>("QuestionOptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Option")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("QuizQuestionId")
                        .HasColumnType("char(36)");

                    b.HasKey("QuestionOptionId");

                    b.HasIndex("QuizQuestionId");

                    b.ToTable("QuestionOptions");
                });

            modelBuilder.Entity("ReadApi.Models.Quiz", b =>
                {
                    b.Property<Guid>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("NameOfQuiz")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PassMark")
                        .HasColumnType("int");

                    b.HasKey("QuizId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("ReadApi.Models.QuizQuestion", b =>
                {
                    b.Property<Guid>("QuizQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuestionNo")
                        .HasColumnType("int");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("char(36)");

                    b.HasKey("QuizQuestionId");

                    b.HasIndex("QuizId");

                    b.ToTable("QuizQuestions");
                });

            modelBuilder.Entity("ReadApi.Models.UserAnswer", b =>
                {
                    b.Property<Guid>("UserAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("QuestionOptionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("QuizQuestionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserAttemptId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserAnswerId");

                    b.HasIndex("QuestionOptionId");

                    b.HasIndex("QuizQuestionId");

                    b.HasIndex("UserAttemptId");

                    b.ToTable("UserAnswers");
                });

            modelBuilder.Entity("ReadApi.Models.UserAttempt", b =>
                {
                    b.Property<Guid>("UserAttemptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AttemptCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<Guid>("QuizId")
                        .HasColumnType("char(36)");

                    b.Property<float>("Score")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserAttemptId");

                    b.HasIndex("QuizId");

                    b.ToTable("UserAttempts");
                });

            modelBuilder.Entity("ReadApi.Models.FeedbackResponse", b =>
                {
                    b.HasOne("ReadApi.Models.FeedbackQuestion", "FeedbackQuestion")
                        .WithMany("FeedbackResponses")
                        .HasForeignKey("FeedbackQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FeedbackQuestion");
                });

            modelBuilder.Entity("ReadApi.Models.QuestionOption", b =>
                {
                    b.HasOne("ReadApi.Models.QuizQuestion", "QuizQuestion")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuizQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuizQuestion");
                });

            modelBuilder.Entity("ReadApi.Models.QuizQuestion", b =>
                {
                    b.HasOne("ReadApi.Models.Quiz", "Quiz")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("ReadApi.Models.UserAnswer", b =>
                {
                    b.HasOne("ReadApi.Models.QuestionOption", "QuestionOption")
                        .WithMany("UserAnswers")
                        .HasForeignKey("QuestionOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadApi.Models.QuizQuestion", "QuizQuestion")
                        .WithMany("UserAnswers")
                        .HasForeignKey("QuizQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReadApi.Models.UserAttempt", "UserAttempt")
                        .WithMany("UserAnswers")
                        .HasForeignKey("UserAttemptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionOption");

                    b.Navigation("QuizQuestion");

                    b.Navigation("UserAttempt");
                });

            modelBuilder.Entity("ReadApi.Models.UserAttempt", b =>
                {
                    b.HasOne("ReadApi.Models.Quiz", "Quiz")
                        .WithMany("UserAttempts")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("ReadApi.Models.FeedbackQuestion", b =>
                {
                    b.Navigation("FeedbackResponses");
                });

            modelBuilder.Entity("ReadApi.Models.QuestionOption", b =>
                {
                    b.Navigation("UserAnswers");
                });

            modelBuilder.Entity("ReadApi.Models.Quiz", b =>
                {
                    b.Navigation("QuizQuestions");

                    b.Navigation("UserAttempts");
                });

            modelBuilder.Entity("ReadApi.Models.QuizQuestion", b =>
                {
                    b.Navigation("QuestionOptions");

                    b.Navigation("UserAnswers");
                });

            modelBuilder.Entity("ReadApi.Models.UserAttempt", b =>
                {
                    b.Navigation("UserAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
