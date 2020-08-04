using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelRooms.Data.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chambermaids",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chambermaids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CleaningStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CleaningTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    RoomTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservedRooms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    RoomId = table.Column<long>(nullable: false),
                    GuestId = table.Column<long>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservedRooms_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservedRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignedRooms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ReservedRoomId = table.Column<long>(nullable: false),
                    CleaningTypeId = table.Column<long>(nullable: false),
                    ChambermaidId = table.Column<long>(nullable: false),
                    CleaningStatusId = table.Column<long>(nullable: false),
                    BigTowels = table.Column<int>(nullable: false),
                    SmallTowels = table.Column<int>(nullable: false),
                    FootTowels = table.Column<int>(nullable: false),
                    Pillowcases = table.Column<int>(nullable: false),
                    SingleSheets = table.Column<int>(nullable: false),
                    DoubleSheets = table.Column<int>(nullable: false),
                    SingleDuvetCovers = table.Column<int>(nullable: false),
                    DoubleDuvetCovers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignedRooms_Chambermaids_ChambermaidId",
                        column: x => x.ChambermaidId,
                        principalTable: "Chambermaids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignedRooms_CleaningStatuses_CleaningStatusId",
                        column: x => x.CleaningStatusId,
                        principalTable: "CleaningStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignedRooms_CleaningTypes_CleaningTypeId",
                        column: x => x.CleaningTypeId,
                        principalTable: "CleaningTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignedRooms_ReservedRooms_ReservedRoomId",
                        column: x => x.ReservedRoomId,
                        principalTable: "ReservedRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Chambermaids",
                columns: new[] { "Id", "CreatedAt", "LastName", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 7, 30, 11, 18, 9, 127, DateTimeKind.Local).AddTicks(5605), "Ivić", "Ivana" },
                    { 2L, new DateTime(2020, 7, 30, 11, 18, 9, 127, DateTimeKind.Local).AddTicks(6815), "Matić", "Matea" },
                    { 3L, new DateTime(2020, 7, 30, 11, 18, 9, 127, DateTimeKind.Local).AddTicks(6868), "Lorić", "Lara" }
                });

            migrationBuilder.InsertData(
                table: "CleaningStatuses",
                columns: new[] { "Id", "CreatedAt", "Status" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 7, 30, 11, 18, 9, 128, DateTimeKind.Local).AddTicks(293), "Nespremljena" },
                    { 2L, new DateTime(2020, 7, 30, 11, 18, 9, 128, DateTimeKind.Local).AddTicks(883), "Trenutno se sprema" },
                    { 3L, new DateTime(2020, 7, 30, 11, 18, 9, 128, DateTimeKind.Local).AddTicks(932), "Zavrsena" }
                });

            migrationBuilder.InsertData(
                table: "CleaningTypes",
                columns: new[] { "Id", "CreatedAt", "Type" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 7, 30, 11, 18, 9, 119, DateTimeKind.Local).AddTicks(5714), "Generalna" },
                    { 2L, new DateTime(2020, 7, 30, 11, 18, 9, 125, DateTimeKind.Local).AddTicks(2342), "Gostinjska" }
                });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "CreatedAt", "Email", "LastName", "Name" },
                values: new object[,]
                {
                    { 10L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1811), "abel@mailinator.com", "Abel", "Wilfred" },
                    { 9L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1803), "mendoza@mailinator.com", "Mendoza", "Brett" },
                    { 8L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1799), "misty@mailinator.com", "Porter", "Misty" },
                    { 7L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1795), "salvatore@mailinator.com", "Singh", "Salvatore" },
                    { 6L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1792), "claudia@mailinator.com", "Hebert", "Claudia" },
                    { 4L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1784), "ivanalton@mailinator.com", "Alton", "Ivan" },
                    { 3L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1776), "simona@mailinator.com", "Horvat", "Simona" },
                    { 2L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1696), "petar@mailinator.com", "Tuker", "Petar" },
                    { 1L, new DateTime(2020, 7, 30, 11, 18, 9, 128, DateTimeKind.Local).AddTicks(9805), "morgan@mailinator.com", "Adams", "Morgan" },
                    { 5L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(1788), "morgan@mailinator.com", "Adams", "Morgan" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedAt", "Type" },
                values: new object[,]
                {
                    { 4L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(7186), "3SB" },
                    { 1L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(6536), "1SB" },
                    { 2L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(7145), "2SB" },
                    { 3L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(7179), "1DB" },
                    { 5L, new DateTime(2020, 7, 30, 11, 18, 9, 129, DateTimeKind.Local).AddTicks(7190), "1DB1SB" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "RoomTypeId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(3735), 1L },
                    { 6L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4816), 1L },
                    { 11L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4850), 1L },
                    { 2L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4667), 2L },
                    { 3L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4755), 2L },
                    { 7L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4823), 2L },
                    { 8L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4831), 2L },
                    { 12L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4858), 2L },
                    { 4L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4801), 3L },
                    { 9L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4842), 3L },
                    { 13L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4861), 3L },
                    { 14L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4865), 3L },
                    { 5L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4808), 4L },
                    { 15L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4869), 4L },
                    { 10L, new DateTime(2020, 7, 30, 11, 18, 9, 130, DateTimeKind.Local).AddTicks(4846), 5L }
                });

            migrationBuilder.InsertData(
                table: "ReservedRooms",
                columns: new[] { "Id", "ArrivalDate", "CreatedAt", "DepartureDate", "GuestId", "RoomId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(6649), new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L },
                    { 6L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9293), new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6L, 6L },
                    { 2L, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9168), new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 2L },
                    { 3L, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9274), new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 3L },
                    { 7L, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9297), new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7L, 7L },
                    { 8L, new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9305), new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8L, 8L },
                    { 4L, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9282), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L, 4L },
                    { 9L, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9308), new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9L, 9L },
                    { 5L, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 11, 18, 9, 131, DateTimeKind.Local).AddTicks(9289), new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L, 5L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRooms_ChambermaidId",
                table: "AssignedRooms",
                column: "ChambermaidId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRooms_CleaningStatusId",
                table: "AssignedRooms",
                column: "CleaningStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRooms_CleaningTypeId",
                table: "AssignedRooms",
                column: "CleaningTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRooms_ReservedRoomId",
                table: "AssignedRooms",
                column: "ReservedRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedRooms_GuestId",
                table: "ReservedRooms",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedRooms_RoomId",
                table: "ReservedRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignedRooms");

            migrationBuilder.DropTable(
                name: "Chambermaids");

            migrationBuilder.DropTable(
                name: "CleaningStatuses");

            migrationBuilder.DropTable(
                name: "CleaningTypes");

            migrationBuilder.DropTable(
                name: "ReservedRooms");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
