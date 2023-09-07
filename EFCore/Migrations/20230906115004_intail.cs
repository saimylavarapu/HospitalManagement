using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class intail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departnment",
                columns: table => new
                {
                    PkDepartnemtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartnmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CretedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departnment", x => x.PkDepartnemtId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    Avatar = table.Column<string>(type: "VARCHAR(2000)", maxLength: 2000, nullable: true),
                    CretedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bio = table.Column<string>(type: "VARCHAR(5000)", maxLength: 5000, nullable: true),
                    Comapany = table.Column<string>(type: "VARCHAR(5000)", maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    PkDoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "VARCHAR", nullable: false),
                    Specialization = table.Column<string>(type: "VARCHAR", nullable: false),
                    PhoneNumber = table.Column<int>(type: "INT", nullable: false),
                    CretedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    FkDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.PkDoctorId);
                    table.ForeignKey(
                        name: "FK_Doctor_Departnment_FkDepartmentId",
                        column: x => x.FkDepartmentId,
                        principalTable: "Departnment",
                        principalColumn: "PkDepartnemtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_FkDepartmentId",
                table: "Doctor",
                column: "FkDepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departnment");
        }
    }
}
