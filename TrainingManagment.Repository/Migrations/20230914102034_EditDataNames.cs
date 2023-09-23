using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingManagment.Repository.Migrations
{
    public partial class EditDataNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3920), "Dot Net" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3923), "Business Analyst" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3926), "Quality Control" });

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
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3932), "UI/UX" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3934), "Human Resources" });

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
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3950), "Joining TPS Team" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(3953), "On Hold" });

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
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4095), "Khalid Salameh" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4097), "Lamees Hourani" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4099), "Mariam Al Sadawi" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4104), "Mohammad Ibdah" });

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
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4108), "Zakaria Lafi" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4111), "Ahmed Sweilem" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4113), "2023" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4115), "2024" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4117), "2025" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4120), "2026" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4122), "2027" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4124), "2028" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4127), "2029" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4129), "2030" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 14, 13, 20, 33, 641, DateTimeKind.Local).AddTicks(4131), "2031" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1727), "DotNet" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1732), "BusinessAnalyst" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1735), "QualityControl" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1742), "UI_UX" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1745), "HumanResources" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1767), "Joining_TPS_Team" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1771), "On_Hold" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1781), "Khalid_Salameh" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1784), "Lamees_Hourani" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1788), "Mariam_AlSadawi" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1794), "Mohammad_Ibdah" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1801), "Zakaria_Lafi" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "NameEn" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1804), "Ahmed_Sweilem" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1808), "Year2023" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1811), "Year2024" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1814), "Year2025" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1818), "Year2026" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1821), "Year2027" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1825), "Year2028" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1828), "Year2029" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1832), "Year2030" });

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "NameAr" },
                values: new object[] { new DateTime(2023, 9, 13, 14, 48, 0, 309, DateTimeKind.Local).AddTicks(1835), "Year2031" });

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 304, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 306, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 306, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 306, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 306, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 48, 0, 306, DateTimeKind.Local).AddTicks(6855));
        }
    }
}
