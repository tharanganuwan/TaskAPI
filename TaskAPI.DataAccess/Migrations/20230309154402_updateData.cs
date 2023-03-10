using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 3, 9, 21, 14, 1, 303, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 3, 14, 21, 14, 1, 304, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 3, 9, 21, 14, 1, 304, DateTimeKind.Local).AddTicks(7525), new DateTime(2023, 3, 14, 21, 14, 1, 304, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 3, 9, 21, 14, 1, 304, DateTimeKind.Local).AddTicks(7546), new DateTime(2023, 3, 14, 21, 14, 1, 304, DateTimeKind.Local).AddTicks(7548) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 3, 9, 14, 53, 31, 851, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 3, 14, 14, 53, 31, 852, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 3, 9, 14, 53, 31, 852, DateTimeKind.Local).AddTicks(7574), new DateTime(2023, 3, 14, 14, 53, 31, 852, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 3, 9, 14, 53, 31, 852, DateTimeKind.Local).AddTicks(7590), new DateTime(2023, 3, 14, 14, 53, 31, 852, DateTimeKind.Local).AddTicks(7591) });
        }
    }
}
