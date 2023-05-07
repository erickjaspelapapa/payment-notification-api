﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xData.Data;

#nullable disable

namespace xData.Migrations
{
    [DbContext(typeof(paymentContext))]
    [Migration("20230507071758_TransactionTable")]
    partial class TransactionTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("xData.Objects.Transaction.tvfPaymentList", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal?>("AgentCommission")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Downpayment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("MonthlyPayment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("NotarialFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Promo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Reservation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TransferFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("agentId")
                        .HasColumnType("int");

                    b.Property<int>("clientId")
                        .HasColumnType("int");

                    b.Property<string>("clientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("paymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("transId")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable((string)null);

                    b.ToView("tvfPaymentList", (string)null);
                });

            modelBuilder.Entity("xDomain.Clients.clientsModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("agentId")
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

                    b.Property<int>("monthsToPay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(12);

                    b.Property<int?>("projGrpId")
                        .HasColumnType("int");

                    b.Property<decimal>("totalContractPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<int?>("transTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("transferFee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("agentId")
                        .IsUnique()
                        .HasFilter("[agentId] IS NOT NULL");

                    b.HasIndex("projGrpId")
                        .IsUnique()
                        .HasFilter("[projGrpId] IS NOT NULL");

                    b.HasIndex("transTypeId")
                        .IsUnique()
                        .HasFilter("[transTypeId] IS NOT NULL");

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

            modelBuilder.Entity("xDomain.Settings.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("catDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("xDomain.Settings.Identification", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("catId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<string>("idenDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("catId");

                    b.ToTable("Identification", (string)null);
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

            modelBuilder.Entity("xDomain.Transactions.payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("agentId")
                        .HasColumnType("int");

                    b.Property<int?>("clientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("paymentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("transId")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("agentId")
                        .IsUnique()
                        .HasFilter("[agentId] IS NOT NULL");

                    b.HasIndex("clientId")
                        .IsUnique()
                        .HasFilter("[clientId] IS NOT NULL");

                    b.ToTable("Payment", (string)null);
                });

            modelBuilder.Entity("xDomain.Transactions.paymentLines", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<string>("paymentType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("transId")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("transId");

                    b.ToTable("PaymentLine", (string)null);
                });

            modelBuilder.Entity("xDomain.Transactions.transaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10,2)")
                        .HasDefaultValue(0m);

                    b.Property<int>("catId")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<int>("identId")
                        .HasColumnType("int");

                    b.Property<string>("remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("transDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("transDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("catId")
                        .IsUnique();

                    b.HasIndex("identId")
                        .IsUnique();

                    b.ToTable("Transaction", (string)null);
                });

            modelBuilder.Entity("xDomain.Transactions.tvfPaymentRecords", b =>
                {
                    b.Property<int?>("id")
                        .HasColumnType("int");

                    b.Property<decimal?>("AgentCommission")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("AgentCommsPerc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Downpayment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DownpaymentPerc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("MonthlyPayment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("NotarialFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Promo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Reservation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TransferFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TransferFeePaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("agent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("firstMonthlyPay")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstMonthlyPayFormatted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("forProcessing")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("latestPayment")
                        .HasColumnType("datetime2");

                    b.Property<int?>("monthsPayLeft")
                        .HasColumnType("int");

                    b.Property<int?>("monthsToPay")
                        .HasColumnType("int");

                    b.Property<decimal?>("projectedMonPaymentAmt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("totalContractPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable((string)null);

                    b.ToView("tvfPaymentRecords", (string)null);
                });

            modelBuilder.Entity("xDomain.Transactions.tvfProjectedPayment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("clientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_dt")
                        .HasColumnType("datetime2");

                    b.Property<int>("monthPay")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_dt")
                        .HasColumnType("datetime2");

                    b.Property<int>("yearPay")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable((string)null);

                    b.ToView("tvfProjectedPayment", (string)null);
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
                            created_dt = new DateTime(2023, 5, 7, 15, 17, 54, 953, DateTimeKind.Local).AddTicks(2453),
                            emailTx = "dummy.erick@gmail.com",
                            employeeNo = "A2023",
                            firstNm = "Admin",
                            isActive_yn = true,
                            lastNm = "Admin",
                            middleNm = "Admin",
                            passwordTx = "p@ssw0rd",
                            updated_dt = new DateTime(2023, 5, 7, 15, 17, 54, 953, DateTimeKind.Local).AddTicks(2474),
                            usernameTx = "Admin"
                        });
                });

            modelBuilder.Entity("xDomain.Clients.clientsModel", b =>
                {
                    b.HasOne("xDomain.Settings.AgentDetail", "Agent")
                        .WithOne()
                        .HasForeignKey("xDomain.Clients.clientsModel", "agentId");

                    b.HasOne("xDomain.Settings.ProjectGroup", "ProjGroup")
                        .WithOne()
                        .HasForeignKey("xDomain.Clients.clientsModel", "projGrpId");

                    b.HasOne("xDomain.Settings.TransferType", "TransType")
                        .WithOne()
                        .HasForeignKey("xDomain.Clients.clientsModel", "transTypeId");

                    b.Navigation("Agent");

                    b.Navigation("ProjGroup");

                    b.Navigation("TransType");
                });

            modelBuilder.Entity("xDomain.Settings.Identification", b =>
                {
                    b.HasOne("xDomain.Settings.Category", "category")
                        .WithMany("identifications")
                        .HasForeignKey("catId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("xDomain.Transactions.payment", b =>
                {
                    b.HasOne("xDomain.Settings.AgentDetail", "agent")
                        .WithOne()
                        .HasForeignKey("xDomain.Transactions.payment", "agentId");

                    b.HasOne("xDomain.Clients.clientsModel", "client")
                        .WithOne()
                        .HasForeignKey("xDomain.Transactions.payment", "clientId");

                    b.Navigation("agent");

                    b.Navigation("client");
                });

            modelBuilder.Entity("xDomain.Transactions.paymentLines", b =>
                {
                    b.HasOne("xDomain.Transactions.payment", "Payment")
                        .WithMany("Lines")
                        .HasForeignKey("transId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("xDomain.Transactions.transaction", b =>
                {
                    b.HasOne("xDomain.Settings.Category", "category")
                        .WithOne()
                        .HasForeignKey("xDomain.Transactions.transaction", "catId");

                    b.HasOne("xDomain.Settings.Identification", "identification")
                        .WithOne()
                        .HasForeignKey("xDomain.Transactions.transaction", "identId");

                    b.Navigation("category");

                    b.Navigation("identification");
                });

            modelBuilder.Entity("xDomain._91128.AccessLevel", b =>
                {
                    b.HasOne("xDomain._91128.User", "Users")
                        .WithMany("AccessLevels")
                        .HasForeignKey("userRef")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Users");
                });

            modelBuilder.Entity("xDomain.Settings.Category", b =>
                {
                    b.Navigation("identifications");
                });

            modelBuilder.Entity("xDomain.Transactions.payment", b =>
                {
                    b.Navigation("Lines");
                });

            modelBuilder.Entity("xDomain._91128.User", b =>
                {
                    b.Navigation("AccessLevels");
                });
#pragma warning restore 612, 618
        }
    }
}
