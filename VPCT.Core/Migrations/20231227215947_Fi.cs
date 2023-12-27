using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VPCT.Core.Migrations
{
    /// <inheritdoc />
    public partial class Fi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e77a455c-05e0-4fa3-9840-576528f97539");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a91105e-6ec3-420e-824c-0eadf7c50ce9", "345cf02d-3757-4213-bdb9-1eb9ddab01e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "edfbc4fe-ad76-411f-b6e3-47dcb8c7242a", "58332a1c-aba4-4c93-ad31-919d19c32bb7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a91105e-6ec3-420e-824c-0eadf7c50ce9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edfbc4fe-ad76-411f-b6e3-47dcb8c7242a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "345cf02d-3757-4213-bdb9-1eb9ddab01e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58332a1c-aba4-4c93-ad31-919d19c32bb7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96069953-eb27-44b7-a8a9-b2a78bc61fbc", null, "LanhDao", "LANHDAO" },
                    { "df6e95ad-fc03-44a2-bcd6-8e4ce279e51c", null, "ChuyenVien", "CHUYENVIEN" },
                    { "e5d44ddd-8b63-4505-9116-aa898d7d30ed", null, "KeToan", "KETOAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FullName", "ImageName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9336a2a2-7885-47ab-aeb8-1e7e399d91ea", 0, null, "cba5b6ff-846e-4d48-8362-981aca132fe1", null, "mm@mm.mm", true, "Hoang Khanh", null, false, null, "MM@MM.MM", "ADMIN13", "AQAAAAIAAYagAAAAEGXmRPkMmtfgY5dlYNDmGAcaQxEgqT0iU/TojCCO0xEj6ux2QgjiI6SY04ZGloeu9Q==", "01223456789", false, "3a272654-7dd4-4e50-9030-f1fd29c0ba5c", false, "admin13" },
                    { "b4c360ab-583e-4e1d-a049-d5619cb5fba2", 0, null, "5bb56405-5568-455c-9b9d-b597d2d49ec6", null, "aa@aa.aa", true, "Luu Minh", null, false, null, "AA@AA.AA", "ADMIN12", "AQAAAAIAAYagAAAAEGdWyxYwdEDOA2Vo3Q/w17oqJ7tmw3ZkzKCa8iaKc7tDkSU2PisfCH4HrU8KOMgACQ==", "01223456789", false, "0258ddef-4bdb-43d9-a97a-90b43447da84", false, "admin12" }
                });

            migrationBuilder.UpdateData(
                table: "CongVanNhiemVu",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2023, 12, 28, 4, 59, 45, 867, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 28, 4, 59, 45, 867, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 28, 4, 59, 45, 867, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "df6e95ad-fc03-44a2-bcd6-8e4ce279e51c", "9336a2a2-7885-47ab-aeb8-1e7e399d91ea" },
                    { "96069953-eb27-44b7-a8a9-b2a78bc61fbc", "b4c360ab-583e-4e1d-a049-d5619cb5fba2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5d44ddd-8b63-4505-9116-aa898d7d30ed");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df6e95ad-fc03-44a2-bcd6-8e4ce279e51c", "9336a2a2-7885-47ab-aeb8-1e7e399d91ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96069953-eb27-44b7-a8a9-b2a78bc61fbc", "b4c360ab-583e-4e1d-a049-d5619cb5fba2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96069953-eb27-44b7-a8a9-b2a78bc61fbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df6e95ad-fc03-44a2-bcd6-8e4ce279e51c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9336a2a2-7885-47ab-aeb8-1e7e399d91ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c360ab-583e-4e1d-a049-d5619cb5fba2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a91105e-6ec3-420e-824c-0eadf7c50ce9", null, "LanhDao", "LANHDAO" },
                    { "e77a455c-05e0-4fa3-9840-576528f97539", null, "KeToan", "KETOAN" },
                    { "edfbc4fe-ad76-411f-b6e3-47dcb8c7242a", null, "ChuyenVien", "CHUYENVIEN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FullName", "ImageName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "345cf02d-3757-4213-bdb9-1eb9ddab01e7", 0, null, "3906ff0d-6d64-4463-ba44-906929ea23f2", null, "aa@aa.aa", true, "Luu Minh", null, false, null, "AA@AA.AA", "ADMIN12", "AQAAAAIAAYagAAAAEMDI7xFncavvlc13mIaYIAlr8uFYJcz04EQHlQTnDwVO6YONaLZUGxVwWTEyeWrIoQ==", "01223456789", false, "0016e6cb-29b7-4247-b686-83e8210827b6", false, "admin12" },
                    { "58332a1c-aba4-4c93-ad31-919d19c32bb7", 0, null, "9ed13a89-d24a-4527-ae71-6a22c608e714", null, "mm@mm.mm", true, "Hoang Khanh", null, false, null, "MM@MM.MM", "ADMIN13", "AQAAAAIAAYagAAAAEKG1/EkIzfa/j4vRlVimxiI4cBC6I0aEYOmooH7wxn3VSr2DpZ4Rr114ZqfzotdRdQ==", "01223456789", false, "f92e4e5e-fbdc-44af-ad57-25e38a8930dd", false, "admin13" }
                });

            migrationBuilder.UpdateData(
                table: "CongVanNhiemVu",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2023, 12, 26, 9, 39, 20, 916, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 26, 9, 39, 20, 916, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 26, 9, 39, 20, 916, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0a91105e-6ec3-420e-824c-0eadf7c50ce9", "345cf02d-3757-4213-bdb9-1eb9ddab01e7" },
                    { "edfbc4fe-ad76-411f-b6e3-47dcb8c7242a", "58332a1c-aba4-4c93-ad31-919d19c32bb7" }
                });
        }
    }
}
