using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingManagment.Repository.Migrations
{
    public partial class UpdateAllTheProject01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_ResultLookupId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_StatusLookupId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainerLookupId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainingTopicLookupId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainingTypeLookupId",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "TrainerName",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "TrainingTopic",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "TrainingType",
                table: "Session");

            migrationBuilder.RenameColumn(
                name: "TrainingTypeLookupId",
                table: "Session",
                newName: "TrainingTypeId");

            migrationBuilder.RenameColumn(
                name: "TrainingTopicLookupId",
                table: "Session",
                newName: "TrainingTopicId");

            migrationBuilder.RenameColumn(
                name: "TrainerLookupId",
                table: "Session",
                newName: "TrainingStatusId");

            migrationBuilder.RenameColumn(
                name: "StatusLookupId",
                table: "Session",
                newName: "TrainingResultId");

            migrationBuilder.RenameColumn(
                name: "ResultLookupId",
                table: "Session",
                newName: "TrainerNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainingTypeLookupId",
                table: "Session",
                newName: "IX_Session_TrainingTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainingTopicLookupId",
                table: "Session",
                newName: "IX_Session_TrainingTopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainerLookupId",
                table: "Session",
                newName: "IX_Session_TrainingStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_StatusLookupId",
                table: "Session",
                newName: "IX_Session_TrainingResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_ResultLookupId",
                table: "Session",
                newName: "IX_Session_TrainerNameId");

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Session",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FinalPresentationDate",
                table: "Session",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<double>(
                name: "EvaluationScore",
                table: "Session",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "LookupYearId",
                table: "Session",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 604, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 601, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 602, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 602, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 602, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 602, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 14, 32, 36, 602, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.CreateIndex(
                name: "IX_Session_LookupYearId",
                table: "Session",
                column: "LookupYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_LookupYearId",
                table: "Session",
                column: "LookupYearId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainerNameId",
                table: "Session",
                column: "TrainerNameId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainingResultId",
                table: "Session",
                column: "TrainingResultId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainingStatusId",
                table: "Session",
                column: "TrainingStatusId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainingTopicId",
                table: "Session",
                column: "TrainingTopicId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainingTypeId",
                table: "Session",
                column: "TrainingTypeId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_LookupYearId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainerNameId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainingResultId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainingStatusId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainingTopicId",
                table: "Session");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Lookup_TrainingTypeId",
                table: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Session_LookupYearId",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "LookupYearId",
                table: "Session");

            migrationBuilder.RenameColumn(
                name: "TrainingTypeId",
                table: "Session",
                newName: "TrainingTypeLookupId");

            migrationBuilder.RenameColumn(
                name: "TrainingTopicId",
                table: "Session",
                newName: "TrainingTopicLookupId");

            migrationBuilder.RenameColumn(
                name: "TrainingStatusId",
                table: "Session",
                newName: "TrainerLookupId");

            migrationBuilder.RenameColumn(
                name: "TrainingResultId",
                table: "Session",
                newName: "StatusLookupId");

            migrationBuilder.RenameColumn(
                name: "TrainerNameId",
                table: "Session",
                newName: "ResultLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainingTypeId",
                table: "Session",
                newName: "IX_Session_TrainingTypeLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainingTopicId",
                table: "Session",
                newName: "IX_Session_TrainingTopicLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainingStatusId",
                table: "Session",
                newName: "IX_Session_TrainerLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainingResultId",
                table: "Session",
                newName: "IX_Session_StatusLookupId");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainerNameId",
                table: "Session",
                newName: "IX_Session_ResultLookupId");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Session",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FinalPresentationDate",
                table: "Session",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "EvaluationScore",
                table: "Session",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Result",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainerName",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingTopic",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingType",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Lookup",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 250, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 247, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 248, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 248, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 400,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 248, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 500,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 248, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "LookupCategory",
                keyColumn: "CategoryId",
                keyValue: 600,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 12, 7, 55, 39, 248, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_ResultLookupId",
                table: "Session",
                column: "ResultLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_StatusLookupId",
                table: "Session",
                column: "StatusLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainerLookupId",
                table: "Session",
                column: "TrainerLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainingTopicLookupId",
                table: "Session",
                column: "TrainingTopicLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Lookup_TrainingTypeLookupId",
                table: "Session",
                column: "TrainingTypeLookupId",
                principalTable: "Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
