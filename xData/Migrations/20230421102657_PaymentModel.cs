using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class PaymentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transId = table.Column<int>(type: "int", nullable: false),
                    transLineId = table.Column<int>(type: "int", nullable: false),
                    paymentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    paymentDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientId = table.Column<int>(type: "int", nullable: false),
                    agentId = table.Column<int>(type: "int", nullable: false),
                    created_dt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_dt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payment_AgentDetail_agentId",
                        column: x => x.agentId,
                        principalTable: "AgentDetail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Client_clientId",
                        column: x => x.clientId,
                        principalTable: "Client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 21, 18, 26, 56, 906, DateTimeKind.Local).AddTicks(8625), new DateTime(2023, 4, 21, 18, 26, 56, 906, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_agentId",
                table: "Payment",
                column: "agentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_clientId",
                table: "Payment",
                column: "clientId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 20, 22, 43, 23, 828, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 4, 20, 22, 43, 23, 828, DateTimeKind.Local).AddTicks(8393) });
        }
    }
}
