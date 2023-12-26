using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VPCT.Core.Migrations
{
    /// <inheritdoc />
    public partial class T : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "821afdde-c63e-4f04-aa79-f508ce9a9b17");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9dd39dd-8997-4333-832a-7915da51e24b", "6341d8af-6767-44da-9e92-1c83a61f7cd0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "935c4c95-40a4-4230-be02-a086f969adf2", "67507583-8f47-4797-a231-2eeb9886a519" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "935c4c95-40a4-4230-be02-a086f969adf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9dd39dd-8997-4333-832a-7915da51e24b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6341d8af-6767-44da-9e92-1c83a61f7cd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67507583-8f47-4797-a231-2eeb9886a519");

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

            migrationBuilder.InsertData(
                table: "CoQuanQuanLy",
                columns: new[] { "Id", "Address", "Fax", "Name", "PhoneNumber", "Type" },
                values: new object[,]
                {
                    { 4, "Bộ KH&CN", null, "Vụ Công nghệ cao", "04.35560648", "TaskManagement" },
                    { 5, "Bộ KH&CN", null, "Vụ Khoa học và Công nghệ các ngành kinh tế kỹ thuật", null, "TaskManagement" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "CoQuanQuanLy",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoQuanQuanLy",
                keyColumn: "Id",
                keyValue: 5);

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
                    { "821afdde-c63e-4f04-aa79-f508ce9a9b17", null, "KeToan", "KETOAN" },
                    { "935c4c95-40a4-4230-be02-a086f969adf2", null, "LanhDao", "LANHDAO" },
                    { "a9dd39dd-8997-4333-832a-7915da51e24b", null, "ChuyenVien", "CHUYENVIEN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FullName", "ImageName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6341d8af-6767-44da-9e92-1c83a61f7cd0", 0, null, "2499884b-1b2d-4612-9104-06b77196a2fd", null, "mm@mm.mm", true, "Hoang Khanh", null, false, null, "MM@MM.MM", "ADMIN13", "AQAAAAIAAYagAAAAEGchAwuqIKMf1/ruNi8X9nKR7jdUSc403/P91nScBBkgkGGvLIrffD8aASJLNLFFGg==", "01223456789", false, "42f923ff-e95f-430b-89a2-32d5e11ae139", false, "admin13" },
                    { "67507583-8f47-4797-a231-2eeb9886a519", 0, null, "a3d239cd-5c5c-40cd-8d73-ac4e0413f8f6", null, "aa@aa.aa", true, "Luu Minh", null, false, null, "AA@AA.AA", "ADMIN12", "AQAAAAIAAYagAAAAEEvKy4aHKBgFYK/AKx5BUPdoVL8xNjpf48TqX8XnCblcZa7oSG2DtIO11PltWV4sjg==", "01223456789", false, "ee121891-8d8e-407a-8a41-232c3597193e", false, "admin12" }
                });

            migrationBuilder.UpdateData(
                table: "CongVanNhiemVu",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateTime(2023, 12, 25, 12, 21, 27, 464, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 25, 12, 21, 27, 464, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "LanDieuChinh",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 25, 12, 21, 27, 464, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "LanKiemTra",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedTestDate",
                value: new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a9dd39dd-8997-4333-832a-7915da51e24b", "6341d8af-6767-44da-9e92-1c83a61f7cd0" },
                    { "935c4c95-40a4-4230-be02-a086f969adf2", "67507583-8f47-4797-a231-2eeb9886a519" }
                });
        }
    }
}
