using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class CompanyTransactionSetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catDescription = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    created_dt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_dt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Identification",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idenDescription = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    catId = table.Column<int>(type: "int", nullable: true),
                    created_dt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_dt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identification", x => x.id);
                    table.ForeignKey(
                        name: "FK_Identification_Category_catId",
                        column: x => x.catId,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 5, 6, 22, 8, 40, 753, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 5, 6, 22, 8, 40, 753, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.CreateIndex(
                name: "IX_Identification_catId",
                table: "Identification",
                column: "catId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Identification");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 22, 21, 24, 46, 909, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 4, 22, 21, 24, 46, 909, DateTimeKind.Local).AddTicks(9895) });
        }
    }
}
