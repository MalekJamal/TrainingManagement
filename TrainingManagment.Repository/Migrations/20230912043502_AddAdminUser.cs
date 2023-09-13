using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingManagment.Repository.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Security].[Users] (Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount, FullName, ProfilePicture) VALUES ('dc9a8b7d-2014-445b-b63f-6d0ff68da9d7', 'malek', 'MALEK', 'malek@tps.com', 'MALEK@TPS.COM', 0, 'AQAAAAEAACcQAAAAEL6NGG+cqOmDBPhwOIe99AJgic/293dyRF34WLdNs1MPDE9iZ5dB6i7LmCx1OsUIVQ==', 'GKOZLXTGBL2XQ3GF2RTPHD3IILP4RL2I', '3febd8f2-800d-4fac-bed7-c986939b05d1', NULL, 0, 0, NULL, 1, 0, 'Malek Hamdan', NULL);");
            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 828, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 824, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 826, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 826, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 826, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 826, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 35, 1, 826, DateTimeKind.Local).AddTicks(7058));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From [Security].[Users] Where Id='dc9a8b7d-2014-445b-b63f-6d0ff68da9d7';");
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
    }
}
