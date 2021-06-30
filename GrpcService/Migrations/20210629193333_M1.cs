using Microsoft.EntityFrameworkCore.Migrations;

namespace GrpcService.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeProfile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeEmail", "EmployeeName", "EmployeeProfile" },
                values: new object[,]
                {
                    { 1, "hp@gmail.com", "Harshit Prad", "Technician" },
                    { 2, "dp@gmail.com", "Dev Prad", "Sales Manager" },
                    { 3, "Dhp@gmail.com", "Dhruv Prad", "Business head" },
                    { 4, "kp@gmail.com", "Kartik Prad", "software dev" },
                    { 5, "Dep@gmail.com", "Deepu Prad", "software dev in test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
