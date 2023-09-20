using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingManagment.Repository.Migrations
{
    public partial class EditActualEndDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActualEndDate",
                table: "Session",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9553), "Mohammad Hamad" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 409, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 405, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 407, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 407, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 407, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 407, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 19, 9, 38, 8, 407, DateTimeKind.Local).AddTicks(9719));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActualEndDate",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4102), "Mohammad_Hamad" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 637, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 639, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 639, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 639, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 639, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 639, DateTimeKind.Local).AddTicks(7050));
        }
    }
}
