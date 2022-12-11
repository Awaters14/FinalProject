using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    priorityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    priorityValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.priorityId);
                });

            migrationBuilder.CreateTable(
                name: "Respones",
                columns: table => new
                {
                    ResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    problem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priorityId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respones", x => x.ResponseId);
                    table.ForeignKey(
                        name: "FK_Respones_Priorities_priorityId",
                        column: x => x.priorityId,
                        principalTable: "Priorities",
                        principalColumn: "priorityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "priorityId", "priorityValue" },
                values: new object[,]
                {
                    { "1", "A" },
                    { "2", "B" },
                    { "3", "C" },
                    { "4", "D" },
                    { "5", "E" },
                    { "6", "F" }
                });

            migrationBuilder.InsertData(
                table: "Respones",
                columns: new[] { "ResponseId", "address", "name", "priorityId", "problem", "state", "zipcode" },
                values: new object[] { 2, "456 downtown ave.", "Frank", "1", "Missing roof", "IA", "44444" });

            migrationBuilder.InsertData(
                table: "Respones",
                columns: new[] { "ResponseId", "address", "name", "priorityId", "problem", "state", "zipcode" },
                values: new object[] { 3, "5533 86th st.", "Phil", "1", "Tree fell into house", "IA", "333" });

            migrationBuilder.InsertData(
                table: "Respones",
                columns: new[] { "ResponseId", "address", "name", "priorityId", "problem", "state", "zipcode" },
                values: new object[] { 1, "123 main st.", "Bob", "2", "Broken Window", "IA", "55555" });

            migrationBuilder.CreateIndex(
                name: "IX_Respones_priorityId",
                table: "Respones",
                column: "priorityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Respones");

            migrationBuilder.DropTable(
                name: "Priorities");
        }
    }
}
