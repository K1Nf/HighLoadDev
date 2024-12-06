using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HighLoadDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCommentsPK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Comments",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 235, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 680, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 680, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 680, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 31, 56, 681, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MeetingId",
                table: "Comments",
                column: "MeetingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MeetingId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Comments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                columns: new[] { "MeetingId", "UserId" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 48, 279, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 9, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 9, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 9, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 },
                column: "Created_At",
                value: new DateTime(2024, 11, 28, 7, 18, 49, 12, DateTimeKind.Utc).AddTicks(846));
        }
    }
}
