using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRestAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath", "departmentId" },
                values: new object[,]
                {
                    { 1, "joe@smaplemail.com", "Joe", 0, "Smith", "Images/joe.png", 1 },
                    { 2, "john@smaplemail.com", "John", 0, "Smith", "Images/john.png", 2 },
                    { 3, "james@smaplemail.com", "James", 0, "Johnson", "Images/james.png", 3 },
                    { 4, "john@smaplemail.com", "John", 0, "Doe", "Images/john.png", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
