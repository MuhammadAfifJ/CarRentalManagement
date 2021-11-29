﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "d9f30e03-5411-46a3-a483-df2b51d92e74", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "18c564fb-123f-47b9-95b6-ce12eb0f1d94", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9f85beca-c3cf-49c9-81e5-57c3b1e5178a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAENi0QgJwBlaJrYsK0TiICjZJ9wtvBHObf7Vvd+5cdAGUBkHdspNrK0U3G7yPWv66ug==", null, false, "8afbc716-607e-4abf-8eda-aeaf8c6db57c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 11, 52, 29, 574, DateTimeKind.Local).AddTicks(9308), new DateTime(2021, 11, 23, 11, 52, 29, 575, DateTimeKind.Local).AddTicks(7230), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 11, 52, 29, 575, DateTimeKind.Local).AddTicks(8012), new DateTime(2021, 11, 23, 11, 52, 29, 575, DateTimeKind.Local).AddTicks(8017), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 11, 52, 29, 576, DateTimeKind.Local).AddTicks(7491), new DateTime(2021, 11, 23, 11, 52, 29, 576, DateTimeKind.Local).AddTicks(7497), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 11, 52, 29, 576, DateTimeKind.Local).AddTicks(7500), new DateTime(2021, 11, 23, 11, 52, 29, 576, DateTimeKind.Local).AddTicks(7501), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 11, 52, 29, 577, DateTimeKind.Local).AddTicks(714), new DateTime(2021, 11, 23, 11, 52, 29, 577, DateTimeKind.Local).AddTicks(718), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 11, 52, 29, 577, DateTimeKind.Local).AddTicks(721), new DateTime(2021, 11, 23, 11, 52, 29, 577, DateTimeKind.Local).AddTicks(722), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 23, 11, 52, 29, 577, DateTimeKind.Local).AddTicks(724), new DateTime(2021, 11, 23, 11, 52, 29, 577, DateTimeKind.Local).AddTicks(724), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 23, 11, 52, 29, 577, DateTimeKind.Local).AddTicks(726), new DateTime(2021, 11, 23, 11, 52, 29, 577, DateTimeKind.Local).AddTicks(726), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
