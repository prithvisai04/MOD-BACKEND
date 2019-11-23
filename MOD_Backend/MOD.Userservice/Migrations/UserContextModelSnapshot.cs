﻿// <auto-generated />
using System;
using MOD.Userservice.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.Userservice.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.Userservice.Models.Mentor", b =>
                {
                    b.Property<string>("Mentorid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentorname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("availability")
                        .HasColumnType("bit");

                    b.Property<string>("timeslot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Mentorid");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Payment", b =>
                {
                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Mentor_Amount")
                        .HasColumnType("int");

                    b.Property<string>("Mentorid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TrainingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PaymentId");

                    b.HasIndex("Mentorid");

                    b.HasIndex("TrainingId");

                    b.HasIndex("UId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Skill", b =>
                {
                    b.Property<string>("SkillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TOC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("fee")
                        .HasColumnType("float");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Trainings", b =>
                {
                    b.Property<string>("TrainingID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<string>("Mentorid")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Progress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<string>("UID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("rating")
                        .HasColumnType("real");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timeslot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingID");

                    b.HasIndex("Mentorid");

                    b.HasIndex("SkillID");

                    b.HasIndex("UID");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("MOD.Userservice.Models.User", b =>
                {
                    b.Property<string>("UId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Payment", b =>
                {
                    b.HasOne("MOD.Userservice.Models.Mentor", "Mentor")
                        .WithMany("Payments")
                        .HasForeignKey("Mentorid");

                    b.HasOne("MOD.Userservice.Models.Trainings", "Training")
                        .WithMany("Payments")
                        .HasForeignKey("TrainingId");

                    b.HasOne("MOD.Userservice.Models.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UId");
                });

            modelBuilder.Entity("MOD.Userservice.Models.Trainings", b =>
                {
                    b.HasOne("MOD.Userservice.Models.Mentor", "Mentor")
                        .WithMany("Training")
                        .HasForeignKey("Mentorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.Userservice.Models.Skill", "Skill")
                        .WithMany("Training")
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.Userservice.Models.User", "User")
                        .WithMany("Training")
                        .HasForeignKey("UID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
