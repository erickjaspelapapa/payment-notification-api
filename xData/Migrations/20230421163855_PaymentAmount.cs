using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class PaymentAmount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_AgentDetail_agentId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Client_clientId",
                table: "Payment");


            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "Payment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "agentId",
                table: "Payment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "amount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 38, 54, 826, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 4, 22, 0, 38, 54, 826, DateTimeKind.Local).AddTicks(3638) });


            migrationBuilder.AddForeignKey(
                name: "FK_Payment_AgentDetail_agentId",
                table: "Payment",
                column: "agentId",
                principalTable: "AgentDetail",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Client_clientId",
                table: "Payment",
                column: "clientId",
                principalTable: "Client",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_AgentDetail_agentId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Client_clientId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_agentId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_clientId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "Payment");

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "agentId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_AgentDetail_agentId",
                table: "Payment",
                column: "agentId",
                principalTable: "AgentDetail",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Client_clientId",
                table: "Payment",
                column: "clientId",
                principalTable: "Client",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
