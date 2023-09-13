using System;
using Microsoft.EntityFrameworkCore.Migrations;
using TrainingManagment.Domain.consts;

namespace TrainingManagment.Repository.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] {"Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), RoleName.Admin, RoleName.Admin.ToUpper(), Guid.NewGuid().ToString() },
                schema: "Security"
                );

            migrationBuilder.InsertData(
               table: "Roles",
               columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
               values: new object[] { Guid.NewGuid().ToString(), RoleName.Manager, RoleName.Manager.ToUpper(), Guid.NewGuid().ToString() },
               schema: "Security"
               );

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 879, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 874, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 876, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 876, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 876, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 876, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 10, 20, 876, DateTimeKind.Local).AddTicks(6220));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("Delete from [Security].[Roles];");


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
    }
}
