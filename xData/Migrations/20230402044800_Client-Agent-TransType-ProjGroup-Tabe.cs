using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class ClientAgentTransTypeProjGroupTabe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccessLevel_User_Usersuid",
                table: "AccessLevel");

            migrationBuilder.DropIndex(
                name: "IX_AccessLevel_Usersuid",
                table: "AccessLevel");

            migrationBuilder.DropColumn(
                name: "Usersuid",
                table: "AccessLevel");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_dt",
                table: "AccessLevel",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_dt",
                table: "AccessLevel",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "AgentDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    agentFirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    agentLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentDetail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectGroup",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projGrpDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TransferType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    clientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientContactNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    bldgBlock = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    bldgLot = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    totalContractPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    dateStartMonthlyPay = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    transferFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    transTypeId = table.Column<int>(type: "int", nullable: false),
                    agentId = table.Column<int>(type: "int", nullable: false),
                    projGrpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                    table.ForeignKey(
                        name: "FK_Client_AgentDetail_agentId",
                        column: x => x.agentId,
                        principalTable: "AgentDetail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_ProjectGroup_projGrpId",
                        column: x => x.projGrpId,
                        principalTable: "ProjectGroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_TransferType_transTypeId",
                        column: x => x.transTypeId,
                        principalTable: "TransferType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "uid",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 48, 0, 708, DateTimeKind.Local).AddTicks(2110), new DateTime(2023, 4, 2, 12, 48, 0, 708, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.CreateIndex(
                name: "IX_AccessLevel_userRef",
                table: "AccessLevel",
                column: "userRef");

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
                name: "FK_AccessLevel_User_userRef",
                table: "AccessLevel",
                column: "userRef",
                principalTable: "User",
                principalColumn: "uid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccessLevel_User_userRef",
                table: "AccessLevel");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "AgentDetail");

            migrationBuilder.DropTable(
                name: "ProjectGroup");

            migrationBuilder.DropTable(
                name: "TransferType");

            migrationBuilder.DropIndex(
                name: "IX_AccessLevel_userRef",
                table: "AccessLevel");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_dt",
                table: "AccessLevel",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_dt",
                table: "AccessLevel",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "Usersuid",
                table: "AccessLevel",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "uid",
                keyValue: 1,
                columns: new[] { "created_dt", "updated_dt" },
                values: new object[] { new DateTime(2023, 4, 1, 21, 6, 56, 809, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 4, 1, 21, 6, 56, 809, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.CreateIndex(
                name: "IX_AccessLevel_Usersuid",
                table: "AccessLevel",
                column: "Usersuid");

            migrationBuilder.AddForeignKey(
                name: "FK_AccessLevel_User_Usersuid",
                table: "AccessLevel",
                column: "Usersuid",
                principalTable: "User",
                principalColumn: "uid");
        }
    }
}
