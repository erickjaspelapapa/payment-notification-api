using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class ClientModelsBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uid",
                table: "User",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "uid",
                table: "AccessLevel",
                newName: "id");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_dt",
                table: "TransferType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_dt",
                table: "TransferType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_dt",
                table: "ProjectGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_dt",
                table: "ProjectGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_dt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_dt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_dt",
                table: "AgentDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_dt",
                table: "AgentDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 2, 13, 46, 4, 19, DateTimeKind.Local).AddTicks(7018), new DateTime(2023, 4, 2, 13, 46, 4, 19, DateTimeKind.Local).AddTicks(7032) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_dt",
                table: "TransferType");

            migrationBuilder.DropColumn(
                name: "updated_dt",
                table: "TransferType");

            migrationBuilder.DropColumn(
                name: "created_dt",
                table: "ProjectGroup");

            migrationBuilder.DropColumn(
                name: "updated_dt",
                table: "ProjectGroup");

            migrationBuilder.DropColumn(
                name: "created_dt",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "updated_dt",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "created_dt",
                table: "AgentDetail");

            migrationBuilder.DropColumn(
                name: "updated_dt",
                table: "AgentDetail");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "User",
                newName: "uid");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AccessLevel",
                newName: "uid");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "uid",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 48, 0, 708, DateTimeKind.Local).AddTicks(2110), new DateTime(2023, 4, 2, 12, 48, 0, 708, DateTimeKind.Local).AddTicks(2123) });
        }
    }
}
