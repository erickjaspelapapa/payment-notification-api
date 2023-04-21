using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class ClientMonthsToPay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_AgentDetail_agentId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_ProjectGroup_projGrpId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_TransferType_transTypeId",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "transTypeId",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "projGrpId",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "agentId",
                table: "Client",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "monthsToPay",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 12);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 20, 22, 43, 23, 828, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 4, 20, 22, 43, 23, 828, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.AddForeignKey(
                name: "FK_Client_AgentDetail_agentId",
                table: "Client",
                column: "agentId",
                principalTable: "AgentDetail",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ProjectGroup_projGrpId",
                table: "Client",
                column: "projGrpId",
                principalTable: "ProjectGroup",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_TransferType_transTypeId",
                table: "Client",
                column: "transTypeId",
                principalTable: "TransferType",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_AgentDetail_agentId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_ProjectGroup_projGrpId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_TransferType_transTypeId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_agentId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_projGrpId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_transTypeId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "monthsToPay",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "transTypeId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "projGrpId",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "agentId",
                table: "Client",
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
                values: new object[] { new DateTime(2023, 4, 2, 13, 46, 4, 19, DateTimeKind.Local).AddTicks(7018), new DateTime(2023, 4, 2, 13, 46, 4, 19, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.CreateIndex(
                name: "IX_Client_agentId",
                table: "Client",
                column: "agentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_projGrpId",
                table: "Client",
                column: "projGrpId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_transTypeId",
                table: "Client",
                column: "transTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_AgentDetail_agentId",
                table: "Client",
                column: "agentId",
                principalTable: "AgentDetail",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ProjectGroup_projGrpId",
                table: "Client",
                column: "projGrpId",
                principalTable: "ProjectGroup",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_TransferType_transTypeId",
                table: "Client",
                column: "transTypeId",
                principalTable: "TransferType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
