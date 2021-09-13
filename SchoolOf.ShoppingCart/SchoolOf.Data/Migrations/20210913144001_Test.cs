using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolOf.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNo = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Total = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Adress", "CreatedAt", "Email", "IsDeleted", "ModifiedAt", "Name", "PhoneNo", "Total" },
                values: new object[,]
                {
                    { 1L, "Test Adress11111", new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 506, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 0, 0, 0, 0)), "TestEmail11111@gmail.com", false, new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 506, DateTimeKind.Unspecified).AddTicks(7692), new TimeSpan(0, 0, 0, 0, 0)), "TestName1", 11111, 300L },
                    { 2L, "Test Adress222222", new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 506, DateTimeKind.Unspecified).AddTicks(7713), new TimeSpan(0, 0, 0, 0, 0)), "TestEmail222222@gmail.com", false, new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 506, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, 0, 0, 0, 0)), "TestName2", 222222, 1000L },
                    { 3L, "Test Adress33333333", new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 506, DateTimeKind.Unspecified).AddTicks(7717), new TimeSpan(0, 0, 0, 0, 0)), "TestEmail333333@gmail.com", false, new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 506, DateTimeKind.Unspecified).AddTicks(7718), new TimeSpan(0, 0, 0, 0, 0)), "TestName3", 33333333, 500L }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 503, DateTimeKind.Unspecified).AddTicks(9240), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 503, DateTimeKind.Unspecified).AddTicks(9695), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 504, DateTimeKind.Unspecified).AddTicks(65), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 504, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 504, DateTimeKind.Unspecified).AddTicks(71), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 13, 14, 40, 0, 504, DateTimeKind.Unspecified).AddTicks(72), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 13, 13, 44, 53, 427, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 13, 13, 44, 53, 428, DateTimeKind.Unspecified).AddTicks(154), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 13, 13, 44, 53, 428, DateTimeKind.Unspecified).AddTicks(527), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 13, 13, 44, 53, 428, DateTimeKind.Unspecified).AddTicks(531), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 13, 13, 44, 53, 428, DateTimeKind.Unspecified).AddTicks(534), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 13, 13, 44, 53, 428, DateTimeKind.Unspecified).AddTicks(535), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
