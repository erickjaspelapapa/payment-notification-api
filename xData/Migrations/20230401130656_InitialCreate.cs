using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstNm = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    middleNm = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    lastNm = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    addressTx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactTx = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    usernameTx = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    passwordTx = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    emailTx = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    employeeNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    isActive_yn = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_dt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    updated_dt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "AccessLevel",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userRef = table.Column<int>(type: "int", nullable: false),
                    formTypeNo = table.Column<int>(type: "int", nullable: false),
                    accessTypeNo = table.Column<int>(type: "int", nullable: false),
                    Usersuid = table.Column<int>(type: "int", nullable: true),
                    created_dt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_dt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLevel", x => x.uid);
                    table.ForeignKey(
                        name: "FK_AccessLevel_User_Usersuid",
                        column: x => x.Usersuid,
                        principalTable: "User",
                        principalColumn: "uid");
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "uid", "addressTx", "contactTx", "created_dt", "emailTx", "employeeNo", "firstNm", "isActive_yn", "lastNm", "middleNm", "passwordTx", "updated_dt", "usernameTx" },
                values: new object[] { 1, "address", "contact", new DateTime(2023, 4, 1, 21, 6, 56, 809, DateTimeKind.Local).AddTicks(2194), "dummy.erick@gmail.com", "A2023", "Admin", true, "Admin", "Admin", "p@ssw0rd", new DateTime(2023, 4, 1, 21, 6, 56, 809, DateTimeKind.Local).AddTicks(2203), "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_AccessLevel_Usersuid",
                table: "AccessLevel",
                column: "Usersuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessLevel");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
