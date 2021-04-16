﻿// <auto-generated />
using System;
using DollsWorld.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DollsWorld.DataLayer.Migrations
{
    [DbContext(typeof(DollsWorldContext))]
    [Migration("20210326132652_mig-2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseImageName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CoursePrice")
                        .HasColumnType("int");

                    b.Property<string>("CourseTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DemoFileName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("SubGroup")
                        .HasColumnType("int");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.HasIndex("GroupId");

                    b.HasIndex("LevelId");

                    b.HasIndex("StatusId");

                    b.HasIndex("SubGroup");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseComment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(700)")
                        .HasMaxLength(700);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdminRead")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseComments");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseEpisode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("EpisodeTime")
                        .HasColumnType("time");

                    b.Property<string>("EpisodeTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.HasKey("EpisodeId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseEpisodes");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.HasIndex("ParentId");

                    b.ToTable("CourseGroups");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseLevel", b =>
                {
                    b.Property<int>("LevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LevelTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("LevelId");

                    b.ToTable("CourseLevels");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("StatusId");

                    b.ToTable("CourseStatuses");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseVote", b =>
                {
                    b.Property<int>("VoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("Vote")
                        .HasColumnType("bit");

                    b.Property<DateTime>("VoteDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VoteId");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseVotes");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.UserCourse", b =>
                {
                    b.Property<int>("UC_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UC_Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCourses");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Order.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiscountCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("DiscountPercent")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsableCount")
                        .HasColumnType("int");

                    b.HasKey("DiscountId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Order.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFinaly")
                        .HasColumnType("bit");

                    b.Property<int>("OrderSum")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Order.OrderDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.HasIndex("CourseId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Permissions.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.Property<string>("PermissionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("PermissionId");

                    b.HasIndex("ParentID");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Permissions.RolePermission", b =>
                {
                    b.Property<int>("RP_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("RP_Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermission");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.User.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveCode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAvatar")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.User.UserDiscountCode", b =>
                {
                    b.Property<int>("UD_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UD_Id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDiscountCodes");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.User.UserRole", b =>
                {
                    b.Property<int>("UR_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UR_Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Wallet.Wallet", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("IsPay")
                        .HasColumnType("bit");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("WalletTypeTypeId")
                        .HasColumnType("int");

                    b.HasKey("WalletId");

                    b.HasIndex("UserId");

                    b.HasIndex("WalletTypeTypeId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Wallet.WalletType", b =>
                {
                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("TypeTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("TypeId");

                    b.ToTable("WalletTypes");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.Course", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Course.CourseGroup", "CourseGroup")
                        .WithMany("Courses")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.Course.CourseLevel", "CourseLevel")
                        .WithMany("Courses")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.Course.CourseStatus", "CourseStatus")
                        .WithMany("Courses")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.Course.CourseGroup", "Group")
                        .WithMany("SubGroup")
                        .HasForeignKey("SubGroup");

                    b.HasOne("DollsWorld.DataLayer.Entities.User.User", "User")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseComment", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Course.Course", "Course")
                        .WithMany("CourseComments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.User.User", "User")
                        .WithMany("CourseComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseEpisode", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Course.Course", "Course")
                        .WithMany("CourseEpisodes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseGroup", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Course.CourseGroup", null)
                        .WithMany("CourseGroups")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.CourseVote", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Course.Course", "Course")
                        .WithMany("CourseVotes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.User.User", "User")
                        .WithMany("CourseVotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Course.UserCourse", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Course.Course", "Course")
                        .WithMany("UserCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.User.User", "User")
                        .WithMany("UserCourses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Order.Order", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.User.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Order.OrderDetail", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Course.Course", "Course")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.Order.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Permissions.Permission", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Permissions.Permission", null)
                        .WithMany("Permissions")
                        .HasForeignKey("ParentID");
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Permissions.RolePermission", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Permissions.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.User.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.User.UserDiscountCode", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.Order.Discount", "Discount")
                        .WithMany("UserDiscountCodes")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.User.User", "User")
                        .WithMany("UserDiscountCodes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.User.UserRole", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DollsWorld.DataLayer.Entities.Wallet.Wallet", b =>
                {
                    b.HasOne("DollsWorld.DataLayer.Entities.User.User", "User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DollsWorld.DataLayer.Entities.Wallet.WalletType", "WalletType")
                        .WithMany("Wallets")
                        .HasForeignKey("WalletTypeTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}