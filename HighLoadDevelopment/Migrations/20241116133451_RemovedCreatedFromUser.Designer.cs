﻿// <auto-generated />
using System;
using HighLoadDevelopment.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HighLoadDevelopment.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241116133451_RemovedCreatedFromUser")]
    partial class RemovedCreatedFromUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HighLoadDevelopment.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Deleted_By")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Files");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Meeting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CurrentGuestsCount")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaxGuest")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<TimeOnly>("TimeEnd")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("TimeStart")
                        .HasColumnType("time without time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.MeetingsAndTags", b =>
                {
                    b.Property<Guid>("MeetingId")
                        .HasColumnType("uuid");

                    b.Property<int>("TagId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.HasKey("MeetingId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("MeetingsAndTags");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Deleted_By")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Reason")
                        .HasColumnType("integer");

                    b.Property<Guid>("ReportedId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ReporterId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ReporterId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.RolesAndPermissions", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("PermissionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolesAndPermissions");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CountRating")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageLink")
                        .HasColumnType("text");

                    b.Property<string>("Information")
                        .HasColumnType("text");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.Property<string>("SecondName")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.UsersAndRoles", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UsersAndRoles");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.UsersAndTags", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<int>("TagId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("UsersAndTags");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Visit", b =>
                {
                    b.Property<Guid>("MeetingId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Created_By")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Deleted_At")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("Deleted_By")
                        .HasColumnType("uuid");

                    b.Property<int?>("Mark")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Marked_At")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MeetingId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.File", b =>
                {
                    b.HasOne("HighLoadDevelopment.Models.User", "User")
                        .WithOne("File")
                        .HasForeignKey("HighLoadDevelopment.Models.File", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Meeting", b =>
                {
                    b.HasOne("HighLoadDevelopment.Models.User", "User")
                        .WithMany("Meetings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.MeetingsAndTags", b =>
                {
                    b.HasOne("HighLoadDevelopment.Models.Meeting", "Meeting")
                        .WithMany()
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HighLoadDevelopment.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Report", b =>
                {
                    b.HasOne("HighLoadDevelopment.Models.User", "User")
                        .WithMany("Reports")
                        .HasForeignKey("ReporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.RolesAndPermissions", b =>
                {
                    b.HasOne("HighLoadDevelopment.Models.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HighLoadDevelopment.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.UsersAndRoles", b =>
                {
                    b.HasOne("HighLoadDevelopment.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HighLoadDevelopment.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.UsersAndTags", b =>
                {
                    b.HasOne("HighLoadDevelopment.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HighLoadDevelopment.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.Visit", b =>
                {
                    b.HasOne("HighLoadDevelopment.Models.Meeting", "Meeting")
                        .WithMany()
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HighLoadDevelopment.Models.User", "User")
                        .WithMany("Visits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HighLoadDevelopment.Models.User", b =>
                {
                    b.Navigation("File")
                        .IsRequired();

                    b.Navigation("Meetings");

                    b.Navigation("Reports");

                    b.Navigation("Visits");
                });
#pragma warning restore 612, 618
        }
    }
}