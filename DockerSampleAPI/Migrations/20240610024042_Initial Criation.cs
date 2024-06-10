using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DockerSampleAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCriation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Msgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Refnum = table.Column<int>(type: "int", nullable: false),
                    Trace = table.Column<int>(type: "int", nullable: false),
                    Pan = table.Column<int>(type: "int", nullable: false),
                    TranAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TranDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TranTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    LocalDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LocalTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    MCC = table.Column<int>(type: "int", nullable: false),
                    RespCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Msgs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Msgs");
        }
    }
}
