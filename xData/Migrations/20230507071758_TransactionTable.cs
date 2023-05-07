using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class TransactionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValue: 0m),
                    catId = table.Column<int>(type: "int", nullable: false),
                    identId = table.Column<int>(type: "int", nullable: false),
                    transDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_dt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_dt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.id);
                    table.ForeignKey(
                        name: "FK_Transaction_Category_catId",
                        column: x => x.catId,
                        principalTable: "Category",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Transaction_Identification_identId",
                        column: x => x.identId,
                        principalTable: "Identification",
                        principalColumn: "id");
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 5, 6, 22, 8, 40, 753, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 5, 6, 22, 8, 40, 753, DateTimeKind.Local).AddTicks(7668) });
        }
    }
}
