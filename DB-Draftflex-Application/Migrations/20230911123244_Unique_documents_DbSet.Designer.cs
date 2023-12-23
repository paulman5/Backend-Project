﻿// <auto-generated />
using System;
using DB_Layer1_Draftflex.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DB_Layer1_Draftflex.Migrations
{
    [DbContext(typeof(DraftflexDataContext))]
    [Migration("20230911123244_Unique_documents_DbSet")]
    partial class Unique_documents_DbSet
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("DB_Layer1_Draftflex.Data.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LicenseId_New")
                        .HasColumnType("integer");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DB_Layer1_Draftflex.Data.License", b =>
                {
                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("LicenseId"));

                    b.Property<string>("License_version")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Permissions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LicenseId");

                    b.ToTable("License");
                });

            modelBuilder.Entity("DB_Layer1_Draftflex.Data.Templates", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("TemplateId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DocumentVersion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Formfields")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TemplateId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("DB_Layer1_Draftflex.Data.Unique_Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("DocumentId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("CompanyId"));

                    b.Property<DateTime>("Payment_Date_Reminder")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Renewal_Date_Reminder")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("SignatureDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TemplateId")
                        .HasColumnType("integer");

                    b.HasKey("DocumentId");

                    b.ToTable("UniqueDocuments");
                });

            modelBuilder.Entity("DB_Layer1_Draftflex.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("UserId"));

                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
