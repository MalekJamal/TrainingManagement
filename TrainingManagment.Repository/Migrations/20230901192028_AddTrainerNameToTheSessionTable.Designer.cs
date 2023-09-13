﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingManagment.Repository.Data;

namespace TrainingManagment.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230901192028_AddTrainerNameToTheSessionTable")]
    partial class AddTrainerNameToTheSessionTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TrainingSystem.Core.Models.Lookup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LookupCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyOn")
                        .HasColumnName("ModifyOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LookupCategoryId");

                    b.ToTable("Lookup");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 100,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "عمل",
                            NameEn = "Work"
                        },
                        new
                        {
                            Id = 2,
                            Code = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 100,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "جامعة",
                            NameEn = "University"
                        },
                        new
                        {
                            Id = 3,
                            Code = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 200,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = ".Net",
                            NameEn = "DotNet"
                        },
                        new
                        {
                            Id = 4,
                            Code = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 200,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "محلل أعمال",
                            NameEn = "BusinessAnalyst"
                        },
                        new
                        {
                            Id = 5,
                            Code = 3,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 200,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "مراقبة الجودة",
                            NameEn = "QualityControl"
                        },
                        new
                        {
                            Id = 6,
                            Code = 4,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 200,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "بنية الأنظمة",
                            NameEn = "Infrastructure"
                        },
                        new
                        {
                            Id = 7,
                            Code = 5,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 200,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "واجهة المستخدم وتجربة المستخدم",
                            NameEn = "UI_UX"
                        },
                        new
                        {
                            Id = 8,
                            Code = 6,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 200,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "الموارد البشرية",
                            NameEn = "HumanResources"
                        },
                        new
                        {
                            Id = 9,
                            Code = 7,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 200,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "المالية",
                            NameEn = "Finance"
                        },
                        new
                        {
                            Id = 10,
                            Code = 8,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 200,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "الذكاء الاصطناعي",
                            NameEn = "AI"
                        },
                        new
                        {
                            Id = 11,
                            Code = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 300,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "نشط",
                            NameEn = "Active"
                        },
                        new
                        {
                            Id = 12,
                            Code = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 300,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "قيد الانتظار",
                            NameEn = "Pending"
                        },
                        new
                        {
                            Id = 13,
                            Code = 3,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 300,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "مكتمل",
                            NameEn = "Finished"
                        },
                        new
                        {
                            Id = 14,
                            Code = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 400,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "الانضمام إلى فريق TPS",
                            NameEn = "Joining_TPS_Team"
                        },
                        new
                        {
                            Id = 15,
                            Code = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 400,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "معلق",
                            NameEn = "On_Hold"
                        },
                        new
                        {
                            Id = 16,
                            Code = 3,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 400,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "مرفوض",
                            NameEn = "Rejected"
                        },
                        new
                        {
                            Id = 17,
                            Code = 4,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            LookupCategoryId = 400,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "استقال",
                            NameEn = "Quit"
                        });
                });

            modelBuilder.Entity("TrainingSystem.Core.Models.LookupCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyOn")
                        .HasColumnName("ModifyOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("LookupCategory");

                    b.HasData(
                        new
                        {
                            CategoryId = 100,
                            Code = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "نوع التدريب",
                            NameEn = "Training Type"
                        },
                        new
                        {
                            CategoryId = 200,
                            Code = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "موضوعات التدريب",
                            NameEn = "Training Topics"
                        },
                        new
                        {
                            CategoryId = 300,
                            Code = 3,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "حالة التدريب",
                            NameEn = "Training Status"
                        },
                        new
                        {
                            CategoryId = 400,
                            Code = 4,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsDeleted = false,
                            ModifyOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameAr = "نتيجة التدريب",
                            NameEn = "Training Result"
                        });
                });

            modelBuilder.Entity("TrainingSystem.Core.Models.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActualEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("EvaluationScore")
                        .HasColumnType("float");

                    b.Property<DateTime>("ExpectedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FinalPresentationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyOn")
                        .HasColumnName("ModifyOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int?>("ResultLookupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("StatusLookupId")
                        .HasColumnType("int");

                    b.Property<string>("TraineeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainerLookupId")
                        .HasColumnType("int");

                    b.Property<int>("TrainerName")
                        .HasColumnType("int");

                    b.Property<int>("TrainingTopic")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingTopicLookupId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingType")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingTypeLookupId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SessionId");

                    b.HasIndex("ResultLookupId");

                    b.HasIndex("StatusLookupId");

                    b.HasIndex("TrainerLookupId");

                    b.HasIndex("TrainingTopicLookupId");

                    b.HasIndex("TrainingTypeLookupId");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("TrainingSystem.Core.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingSystem.Core.Models.Lookup", b =>
                {
                    b.HasOne("TrainingSystem.Core.Models.LookupCategory", "LookupCategory")
                        .WithMany("Lookups")
                        .HasForeignKey("LookupCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingSystem.Core.Models.Session", b =>
                {
                    b.HasOne("TrainingSystem.Core.Models.Lookup", "ResultLookup")
                        .WithMany()
                        .HasForeignKey("ResultLookupId");

                    b.HasOne("TrainingSystem.Core.Models.Lookup", "StatusLookup")
                        .WithMany()
                        .HasForeignKey("StatusLookupId");

                    b.HasOne("TrainingSystem.Core.Models.Lookup", "TrainerLookup")
                        .WithMany()
                        .HasForeignKey("TrainerLookupId");

                    b.HasOne("TrainingSystem.Core.Models.Lookup", "TrainingTopicLookup")
                        .WithMany()
                        .HasForeignKey("TrainingTopicLookupId");

                    b.HasOne("TrainingSystem.Core.Models.Lookup", "TrainingTypeLookup")
                        .WithMany()
                        .HasForeignKey("TrainingTypeLookupId");
                });
#pragma warning restore 612, 618
        }
    }
}
