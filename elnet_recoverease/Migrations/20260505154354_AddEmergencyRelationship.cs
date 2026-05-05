using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elnet_recoverease.Migrations
{
    /// <inheritdoc />
    public partial class AddEmergencyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmergencyRelationship",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 5, 23, 43, 51, 980, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 5, 23, 43, 51, 980, DateTimeKind.Local).AddTicks(4519));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmergencyRelationship",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 5, 22, 38, 4, 355, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 5, 22, 38, 4, 355, DateTimeKind.Local).AddTicks(9848));
        }
    }
}
