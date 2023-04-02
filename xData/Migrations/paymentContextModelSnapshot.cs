﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xData.Data;

#nullable disable

namespace xData.Migrations
{
    [DbContext(typeof(paymentContext))]
    partial class paymentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("xDomain.Clients.clientsModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("agentId")
                        .HasColumnType("int");

                    b.Property<string>("bldgBlock")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("bldgLot")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("clientContactNumber")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("clientId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("clientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateStartMonthlyPay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("projGrpId")
                        .HasColumnType("int");

                    b.Property<decimal>("totalContractPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<int>("transTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("transferFee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("agentId")
                        .IsUnique();

                    b.HasIndex("projGrpId")
                        .IsUnique();

                    b.HasIndex("transTypeId")
                        .IsUnique();

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("xDomain.Settings.AgentDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("agentFirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("agentLastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("AgentDetail", (string)null);
                });

            modelBuilder.Entity("xDomain.Settings.ProjectGroup", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<string>("projGrpDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("ProjectGroup");
                });

            modelBuilder.Entity("xDomain.Settings.TransferType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<string>("transTypeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("TransferType", (string)null);
                });

            modelBuilder.Entity("xDomain._91128.AccessLevel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("accessTypeNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_dt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("formTypeNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_dt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("userRef")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userRef");

                    b.ToTable("AccessLevel", (string)null);
                });

            modelBuilder.Entity("xDomain._91128.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("addressTx")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactTx")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime>("created_dt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("emailTx")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("employeeNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("firstNm")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("isActive_yn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("lastNm")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("middleNm")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("passwordTx")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("updated_dt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("usernameTx")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            id = 1,
                            addressTx = "address",
                            contactTx = "contact",
                            created_dt = new DateTime(2023, 4, 2, 13, 46, 4, 19, DateTimeKind.Local).AddTicks(7018),
                            emailTx = "dummy.erick@gmail.com",
                            employeeNo = "A2023",
                            firstNm = "Admin",
                            isActive_yn = true,
                            lastNm = "Admin",
                            middleNm = "Admin",
                            passwordTx = "p@ssw0rd",
                            updated_dt = new DateTime(2023, 4, 2, 13, 46, 4, 19, DateTimeKind.Local).AddTicks(7032),
                            usernameTx = "Admin"
                        });
                });

            modelBuilder.Entity("xDomain.Clients.clientsModel", b =>
                {
                    b.HasOne("xDomain.Settings.AgentDetail", "Agent")
                        .WithOne("Client")
                        .HasForeignKey("xDomain.Clients.clientsModel", "agentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xDomain.Settings.ProjectGroup", "ProjGroup")
                        .WithOne("Client")
                        .HasForeignKey("xDomain.Clients.clientsModel", "projGrpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xDomain.Settings.TransferType", "TransType")
                        .WithOne("Client")
                        .HasForeignKey("xDomain.Clients.clientsModel", "transTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("ProjGroup");

                    b.Navigation("TransType");
                });

            modelBuilder.Entity("xDomain._91128.AccessLevel", b =>
                {
                    b.HasOne("xDomain._91128.User", "Users")
                        .WithMany("AccessLevels")
                        .HasForeignKey("userRef")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Users");
                });

            modelBuilder.Entity("xDomain.Settings.AgentDetail", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();
                });

            modelBuilder.Entity("xDomain.Settings.ProjectGroup", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();
                });

            modelBuilder.Entity("xDomain.Settings.TransferType", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();
                });

            modelBuilder.Entity("xDomain._91128.User", b =>
                {
                    b.Navigation("AccessLevels");
                });
#pragma warning restore 612, 618
        }
    }
}
