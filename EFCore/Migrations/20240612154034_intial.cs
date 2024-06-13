using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departnment",
                columns: table => new
                {
                    pkDepartnemtid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartnmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CretedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departnment", x => x.pkDepartnemtid);
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
                        principalColumn: "pkDepartnemtid",
                        onDelete: ReferentialAction.Cascade);
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
                    FKDoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Doctor_FKDoctorId",
                        column: x => x.FKDoctorId,
                        principalTable: "Doctor",
                        principalColumn: "PkDoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_FkDepartmentId",
                table: "Doctor",
                column: "FkDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FKDoctorId",
                table: "Users",
                column: "FKDoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Departnment");
        }
    }
}
