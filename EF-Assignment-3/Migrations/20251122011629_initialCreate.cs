using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Assignment_3.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orgin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classfication = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirCrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    AirLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCrafts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirCrafts_AirLines_AirLineId",
                        column: x => x.AirLineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AirLinePhones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLinePhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirLinePhones_AirLines_AirLineId",
                        column: x => x.AirLineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AirLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AirLines_AirLineId",
                        column: x => x.AirLineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AirLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AirLines_AirLineId",
                        column: x => x.AirLineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AirCraftRoutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirCraftId = table.Column<int>(type: "int", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    NumOfPassengers = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCraftRoutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirCraftRoutes_AirCrafts_AirCraftId",
                        column: x => x.AirCraftId,
                        principalTable: "AirCrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AirCraftRoutes_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    AirCraftId = table.Column<int>(type: "int", nullable: false),
                    MajorPilotId = table.Column<int>(type: "int", nullable: false),
                    AssistPilotId = table.Column<int>(type: "int", nullable: false),
                    Host1Id = table.Column<int>(type: "int", nullable: false),
                    Host2Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.AirCraftId);
                    table.ForeignKey(
                        name: "FK_Crews_AirCrafts_AirCraftId",
                        column: x => x.AirCraftId,
                        principalTable: "AirCrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Crews_Employees_AssistPilotId",
                        column: x => x.AssistPilotId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Crews_Employees_Host1Id",
                        column: x => x.Host1Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Crews_Employees_Host2Id",
                        column: x => x.Host2Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Crews_Employees_MajorPilotId",
                        column: x => x.MajorPilotId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeQualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeQualifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirCraftRoutes_AirCraftId",
                table: "AirCraftRoutes",
                column: "AirCraftId");

            migrationBuilder.CreateIndex(
                name: "IX_AirCraftRoutes_RouteId",
                table: "AirCraftRoutes",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_AirCrafts_AirLineId",
                table: "AirCrafts",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_AirLinePhones_AirLineId",
                table: "AirLinePhones",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_AssistPilotId",
                table: "Crews",
                column: "AssistPilotId");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_Host1Id",
                table: "Crews",
                column: "Host1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_Host2Id",
                table: "Crews",
                column: "Host2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_MajorPilotId",
                table: "Crews",
                column: "MajorPilotId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeQualifications_EmployeeId",
                table: "EmployeeQualifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AirLineId",
                table: "Employees",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AirLineId",
                table: "Transactions",
                column: "AirLineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirCraftRoutes");

            migrationBuilder.DropTable(
                name: "AirLinePhones");

            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "EmployeeQualifications");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "AirCrafts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "AirLines");
        }
    }
}
