using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class PaymentLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amount",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "paymentType",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "transLineId",
                table: "Payment");

            migrationBuilder.CreateTable(
                name: "PaymentLine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transId = table.Column<int>(type: "int", nullable: false),
                    paymentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    created_dt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_dt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentLine", x => x.id);
                    table.ForeignKey(
                        name: "FK_PaymentLine_Payment_transId",
                        column: x => x.transId,
                        principalTable: "Payment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 22, 21, 24, 46, 909, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 4, 22, 21, 24, 46, 909, DateTimeKind.Local).AddTicks(9895) });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentLine");

            migrationBuilder.AddColumn<decimal>(
                name: "amount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "paymentType",
                table: "Payment",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "transLineId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 38, 54, 826, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 4, 22, 0, 38, 54, 826, DateTimeKind.Local).AddTicks(3638) });
        }
    }
}
