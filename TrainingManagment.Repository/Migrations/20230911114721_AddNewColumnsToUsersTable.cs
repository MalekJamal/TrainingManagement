using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingManagment.Repository.Migrations
{
    public partial class AddNewColumnsToUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "Security",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Security",
                table: "Users",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                schema: "Security",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 767, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 762, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 764, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 764, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 764, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 764, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 47, 20, 764, DateTimeKind.Local).AddTicks(6694));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                schema: "Security",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "Security",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "Security",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 981, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 977, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 979, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 979, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 979, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 979, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 14, 33, 30, 979, DateTimeKind.Local).AddTicks(3801));
        }
    }
}
