using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShamsAlShamoos03.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonleTbl_02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoryRegisterKala01",
                columns: table => new
                {
                    HistoryRegisterKala01ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocumentNO01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext01 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext02 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext03 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext04 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext05 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext06 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext07 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext08 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext09 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vartext20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusConfirmation01 = table.Column<int>(type: "int", nullable: true),
                    StatusConfirmation02 = table.Column<int>(type: "int", nullable: true),
                    StatusConfirmation03 = table.Column<int>(type: "int", nullable: true),
                    StatusConfirmation04 = table.Column<int>(type: "int", nullable: true),
                    StatusConfirmation05 = table.Column<int>(type: "int", nullable: true),
                    StatusConfirmation06 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryRegisterKala01", x => x.HistoryRegisterKala01ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryRegisterKala01");
        }
    }
}
