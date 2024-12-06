using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HighLoadDevelopment.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Code", "Created_At", "Created_By", "Deleted_At", "Deleted_By", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "get_list_user", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(6939), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "get_list_user" },
                    { 2, "read_user", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7156), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "read_user" },
                    { 3, "create_user", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7158), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "create_user" },
                    { 4, "update_user", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7160), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "update_user" },
                    { 5, "delete_user", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7161), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "delete_user" },
                    { 6, "restore_user", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7162), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "restore_user" },
                    { 7, "get_list_role", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7163), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "get_list_role" },
                    { 8, "read_role", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7164), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "read_role" },
                    { 9, "create_role", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7166), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "create_role" },
                    { 10, "update_role", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7167), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "update_role" },
                    { 11, "delete_role", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7168), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "delete_role" },
                    { 12, "restore_role", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7169), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "restore_role" },
                    { 13, "get_list_permission", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7170), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "get_list_permission" },
                    { 14, "read_permission", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7171), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "read_permission" },
                    { 15, "create_permission", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7173), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "create_permission" },
                    { 16, "update_permission", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7174), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "update_permission" },
                    { 17, "delete_permission", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7176), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "delete_permission" },
                    { 18, "restore_permission", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7177), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "restore_permission" },
                    { 19, "get_story_user", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7178), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "get_story_user" },
                    { 20, "get_story_role", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7179), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "get_story_role" },
                    { 21, "get_story_permission", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7180), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "get_story_permission" },
                    { 22, "rollback_permission", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7181), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "rollback_permission" },
                    { 23, "rollback_role", new DateTime(2024, 11, 21, 12, 17, 30, 204, DateTimeKind.Utc).AddTicks(7183), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "rollback_role" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "Created_At", "Created_By", "Deleted_At", "Deleted_By", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2024, 11, 21, 12, 17, 30, 623, DateTimeKind.Utc).AddTicks(6406), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "Admin" },
                    { 2, "User", new DateTime(2024, 11, 21, 12, 17, 30, 623, DateTimeKind.Utc).AddTicks(6408), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "User" },
                    { 3, "Guest", new DateTime(2024, 11, 21, 12, 17, 30, 623, DateTimeKind.Utc).AddTicks(6410), new Guid("00000000-0000-0000-0000-000000000000"), null, null, null, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "RolesAndPermissions",
                columns: new[] { "PermissionId", "RoleId", "Created_At", "Created_By", "Deleted_At", "Deleted_By" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(535), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 2, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(537), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 3, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(538), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 4, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(539), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 5, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(540), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 6, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(541), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 7, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(543), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 8, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(544), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 9, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(545), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 10, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(546), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 11, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(547), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 12, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(548), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 13, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(549), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 14, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(550), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 15, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(551), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 16, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(552), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 17, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(553), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 18, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(554), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 19, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(555), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 20, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(557), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 21, 1, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(558), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 1, 2, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(559), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 4, 2, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(560), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 10, 2, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(561), new Guid("00000000-0000-0000-0000-000000000000"), null, null },
                    { 1, 3, new DateTime(2024, 11, 21, 12, 17, 30, 625, DateTimeKind.Utc).AddTicks(562), new Guid("00000000-0000-0000-0000-000000000000"), null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "RolesAndPermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
