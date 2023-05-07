using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class TransactionTableNonUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transaction_catId",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_identId",
                table: "Transaction");

            migrationBuilder.AlterColumn<int>(
                name: "identId",
                table: "Transaction",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "catId",
                table: "Transaction",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 5, 7, 15, 23, 20, 297, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 5, 7, 15, 23, 20, 297, DateTimeKind.Local).AddTicks(5260) });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transaction_catId",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_identId",
                table: "Transaction");

            migrationBuilder.AlterColumn<int>(
                name: "identId",
                table: "Transaction",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "catId",
                table: "Transaction",
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
                values: new object[] { new DateTime(2023, 5, 7, 15, 17, 54, 953, DateTimeKind.Local).AddTicks(2453), new DateTime(2023, 5, 7, 15, 17, 54, 953, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_catId",
                table: "Transaction",
                column: "catId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_identId",
                table: "Transaction",
                column: "identId",
                unique: true);
        }
    }
}
