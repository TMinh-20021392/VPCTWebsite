using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VPCT.Core.Migrations
{
    /// <inheritdoc />
    public partial class F : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucDanh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucDanh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoQuanQuanLy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoQuanQuanLy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DangSanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangSanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonViChuQuan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonViChuQuan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiaiDoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<int>(type: "int", nullable: false),
                    End = table.Column<int>(type: "int", nullable: false),
                    Default = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaiDoan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocHam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocHam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocVi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinhVuc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhVuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiChuongTrinh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPeriodic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiChuongTrinh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DangSanPhamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoaiSanPham_DangSanPham_DangSanPhamId",
                        column: x => x.DangSanPhamId,
                        principalTable: "DangSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoQuanChuTri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEnterprise = table.Column<bool>(type: "bit", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonViChuQuanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoQuanChuTri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoQuanChuTri_DonViChuQuan_DonViChuQuanId",
                        column: x => x.DonViChuQuanId,
                        principalTable: "DonViChuQuan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenNganh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinhVucId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenNganh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChuyenNganh_LinhVuc_LinhVucId",
                        column: x => x.LinhVucId,
                        principalTable: "LinhVuc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChuongTrinh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaChuongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiChuongTrinhId = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: true),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    KinhPhi = table.Column<double>(type: "float", nullable: false),
                    CoQuanChuTriId = table.Column<int>(type: "int", nullable: true),
                    Objective = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Criteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    President = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VicePresident = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member_Secretary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admin_Secretary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaiDoanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuongTrinh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChuongTrinh_CoQuanChuTri_CoQuanChuTriId",
                        column: x => x.CoQuanChuTriId,
                        principalTable: "CoQuanChuTri",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuongTrinh_GiaiDoan_GiaiDoanId",
                        column: x => x.GiaiDoanId,
                        principalTable: "GiaiDoan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuongTrinh_LoaiChuongTrinh_LoaiChuongTrinhId",
                        column: x => x.LoaiChuongTrinhId,
                        principalTable: "LoaiChuongTrinh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChuongTrinh_CoQuanQuanLy",
                columns: table => new
                {
                    ChuongTrinhId = table.Column<int>(type: "int", nullable: false),
                    CoQuanQuanLyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuongTrinh_CoQuanQuanLy", x => new { x.ChuongTrinhId, x.CoQuanQuanLyId });
                    table.ForeignKey(
                        name: "FK_ChuongTrinh_CoQuanQuanLy_ChuongTrinh_ChuongTrinhId",
                        column: x => x.ChuongTrinhId,
                        principalTable: "ChuongTrinh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuongTrinh_CoQuanQuanLy_CoQuanQuanLy_CoQuanQuanLyId",
                        column: x => x.CoQuanQuanLyId,
                        principalTable: "CoQuanQuanLy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenGia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuongTrinhId = table.Column<int>(type: "int", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucDanhId = table.Column<int>(type: "int", nullable: true),
                    HocHamId = table.Column<int>(type: "int", nullable: true),
                    ChucVuId = table.Column<int>(type: "int", nullable: true),
                    HocViId = table.Column<int>(type: "int", nullable: true),
                    CoQuanChuTriId = table.Column<int>(type: "int", nullable: true),
                    DonViChuQuanId = table.Column<int>(type: "int", nullable: true),
                    ChuyenNganhId = table.Column<int>(type: "int", nullable: true),
                    LinhVucId = table.Column<int>(type: "int", nullable: true),
                    Ex_Info_Participation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ex_Info_Field = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenGia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChuyenGia_ChucDanh_ChucDanhId",
                        column: x => x.ChucDanhId,
                        principalTable: "ChucDanh",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenGia_ChucVu_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "ChucVu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenGia_ChuongTrinh_ChuongTrinhId",
                        column: x => x.ChuongTrinhId,
                        principalTable: "ChuongTrinh",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenGia_ChuyenNganh_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganh",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenGia_CoQuanChuTri_CoQuanChuTriId",
                        column: x => x.CoQuanChuTriId,
                        principalTable: "CoQuanChuTri",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenGia_DonViChuQuan_DonViChuQuanId",
                        column: x => x.DonViChuQuanId,
                        principalTable: "DonViChuQuan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenGia_HocHam_HocHamId",
                        column: x => x.HocHamId,
                        principalTable: "HocHam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenGia_HocVi_HocViId",
                        column: x => x.HocViId,
                        principalTable: "HocVi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuyenGia_LinhVuc_LinhVucId",
                        column: x => x.LinhVucId,
                        principalTable: "LinhVuc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AnPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TapChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    ChuyenGiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnPham_ChuyenGia_ChuyenGiaId",
                        column: x => x.ChuyenGiaId,
                        principalTable: "ChuyenGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongTrinh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scope_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    ChuyenGiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTrinh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongTrinh_ChuyenGia_ChuyenGiaId",
                        column: x => x.ChuyenGiaId,
                        principalTable: "ChuyenGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiaiThuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    ChuyenGiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaiThuong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaiThuong_ChuyenGia_ChuyenGiaId",
                        column: x => x.ChuyenGiaId,
                        principalTable: "ChuyenGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoatDongKhac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuyenGiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoatDongKhac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoatDongKhac_ChuyenGia_ChuyenGiaId",
                        column: x => x.ChuyenGiaId,
                        principalTable: "ChuyenGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KinhNghiem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoQuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: true),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    KinhPhi = table.Column<double>(type: "float", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuyenGiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KinhNghiem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KinhNghiem_ChuyenGia_ChuyenGiaId",
                        column: x => x.ChuyenGiaId,
                        principalTable: "ChuyenGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhiemVu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNhiemVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresidentId = table.Column<int>(type: "int", nullable: false),
                    ChuongTrinhId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoQuanChuTriId = table.Column<int>(type: "int", nullable: true),
                    LinhVucId = table.Column<int>(type: "int", nullable: true),
                    ChuyenNganhId = table.Column<int>(type: "int", nullable: true),
                    StartDate_Month = table.Column<int>(type: "int", nullable: true),
                    StartDate_Year = table.Column<int>(type: "int", nullable: true),
                    EndDate_Month = table.Column<int>(type: "int", nullable: true),
                    EndDate_Year = table.Column<int>(type: "int", nullable: true),
                    NgiemThu_Month = table.Column<int>(type: "int", nullable: true),
                    NgiemThu_Year = table.Column<int>(type: "int", nullable: true),
                    CoQuanQuanLyKinhPhiId = table.Column<int>(type: "int", nullable: true),
                    VPCT_Leader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accounting_Specialist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Planning_Specialist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoQuanQuanLyNhiemVuId = table.Column<int>(type: "int", nullable: true),
                    DepartmentAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentAdminSpecialist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucTieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundingPlan_FirstYearMonths = table.Column<int>(type: "int", nullable: true),
                    FundingPlan_SecondYearMonths = table.Column<int>(type: "int", nullable: true),
                    FundingPlan_ThirdYearMonths = table.Column<int>(type: "int", nullable: true),
                    FundingPlan_FourthYearMonths = table.Column<int>(type: "int", nullable: true),
                    FundingPlan_FifteenYearMonths = table.Column<int>(type: "int", nullable: true),
                    FundingPlan_SixthYearMonths = table.Column<int>(type: "int", nullable: true),
                    FundingPlan_FirstYear = table.Column<double>(type: "float", nullable: true),
                    FundingPlan_SecondYear = table.Column<double>(type: "float", nullable: true),
                    FundingPlan_ThirdYear = table.Column<double>(type: "float", nullable: true),
                    FundingPlan_FourthYear = table.Column<double>(type: "float", nullable: true),
                    FundingPlan_FifthYear = table.Column<double>(type: "float", nullable: true),
                    FundingPlan_SixthYear = table.Column<double>(type: "float", nullable: true),
                    ThueKhoanChuyenMon_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    ThueKhoanChuyenMon_Khac = table.Column<double>(type: "float", nullable: true),
                    HoTroCongNghe_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    HoTroCongNghe_Khac = table.Column<double>(type: "float", nullable: true),
                    ChiPhiLaoDong_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    ChiPhiLaoDong_Khac = table.Column<double>(type: "float", nullable: true),
                    NguyenVatLieu_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    NguyenVatLieu_Khac = table.Column<double>(type: "float", nullable: true),
                    ThietBiMayMoc_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    ThietBiMayMoc_Khac = table.Column<double>(type: "float", nullable: true),
                    MuaMoi_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    MuaMoi_Khac = table.Column<double>(type: "float", nullable: true),
                    Thue_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    Thue_Khac = table.Column<double>(type: "float", nullable: true),
                    XayDungSuaChuaNho_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    XayDungSuaChuaNho_Khac = table.Column<double>(type: "float", nullable: true),
                    ChiPhiKhac_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    ChiPhiKhac_Khac = table.Column<double>(type: "float", nullable: true),
                    HTQT_NganSachNhaNuoc = table.Column<double>(type: "float", nullable: true),
                    HTQT_Khac = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_FirstYear_FirstTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FirstYear_FirstTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FirstYear_FirstTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_FirstYear_SecondTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FirstYear_SecondTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FirstYear_SecondTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_SecondYear_FirstTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_SecondYear_FirstTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_SecondYear_FirstTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_SecondYear_SecondTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_SecondYear_SecondTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_SecondYear_SecondTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_ThirdYear_FirstTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_ThirdYear_FirstTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_ThirdYear_FirstTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_ThirdYear_SecondTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_ThirdYear_SecondTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_ThirdYear_SecondTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_FourthYear_FirstTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FourthYear_FirstTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FourthYear_FirstTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_FourthYear_SecondTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FourthYear_SecondTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FourthYear_SecondTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_FifthYear_FirstTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FifthYear_FirstTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FifthYear_FirstTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_FifthYear_SecondTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FifthYear_SecondTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_FifthYear_SecondTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_SixthYear_FirstTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_SixthYear_FirstTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_SixthYear_FirstTime = table.Column<double>(type: "float", nullable: true),
                    ThucTeCapKinhPhi_SixthYear_SecondTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_SixthYear_SecondTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThucTeCapKinhPhi_SixthYear_SecondTime = table.Column<double>(type: "float", nullable: true),
                    TongKinhPhiThuHoi = table.Column<double>(type: "float", nullable: true),
                    ThuHoiKinhPhi_FirstTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThuHoiKinhPhi_FirstTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThuHoiKinhPhi_FirstTime = table.Column<double>(type: "float", nullable: true),
                    ThuHoiKinhPhi_SecondTime_Month = table.Column<int>(type: "int", nullable: true),
                    ThuHoiKinhPhi_SecondTime_Year = table.Column<int>(type: "int", nullable: true),
                    ThuHoiKinhPhi_SecondTime = table.Column<double>(type: "float", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HieuQua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KetQua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanXet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanhLyTaiSan = table.Column<bool>(type: "bit", nullable: true),
                    PhuongAnThanhLyTaiSan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanhLyHopDong = table.Column<bool>(type: "bit", nullable: true),
                    PhuongAnThanhLyHopDong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhiemVu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhiemVu_ChuongTrinh_ChuongTrinhId",
                        column: x => x.ChuongTrinhId,
                        principalTable: "ChuongTrinh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhiemVu_ChuyenGia_PresidentId",
                        column: x => x.PresidentId,
                        principalTable: "ChuyenGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhiemVu_ChuyenNganh_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganh",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NhiemVu_CoQuanChuTri_CoQuanChuTriId",
                        column: x => x.CoQuanChuTriId,
                        principalTable: "CoQuanChuTri",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NhiemVu_CoQuanQuanLy_CoQuanQuanLyKinhPhiId",
                        column: x => x.CoQuanQuanLyKinhPhiId,
                        principalTable: "CoQuanQuanLy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NhiemVu_CoQuanQuanLy_CoQuanQuanLyNhiemVuId",
                        column: x => x.CoQuanQuanLyNhiemVuId,
                        principalTable: "CoQuanQuanLy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NhiemVu_LinhVuc_LinhVucId",
                        column: x => x.LinhVucId,
                        principalTable: "LinhVuc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VanBang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ChuyenGiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VanBang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VanBang_ChuyenGia_ChuyenGiaId",
                        column: x => x.ChuyenGiaId,
                        principalTable: "ChuyenGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaNhanThamGia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocHamId = table.Column<int>(type: "int", nullable: true),
                    HocViId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaNhanThamGia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaNhanThamGia_HocHam_HocHamId",
                        column: x => x.HocHamId,
                        principalTable: "HocHam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaNhanThamGia_HocVi_HocViId",
                        column: x => x.HocViId,
                        principalTable: "HocVi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaNhanThamGia_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongVanNhiemVu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoCongVan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrichYeu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocTypeId = table.Column<int>(type: "int", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongVanNhiemVu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongVanNhiemVu_DocType_DocTypeId",
                        column: x => x.DocTypeId,
                        principalTable: "DocType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CongVanNhiemVu_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoQuanChuTri_NhiemVu",
                columns: table => new
                {
                    NhiemVuId = table.Column<int>(type: "int", nullable: false),
                    DonViChuQuanId = table.Column<int>(type: "int", nullable: false),
                    CoQuanChuTriId = table.Column<int>(type: "int", nullable: false),
                    Filer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoQuanChuTri_NhiemVu", x => new { x.NhiemVuId, x.DonViChuQuanId, x.CoQuanChuTriId });
                    table.ForeignKey(
                        name: "FK_CoQuanChuTri_NhiemVu_CoQuanChuTri_CoQuanChuTriId",
                        column: x => x.CoQuanChuTriId,
                        principalTable: "CoQuanChuTri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoQuanChuTri_NhiemVu_DonViChuQuan_DonViChuQuanId",
                        column: x => x.DonViChuQuanId,
                        principalTable: "DonViChuQuan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoQuanChuTri_NhiemVu_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonViChuQuan_NhiemVu",
                columns: table => new
                {
                    DonViChuQuanId = table.Column<int>(type: "int", nullable: false),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false),
                    Filer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonViChuQuan_NhiemVu", x => new { x.NhiemVuId, x.DonViChuQuanId });
                    table.ForeignKey(
                        name: "FK_DonViChuQuan_NhiemVu_DonViChuQuan_DonViChuQuanId",
                        column: x => x.DonViChuQuanId,
                        principalTable: "DonViChuQuan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonViChuQuan_NhiemVu_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileDinhKem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileTypeId = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDinhKem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileDinhKem_FileType_FileTypeId",
                        column: x => x.FileTypeId,
                        principalTable: "FileType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FileDinhKem_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoiDongKhoaHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoiDongKhoaHoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoiDongKhoaHoc_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanDieuChinh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KinhPhi = table.Column<double>(type: "float", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Khac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanDieuChinh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanDieuChinh_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanKiemTra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstimatedTestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TesterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasTested = table.Column<bool>(type: "bit", nullable: true),
                    TestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalCost = table.Column<double>(type: "float", nullable: true),
                    KetLuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanKiemTra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanKiemTra_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YeuCau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    IsSucceeded = table.Column<bool>(type: "bit", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherProducts_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ownership",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiSanPhamId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    IsSucceeded = table.Column<bool>(type: "bit", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ownership", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ownership_LoaiSanPham_LoaiSanPhamId",
                        column: x => x.LoaiSanPhamId,
                        principalTable: "LoaiSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ownership_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanBoNoiDung",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: true),
                    KinhPhi = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanBoNoiDung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhanBoNoiDung_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_I",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiSanPhamId = table.Column<int>(type: "int", nullable: true),
                    PriceUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredQualityLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estimation = table.Column<double>(type: "float", nullable: true),
                    IsLocal = table.Column<bool>(type: "bit", nullable: true),
                    IsForeign = table.Column<bool>(type: "bit", nullable: true),
                    SocioEconomicEfficiency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConsumed = table.Column<bool>(type: "bit", nullable: false),
                    ConsumingQuantity = table.Column<int>(type: "int", nullable: false),
                    ConsumingAmount = table.Column<double>(type: "float", nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryQuantity = table.Column<int>(type: "int", nullable: false),
                    DeliveryAmount = table.Column<double>(type: "float", nullable: false),
                    ServiceProvisionContract = table.Column<bool>(type: "bit", nullable: false),
                    ContractNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractAmount = table.Column<double>(type: "float", nullable: false),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    IsSucceeded = table.Column<bool>(type: "bit", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_I", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_I_LoaiSanPham_LoaiSanPhamId",
                        column: x => x.LoaiSanPhamId,
                        principalTable: "LoaiSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_I_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_II",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiSanPhamId = table.Column<int>(type: "int", nullable: false),
                    YeuCau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocioEconomicEfficiency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConsumed = table.Column<bool>(type: "bit", nullable: false),
                    ConsumingQuantity = table.Column<int>(type: "int", nullable: false),
                    ConsumingAmount = table.Column<double>(type: "float", nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false),
                    DeliveryQuantity = table.Column<int>(type: "int", nullable: false),
                    DeliveryAmount = table.Column<double>(type: "float", nullable: false),
                    ServiceProvisionContract = table.Column<bool>(type: "bit", nullable: false),
                    ContractNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractAmount = table.Column<double>(type: "float", nullable: false),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    IsSucceeded = table.Column<bool>(type: "bit", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_II", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_II_LoaiSanPham_LoaiSanPhamId",
                        column: x => x.LoaiSanPhamId,
                        principalTable: "LoaiSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_II_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_III",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiSanPhamId = table.Column<int>(type: "int", nullable: false),
                    YeuCau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    IsSucceeded = table.Column<bool>(type: "bit", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_III", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_III_LoaiSanPham_LoaiSanPhamId",
                        column: x => x.LoaiSanPhamId,
                        principalTable: "LoaiSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_III_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_PostgraduateTraining",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: true),
                    ChuyenNganhId = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    IsSucceeded = table.Column<bool>(type: "bit", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_PostgraduateTraining", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_PostgraduateTraining_ChuyenNganh_ChuyenNganhId",
                        column: x => x.ChuyenNganhId,
                        principalTable: "ChuyenNganh",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_PostgraduateTraining_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThanhLapDoanhNghiep",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenVietTat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    NhiemVuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhLapDoanhNghiep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThanhLapDoanhNghiep_NhiemVu_NhiemVuId",
                        column: x => x.NhiemVuId,
                        principalTable: "NhiemVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoiDongKhoaHoc_ChuyenGia",
                columns: table => new
                {
                    ChuyenGiaId = table.Column<int>(type: "int", nullable: false),
                    HoiDongKhoaHocId = table.Column<int>(type: "int", nullable: false),
                    ChucDanh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoiDongKhoaHoc_ChuyenGia", x => new { x.HoiDongKhoaHocId, x.ChuyenGiaId });
                    table.ForeignKey(
                        name: "FK_HoiDongKhoaHoc_ChuyenGia_ChuyenGia_ChuyenGiaId",
                        column: x => x.ChuyenGiaId,
                        principalTable: "ChuyenGia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoiDongKhoaHoc_ChuyenGia_HoiDongKhoaHoc_HoiDongKhoaHocId",
                        column: x => x.HoiDongKhoaHocId,
                        principalTable: "HoiDongKhoaHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52f818bf-fcf1-4e33-bf5c-856c1c62b82b", null, "KeToan", "KETOAN" },
                    { "785a36b9-eb58-483f-98f0-17966569c04d", null, "ChuyenVien", "CHUYENVIEN" },
                    { "ce837422-6bbd-43bc-8d1a-3f370fd2ec92", null, "LanhDao", "LANHDAO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "FullName", "ImageName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0788d7dd-b47d-4816-a185-b00f08aa1fdc", 0, null, "c2bb367f-1b89-4d44-bae5-67d71604327e", null, "mm@mm.mm", true, "Hoang Khanh", null, false, null, "MM@MM.MM", "ADMIN13", "AQAAAAIAAYagAAAAELNEE36j3rWrOrS6vYDaZZLSUkM8ANNe3zD7ZDIrHpQ5C6Iq7ALT16PeKyWrSxEgfw==", "01223456789", false, "38dc3ca5-29ca-4d2a-b132-c07f7c833445", false, "admin13" },
                    { "1f8e0d55-d235-4774-aa2c-73eeadea0e85", 0, null, "c0997275-935d-41f8-9388-0c40bc753d8b", null, "aa@aa.aa", true, "Luu Minh", null, false, null, "AA@AA.AA", "ADMIN12", "AQAAAAIAAYagAAAAEHvuJHY6519r5KvN7bO1kPIBh2NKSizCmyJzWgKAXtY+wxdQldsVTGsG27OTCw4p4Q==", "01223456789", false, "9b360bf9-d581-4131-a08e-cf4c045f56db", false, "admin12" }
                });

            migrationBuilder.InsertData(
                table: "ChucDanh",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Thứ trưởng" },
                    { 2, "Vụ trưởng" },
                    { 3, "Giáo sư" }
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nguyên Quyền Giám đốc" },
                    { 2, "Trưởng Bộ môn" },
                    { 3, "Liên đoàn trưởng" }
                });

            migrationBuilder.InsertData(
                table: "CoQuanQuanLy",
                columns: new[] { "Id", "Address", "Fax", "Name", "PhoneNumber", "Type" },
                values: new object[,]
                {
                    { 1, "Tâng 12, Bộ KH&CN", null, "Văn phòng các Chương trình trọng điểm cấp nhà nước", null, "CostMangement" },
                    { 2, "Bộ KH&CN", null, "Vụ Phát triển khoa học và công nghệ địa phương", "069.516.153", "TaskManagement" },
                    { 3, "Bộ KH&CN", null, "Vụ Khoa học Xã hội, Nhân văn và Tự nhiên", null, "TaskManagement" }
                });

            migrationBuilder.InsertData(
                table: "DangSanPham",
                columns: new[] { "Id", "MoTa", "Name" },
                values: new object[,]
                {
                    { 1, "Mẫu (model, maket); Sản phẩm (là hàng hóa có thể tiêu thụ trên thị trường); Vật liệu; Thiết bị máy móc; Dây chuyền công nghệ; Giống vật nuôi; Giống cây trồng và các loại khác", "Dạng I" },
                    { 2, "Nguyên lý ứng dụng; Phương pháp; Tiêu chuẩn, Quy Phạm; Phần mềm máy tính; Bản vẽ thiết kế; Sơ đồ, bản đồ; Số liệu; Cơ sở dữ liệu; Báo cáo phân tích; Tài liệu dự báo (Phương pháp, quy trình, mô hình...) Đề án quy hoạch; Luận chứng kinh tế - kỹ thuật, Báo cáo nghiên cứu khả thi và các sản phẩm khác", "Dạng II" },
                    { 3, null, "Dạng III" },
                    { 4, "Các sản phẩm không xếp vào các dạng cụ thể", "Dạng khác" },
                    { 5, null, "Quyền sở hữu" },
                    { 6, null, "Đào tạo sau đại học" }
                });

            migrationBuilder.InsertData(
                table: "DocType",
                columns: new[] { "Id", "MoTa", "Name" },
                values: new object[,]
                {
                    { 1, null, "Công văn đến" },
                    { 2, null, "Công văn đi" }
                });

            migrationBuilder.InsertData(
                table: "DonViChuQuan",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tổ chức xã hội - nghề nghiệp" },
                    { 2, "Sở Khoa học và Công nghệ Tỉnh Lâm Đồng" }
                });

            migrationBuilder.InsertData(
                table: "FileType",
                columns: new[] { "Id", "MoTa", "Name" },
                values: new object[,]
                {
                    { 1, "Biên bản kiểm tra tiến độ đề tài theo định kỳ", "Biên bản kiểm tra định kỳ" },
                    { 2, null, "Thuyết minh nhiệm vụ" }
                });

            migrationBuilder.InsertData(
                table: "GiaiDoan",
                columns: new[] { "Id", "Default", "End", "Start" },
                values: new object[,]
                {
                    { 1, false, 2010, 2006 },
                    { 2, false, 2015, 2011 },
                    { 3, true, 2020, 2016 },
                    { 4, false, 2025, 2015 }
                });

            migrationBuilder.InsertData(
                table: "HocHam",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "KS" },
                    { 2, "TS" },
                    { 3, "ThS" }
                });

            migrationBuilder.InsertData(
                table: "HocVi",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "KS" },
                    { 2, "TS" },
                    { 3, "ThS" },
                    { 4, "KSC" },
                    { 5, "bác sĩ" }
                });

            migrationBuilder.InsertData(
                table: "LinhVuc",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tâm lý học" },
                    { 2, "Năng lượng nguyên tử" },
                    { 3, "Cơ khí tự động hóa, Công nghệ vật liệu, AN-QP" },
                    { 4, "Đo lường" }
                });

            migrationBuilder.InsertData(
                table: "LoaiChuongTrinh",
                columns: new[] { "Id", "IsPeriodic", "Name" },
                values: new object[,]
                {
                    { 1, false, "Chương trình độc lập quỹ gen" },
                    { 2, true, "Chương trình trọng điểm cấp nhà nước" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "785a36b9-eb58-483f-98f0-17966569c04d", "0788d7dd-b47d-4816-a185-b00f08aa1fdc" },
                    { "ce837422-6bbd-43bc-8d1a-3f370fd2ec92", "1f8e0d55-d235-4774-aa2c-73eeadea0e85" }
                });

            migrationBuilder.InsertData(
                table: "ChuyenNganh",
                columns: new[] { "Id", "LinhVucId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Văn phòng các Chương trình trọng điểm cấp nhà nước" },
                    { 2, 2, "Vụ Phát triển khoa học và công nghệ địa phương" },
                    { 3, 1, "Vụ Khoa học Xã hội, Nhân văn và Tự nhiên" }
                });

            migrationBuilder.InsertData(
                table: "CoQuanChuTri",
                columns: new[] { "Id", "Address", "DonViChuQuanId", "Fax", "IsEnterprise", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Thành phố Quảng Ngãi, tỉnh Quảng Ngãi", 1, null, true, "Công ty TNHH Khoa học và công nghệ Nông Tín", null },
                    { 2, null, 2, null, false, "Viện Vật lý kỹ thuật", "069.516.153" },
                    { 3, "762 Cách mạng tháng Tám, phường Long Toàn, Thành phố Bà Rịa, Tỉnh Bà Rịa Vũng Tàu", 2, "0254 3733 579", false, "Trường Đại học Dầu Khí Việt Nam", "2543.738879" }
                });

            migrationBuilder.InsertData(
                table: "LoaiSanPham",
                columns: new[] { "Id", "DangSanPhamId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Mẫu (Model, maket)" },
                    { 2, 1, "Sản phẩm (là hàng hóa có thể tiêu thụ trên thị trường)" },
                    { 3, 2, "Nguyên lý ứng dụng" },
                    { 4, 3, "Bài báo đăng trong nước" },
                    { 5, 5, "Sáng chế/ giải pháp hữu ích" },
                    { 6, 6, "Thạc sĩ" }
                });

            migrationBuilder.InsertData(
                table: "ChuongTrinh",
                columns: new[] { "Id", "Admin_Secretary", "CoQuanChuTriId", "Criteria", "EndYear", "GhiChu", "GiaiDoanId", "IsPublished", "KinhPhi", "LoaiChuongTrinhId", "MaChuongTrinh", "Member1", "Member2", "Member3", "Member_Secretary", "Name", "NoiDung", "Objective", "President", "Product", "StartYear", "VicePresident" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, null, null, false, 0.0, 1, "16", null, null, null, null, "Khoa học Thông tin", null, null, null, null, null, null },
                    { 2, "Lê Thị Hải Yến", 2, "1.	  Chỉ tiêu về trình độ khoa học: 90% đề tài/dự án có kết quả được công bố trên các tạp chí khoa học công nghệ có uy tín quốc gia; ít nhất 10% đề tài có kết quả được công bố trên các tạp chí khoa học công nghệ quốc tế. \r\n2.	  Chỉ tiêu về trình độ công nghệ: các thiết bị là sản phẩm mới có tính năng kỹ thuật, kiểu dáng, chất lượng và giá cả có khả năng cạnh tranh với các sản phẩm cùng loại của các nước trong khu vực.\r\n3.	  Chỉ tiêu sở hữu trí tuệ: Có ít nhất 10% số nhiệm vụ có giải pháp được công nhận sáng chế hoặc giải pháp hữu ích, 15% số nhiệm vụ đã được chấp nhận đơn yêu cầu bảo hộ sở hữu công nghiệp.\r\n4.	  Chỉ tiêu về đào tạo: 70% số đề tài đào tạo được hoặc đang đào tạo ít nhất 1 tiến sĩ và 1 thạc sĩ (hoặc nhiều cử nhân /kỹ sư); 50 % số dự án đào tạo được ít nhất 1 thạc sĩ (hoặc nhiều cử nhân/kỹ sư). \r\n5.	Chỉ tiêu về cơ cấu nhiệm vụ khi kết thúc chương trình:\r\n-	40% nhiệm vụ nghiên cứu có kết quả là các công nghệ ứng dụng trong các ngành KT-KT ở giai đoạn tiếp theo.\r\n-	30% nhiệm vụ nghiên cứu có kết quả được ứng dụng phục vụ trực tiếp cho sản xuất, kinh doanh (kết thúc giai đoạn sản xuất thử nghiệm).\r\n-	30% nhiệm vụ nghiên cứu có kết quả được ứng dụng rộng rãi trong sản xuất - đời sống hoặc được thương mại hoá.", null, null, 1, false, 0.0, 2, "KC.07/06-10", null, null, null, "Nguyễn Đức Long", "Nghiên cứu ứng dụng và phát triển công nghệ phục vụ công nghiệp hóa, hiện đại hóa nông nghiệp và nông thôn.", "1.	Ứng dụng và chuyển giao được các công nghệ tiên tiến và thiết bị phù hợp vào sản xuất nông, lâm, ngư nghiệp; bảo quản và chế biến nông-lâm-thủy sản và ngành nghề nông thôn nhằm xây dựng một nền nông nghiệp hàng hóa có khả năng cạnh tranh cao.\r\n2.	Góp phần nâng cao năng suất lao động, nâng cao năng suất và chất lượng sản phẩm, đảm bảo hiệu quả, phát triển bền vững trong sản xuất nông-lâm-ngư nghiệp; thúc đẩy chuyển dịch cơ cấu kinh tế nông nghiệp nông thôn theo hướng tăng dần tỷ trọng công nghiệp, dịch vụ, tạo việc làm và tăng thu nhập cho người dân nông thôn.", "1.	Ứng dụng và chuyển giao được các công nghệ tiên tiến và thiết bị phù hợp vào sản xuất nông, lâm, ngư nghiệp; bảo quản và chế biến nông-lâm-thủy sản và ngành nghề nông thôn nhằm xây dựng một nền nông nghiệp hàng hóa có khả năng cạnh tranh cao.\r\n2.	Góp phần nâng cao năng suất lao động, nâng cao năng suất và chất lượng sản phẩm, đảm bảo hiệu quả, phát triển bền vững trong sản xuất nông-lâm-ngư nghiệp; thúc đẩy chuyển dịch cơ cấu kinh tế nông nghiệp nông thôn theo hướng tăng dần tỷ trọng công nghiệp, dịch vụ, tạo việc làm và tăng thu nhập cho người dân nông thôn.", "Phan Thanh Tịnh", "1.	Công nghệ tiên tiến và thiết bị phù hợp được ứng dụng có hiệu quả trong sản xuất nông-lâm-ngư nghiệp phuc vụ việc hiện đại hoá sản xuất nông-lâm-ngư nghiệp;\r\n2.	Công nghệ tiên tiến và thiết bị phù hợp được ứng dụng có hiệu quả trong  bảo quản và chế biến nông-lâm-thủy sản phục vụ các trang trại và vùng sản xuất tập trung;\r\n3.	Công nghệ và thiết bị phù hợp được ứng dụng có hiệu quả trong ngành nghề nông thôn, sản xuất các hàng thủ công mỹ nghệ phục vụ tiêu dùng trong nước và xuất khẩu;\r\n4.	Công nghệ, thiết bị và giải pháp phù hợp được ứng dụng có hiệu quả trong xử lý ô nhiễm môi trường nông nghiệp và nông thôn;\r\n5.	Các mô hình ứng dụng các công nghệ và thiết bị được áp dụng trong thực tế.", null, "Bùi Cách Tuyến" },
                    { 3, null, 1, null, null, null, null, false, 0.0, 1, "07", null, null, null, null, "Văn hóa-Xã hội", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ChuongTrinh_CoQuanQuanLy",
                columns: new[] { "ChuongTrinhId", "CoQuanQuanLyId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ChuyenGia",
                columns: new[] { "Id", "Address", "Bank", "ChucDanhId", "ChucVuId", "ChuongTrinhId", "ChuyenNganhId", "CoQuanChuTriId", "DateOfBirth", "DonViChuQuanId", "Email", "Ex_Info_Field", "Ex_Info_Participation", "Gender", "HocHamId", "HocViId", "ImageName", "LinhVucId", "Name", "PhoneNumber", "Stk" },
                values: new object[,]
                {
                    { 1, "Trường Đại học Công nghiệp Hà Nội", null, null, null, 1, 1, 1, new DateTime(1973, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), 1, "luuthitho1973@gmail.com", null, null, false, 1, 3, "download.jpg", 1, "Lưu Thị Tho", "0988278230", null },
                    { 2, "Hà Nội", "Nhà nước", 2, 2, 1, null, 2, new DateTime(1980, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "bxcvbxc", "bxcb", true, 2, 4, "cat2.jpg", 4, "Đỗ Văn Vũ", "0913210095", "1111111111111111" },
                    { 3, null, null, null, null, 2, 3, 3, null, 2, null, null, null, true, null, null, null, 1, "Nguyễn Tất Tiến", null, null }
                });

            migrationBuilder.InsertData(
                table: "AnPham",
                columns: new[] { "Id", "ChuyenGiaId", "Name", "TapChi", "Year" },
                values: new object[,]
                {
                    { 1, 1, "ABC", "ABCD", 2010 },
                    { 2, 1, "BCD", "ABCE", 2011 }
                });

            migrationBuilder.InsertData(
                table: "CongTrinh",
                columns: new[] { "Id", "ChuyenGiaId", "Name", "Scope_Address", "Year" },
                values: new object[,]
                {
                    { 1, 1, "ABC", "ABCD", 2010 },
                    { 2, 1, "BCD", "ABCE", 2011 }
                });

            migrationBuilder.InsertData(
                table: "GiaiThuong",
                columns: new[] { "Id", "ChuyenGiaId", "Name", "Year" },
                values: new object[,]
                {
                    { 1, 1, "ABC", 2010 },
                    { 2, 1, "BCD", 2011 }
                });

            migrationBuilder.InsertData(
                table: "HoatDongKhac",
                columns: new[] { "Id", "ChuyenGiaId", "Name", "ThoiGian" },
                values: new object[,]
                {
                    { 1, 1, "ABC", "2011-2012" },
                    { 2, 1, "BCD", "2011-2012" }
                });

            migrationBuilder.InsertData(
                table: "KinhNghiem",
                columns: new[] { "Id", "ChuyenGiaId", "CoQuan", "EndYear", "KinhPhi", "Name", "StartYear", "Type" },
                values: new object[,]
                {
                    { 1, 1, "XYZ", 2013, 10.0, "ABC", 2011, "Participation" },
                    { 2, 1, "XYZ", 2014, 10.0, "BCD", 2006, "Presidency" }
                });

            migrationBuilder.InsertData(
                table: "NhiemVu",
                columns: new[] { "Id", "Accounting_Specialist", "Address", "Category", "ChiPhiKhac_Khac", "ChiPhiKhac_NganSachNhaNuoc", "ChiPhiLaoDong_Khac", "ChiPhiLaoDong_NganSachNhaNuoc", "ChuongTrinhId", "ChuyenNganhId", "CoQuanChuTriId", "CoQuanQuanLyKinhPhiId", "CoQuanQuanLyNhiemVuId", "DepartmentAdmin", "DepartmentAdminSpecialist", "EndDate_Month", "EndDate_Year", "FundingPlan_FifteenYearMonths", "FundingPlan_FifthYear", "FundingPlan_FirstYear", "FundingPlan_FirstYearMonths", "FundingPlan_FourthYear", "FundingPlan_FourthYearMonths", "FundingPlan_SecondYear", "FundingPlan_SecondYearMonths", "FundingPlan_SixthYear", "FundingPlan_SixthYearMonths", "FundingPlan_ThirdYear", "FundingPlan_ThirdYearMonths", "HTQT_Khac", "HTQT_NganSachNhaNuoc", "HieuQua", "HoTroCongNghe_Khac", "HoTroCongNghe_NganSachNhaNuoc", "KetQua", "LinhVucId", "MaNhiemVu", "MuaMoi_Khac", "MuaMoi_NganSachNhaNuoc", "MucTieu", "Name", "NgiemThu_Month", "NgiemThu_Year", "NguyenVatLieu_Khac", "NguyenVatLieu_NganSachNhaNuoc", "NhanXet", "NoiDung", "PhuongAnThanhLyHopDong", "PhuongAnThanhLyTaiSan", "Planning_Specialist", "PresidentId", "StartDate_Month", "StartDate_Year", "Status", "ThanhLyHopDong", "ThanhLyTaiSan", "ThietBiMayMoc_Khac", "ThietBiMayMoc_NganSachNhaNuoc", "ThuHoiKinhPhi_FirstTime", "ThuHoiKinhPhi_FirstTime_Month", "ThuHoiKinhPhi_FirstTime_Year", "ThuHoiKinhPhi_SecondTime", "ThuHoiKinhPhi_SecondTime_Month", "ThuHoiKinhPhi_SecondTime_Year", "ThucTeCapKinhPhi_FifthYear_FirstTime", "ThucTeCapKinhPhi_FifthYear_FirstTime_Month", "ThucTeCapKinhPhi_FifthYear_FirstTime_Year", "ThucTeCapKinhPhi_FifthYear_SecondTime", "ThucTeCapKinhPhi_FifthYear_SecondTime_Month", "ThucTeCapKinhPhi_FifthYear_SecondTime_Year", "ThucTeCapKinhPhi_FirstYear_FirstTime", "ThucTeCapKinhPhi_FirstYear_FirstTime_Month", "ThucTeCapKinhPhi_FirstYear_FirstTime_Year", "ThucTeCapKinhPhi_FirstYear_SecondTime", "ThucTeCapKinhPhi_FirstYear_SecondTime_Month", "ThucTeCapKinhPhi_FirstYear_SecondTime_Year", "ThucTeCapKinhPhi_FourthYear_FirstTime", "ThucTeCapKinhPhi_FourthYear_FirstTime_Month", "ThucTeCapKinhPhi_FourthYear_FirstTime_Year", "ThucTeCapKinhPhi_FourthYear_SecondTime", "ThucTeCapKinhPhi_FourthYear_SecondTime_Month", "ThucTeCapKinhPhi_FourthYear_SecondTime_Year", "ThucTeCapKinhPhi_SecondYear_FirstTime", "ThucTeCapKinhPhi_SecondYear_FirstTime_Month", "ThucTeCapKinhPhi_SecondYear_FirstTime_Year", "ThucTeCapKinhPhi_SecondYear_SecondTime", "ThucTeCapKinhPhi_SecondYear_SecondTime_Month", "ThucTeCapKinhPhi_SecondYear_SecondTime_Year", "ThucTeCapKinhPhi_SixthYear_FirstTime", "ThucTeCapKinhPhi_SixthYear_FirstTime_Month", "ThucTeCapKinhPhi_SixthYear_FirstTime_Year", "ThucTeCapKinhPhi_SixthYear_SecondTime", "ThucTeCapKinhPhi_SixthYear_SecondTime_Month", "ThucTeCapKinhPhi_SixthYear_SecondTime_Year", "ThucTeCapKinhPhi_ThirdYear_FirstTime", "ThucTeCapKinhPhi_ThirdYear_FirstTime_Month", "ThucTeCapKinhPhi_ThirdYear_FirstTime_Year", "ThucTeCapKinhPhi_ThirdYear_SecondTime", "ThucTeCapKinhPhi_ThirdYear_SecondTime_Month", "ThucTeCapKinhPhi_ThirdYear_SecondTime_Year", "ThueKhoanChuyenMon_Khac", "ThueKhoanChuyenMon_NganSachNhaNuoc", "Thue_Khac", "Thue_NganSachNhaNuoc", "TongKinhPhiThuHoi", "VPCT_Leader", "XayDungSuaChuaNho_Khac", "XayDungSuaChuaNho_NganSachNhaNuoc" },
                values: new object[,]
                {
                    { 1, null, null, "Topic", 0.0, 0.0, 0.0, 0.0, 1, 1, 1, 1, 2, "Nguyễn Tiến Trung", "Lê Tiến Hùng", null, null, null, null, null, null, null, null, null, null, null, null, null, null, 0.0, 0.0, null, 0.0, 0.0, null, 1, "ĐTĐL.CN-123/21", 0.0, 0.0, null, "Nghiên cứu xây dựng hệ thống xử lý nước nhiễm mặn có ứng dụng IoT để cấp nước sinh hoạt cho người dân vùng bị xâm ngập mặn tỉnh Bến Tre và một số tỉnh lân cận", null, null, 0.0, 0.0, null, null, null, null, "Lê Khả Trường", 1, null, null, "Working", null, null, 0.0, 0.0, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 0.0, 0.0, 0.0, 0.0, null, "Trần Đỗ Đạt", 0.0, 0.0 },
                    { 2, null, null, "Topic", 0.0, 310.0, 0.0, 0.0, 1, 3, 2, 1, 3, "Nguyễn Thị Thanh Hà", "Trần Nam Bình", 12, 2025, null, null, 2700.0, 2023, null, null, 3100.0, 2024, null, null, 900.0, 2025, 0.0, 0.0, null, 0.0, 0.0, null, 1, "ĐTĐL.CN.21/23", 0.0, 0.0, "I. Mục tiêu:\r\n1. Phát triển được vật liệu và công nghệ chế tạo tổ hợp nền titan, gia cường bằng 2 hệ vật liệu nano tiên tiến (hệ vật liệu nano cacbon: ống nano cacbon, graphen; hệ vật liệu nano bo nitrua dạng ống hoặc tấm), có độ bền cao, modul đàn hồi thấp, nhằm thay thế các hợp kim titan chứa V, Al, Nb, Fe định hướng ứng dụng trong ngành chấn thương và chỉnh hình;\r\n2. Chế tạo thử một số sản phẩm điển hình như vít, nẹp phục vụ thử nghiệm in vivo trên \r\nđộng vật; \r\n3. Đánh giá khả năng tương thích sinh học của vật liệu và các sản phẩm chế thử bằng thử nghiệm in vivo trên động vật.\r\n", "Nghiên cứu chế tạo vật liệu tổ hợp nền titan gia cường bằng các thành phần cấu trúc nano tiên tiến (ống nano cacbon, graphen, dạng tấm hay dạng ống nano bo nitrua) nhằm ứng dụng trong ngành chấn thương và chỉnh hình", null, null, 0.0, 2090.0, null, "II.Nội dung\r\nNội dung 1: Nghiên cứu chế tạo và xử lý bề mặt vật liệu gia cường cấu trúc nano (graphen, tấm/ống nano bo nitrua)\r\nNội dung 2: Nghiên cứu phân tán vật liệu cấu trúc nano (CNT, Gr, BNNT và BNNP) với bột titan\r\nNội dung 3: Nghiên cứu công nghệ kết khối hỗn hợp bột tổ hợp titan với vật liệu cấu trúc nano (CNT, Gr, BNNT và BNNP)\r\nNội dung 4: Nghiên cứu ảnh hưởng của hàm lượng, cấu trúc, hình thái học của vật liệu gia cường (CNT, Gr, BNNT và BNNP) đến sự phân tán, cấu trúc, thành phần của vật liệu tổ hợp nền Ti\r\nNội dung 5: Nghiên cứu một số tính chất cơ học, ma sát, mài mòn của vật liệu tổ hợp nền titan gia cường bằng vật liệu cấu trúc nano (CNT, Gr, BNNT và BNNP)\r\nNội dung 6: Nghiên cứu tính chất điện hóa của vật liệu tổ hợp titan gia cường bằng vật liệu cấu trúc nano (CNT, Gr, BNNT và BNNP), và thử nghiệm in vitro trong môi trường giả dịch thể người\r\nNội dung 7: Nghiên cứu công nghệ chế tạo chi tiết cấy ghép bằng vật liệu tổ hợp nền titan gia cường bằng vật liệu cấu trúc nano\r\nNội dung 8: Nghiên cứu thử nghiệm in vivo trên động vật", null, null, "Lê Khả Trường", 2, 1, 2023, "Working", null, null, 0.0, 800.0, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 0.0, 3500.0, 0.0, 0.0, null, "Đào Ngọc Chiến", 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "VanBang",
                columns: new[] { "Id", "ChuyenGiaId", "Name", "Year" },
                values: new object[,]
                {
                    { 1, 1, "ABC", 2010 },
                    { 2, 1, "BCD", 2010 }
                });

            migrationBuilder.InsertData(
                table: "CaNhanThamGia",
                columns: new[] { "Id", "Address", "HocHamId", "HocViId", "Name", "NhiemVuId" },
                values: new object[,]
                {
                    { 1, null, 1, 1, "ABC", 1 },
                    { 2, null, 2, 2, "XYZ", 1 }
                });

            migrationBuilder.InsertData(
                table: "CoQuanChuTri_NhiemVu",
                columns: new[] { "CoQuanChuTriId", "DonViChuQuanId", "NhiemVuId", "Filer" },
                values: new object[,]
                {
                    { 3, 1, 1, "Current" },
                    { 2, 2, 1, "File" }
                });

            migrationBuilder.InsertData(
                table: "CongVanNhiemVu",
                columns: new[] { "Id", "DocTypeId", "NhiemVuId", "NoiDung", "PublishedDate", "SoCongVan", "TrichYeu" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(2023, 12, 24, 3, 24, 4, 439, DateTimeKind.Local).AddTicks(8022), "ABC", "ABC" },
                    { 2, null, 1, null, null, "XXX", "XXX" }
                });

            migrationBuilder.InsertData(
                table: "DonViChuQuan_NhiemVu",
                columns: new[] { "DonViChuQuanId", "NhiemVuId", "Filer" },
                values: new object[,]
                {
                    { 1, 1, "File" },
                    { 2, 1, "Current" }
                });

            migrationBuilder.InsertData(
                table: "FileDinhKem",
                columns: new[] { "Id", "FileName", "FileTypeId", "GhiChu", "NhiemVuId" },
                values: new object[,]
                {
                    { 1, "abc.pdf", 1, null, 1 },
                    { 2, "xyz.pdf", 2, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "HoiDongKhoaHoc",
                columns: new[] { "Id", "Category", "Name", "NhiemVuId" },
                values: new object[,]
                {
                    { 1, "Evaluation", "KC.05.03/06-10 - Hội đồng Nghiệm thu", 1 },
                    { 2, "Admission", "KC.05.03/06-10 - Hội đồng Tuyển chọn, xét tuyển", 1 }
                });

            migrationBuilder.InsertData(
                table: "LanDieuChinh",
                columns: new[] { "Id", "Date", "Khac", "KinhPhi", "NhiemVuId", "NoiDung" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 24, 3, 24, 4, 439, DateTimeKind.Local).AddTicks(8221), null, null, 1, null },
                    { 2, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), null, 0.0, 1, null }
                });

            migrationBuilder.InsertData(
                table: "LanKiemTra",
                columns: new[] { "Id", "EstimatedTestDate", "FinalCost", "HasTested", "KetLuan", "NhiemVuId", "NoiDung", "TestDate", "TesterName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 24, 3, 24, 4, 439, DateTimeKind.Local).AddTicks(8247), null, null, "+ Thực hiện đúng tiến độ;\r\n+ Cần đẩy nhanh hơn tiến độ , hoàn thành việc lắp ráp, kiểm tra máy và chạy thử để nghiệm thu.", 1, null, null, null },
                    { 2, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 0.0, null, null, 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "OtherProducts",
                columns: new[] { "Id", "GhiChu", "IsOutstanding", "IsRegistered", "IsSucceeded", "Name", "NhiemVuId", "YeuCau" },
                values: new object[,]
                {
                    { 1, null, false, false, false, "ABC", 1, null },
                    { 2, null, false, false, false, "BCD", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Ownership",
                columns: new[] { "Id", "GhiChu", "IsOutstanding", "IsRegistered", "IsSucceeded", "LoaiSanPhamId", "NhiemVuId", "Status" },
                values: new object[,]
                {
                    { 1, null, false, false, false, 5, 1, null },
                    { 2, null, false, false, false, 5, 1, null }
                });

            migrationBuilder.InsertData(
                table: "PhanBoNoiDung",
                columns: new[] { "Id", "End", "GhiChu", "IsCompleted", "KinhPhi", "NhiemVuId", "NoiDung", "Start" },
                values: new object[,]
                {
                    { 1, null, null, null, null, 1, "ABCXYZ", null },
                    { 2, null, null, null, null, 1, "DNSukihedihf", null }
                });

            migrationBuilder.InsertData(
                table: "Product_I",
                columns: new[] { "Id", "Address", "ConsumingAmount", "ConsumingQuantity", "ContractAmount", "ContractNumber", "DeliveryAmount", "DeliveryQuantity", "Estimation", "IsConsumed", "IsDelivered", "IsForeign", "IsLocal", "IsOutstanding", "IsRegistered", "IsSucceeded", "LoaiSanPhamId", "Name", "NhiemVuId", "PriceUnit", "RequiredQualityLevel", "Scale", "ServiceProvisionContract", "SocioEconomicEfficiency" },
                values: new object[,]
                {
                    { 1, null, 0.0, 0, 0.0, null, 0.0, 0, 0.0, false, false, null, null, false, false, false, 1, "ABC", 1, null, null, null, false, null },
                    { 2, null, 0.0, 0, 0.0, null, 0.0, 0, 0.0, false, false, null, null, false, false, false, 2, "XYZ", 1, null, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Product_II",
                columns: new[] { "Id", "Address", "ConsumingAmount", "ConsumingQuantity", "ContractAmount", "ContractNumber", "DeliveryAmount", "DeliveryQuantity", "GhiChu", "IsConsumed", "IsDelivered", "IsOutstanding", "IsRegistered", "IsSucceeded", "LoaiSanPhamId", "Name", "NhiemVuId", "Scale", "ServiceProvisionContract", "SocioEconomicEfficiency", "YeuCau" },
                values: new object[,]
                {
                    { 1, null, 0.0, 0, 0.0, null, 0.0, 0, null, false, false, false, false, false, 3, "ABC", 1, null, false, null, null },
                    { 2, null, 0.0, 0, 0.0, null, 0.0, 0, null, false, false, false, false, false, 3, "XYZ", 1, null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Product_III",
                columns: new[] { "Id", "ExpectedPlace", "GhiChu", "IsOutstanding", "IsRegistered", "IsSucceeded", "LoaiSanPhamId", "Name", "NhiemVuId", "YeuCau" },
                values: new object[,]
                {
                    { 1, null, null, false, false, false, 4, "ABC", 1, null },
                    { 2, null, null, false, false, false, 4, "XYZ", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Product_PostgraduateTraining",
                columns: new[] { "Id", "ChuyenNganhId", "GhiChu", "IsOutstanding", "IsRegistered", "IsSucceeded", "NhiemVuId", "Number", "TrainingLevel" },
                values: new object[,]
                {
                    { 1, 2, null, false, false, false, 1, 0, "TS" },
                    { 2, null, null, false, false, false, 1, 0, "Ths" }
                });

            migrationBuilder.InsertData(
                table: "ThanhLapDoanhNghiep",
                columns: new[] { "Id", "Address", "IsCompleted", "Name", "NhiemVuId", "TenVietTat" },
                values: new object[,]
                {
                    { 1, null, false, "ABC", 1, null },
                    { 2, null, false, "XYZ", 1, null }
                });

            migrationBuilder.InsertData(
                table: "HoiDongKhoaHoc_ChuyenGia",
                columns: new[] { "ChuyenGiaId", "HoiDongKhoaHocId", "ChucDanh" },
                values: new object[,]
                {
                    { 1, 1, "President" },
                    { 3, 2, "VicePresident" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnPham_ChuyenGiaId",
                table: "AnPham",
                column: "ChuyenGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CaNhanThamGia_HocHamId",
                table: "CaNhanThamGia",
                column: "HocHamId");

            migrationBuilder.CreateIndex(
                name: "IX_CaNhanThamGia_HocViId",
                table: "CaNhanThamGia",
                column: "HocViId");

            migrationBuilder.CreateIndex(
                name: "IX_CaNhanThamGia_NhiemVuId",
                table: "CaNhanThamGia",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinh_CoQuanChuTriId",
                table: "ChuongTrinh",
                column: "CoQuanChuTriId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinh_GiaiDoanId",
                table: "ChuongTrinh",
                column: "GiaiDoanId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinh_LoaiChuongTrinhId",
                table: "ChuongTrinh",
                column: "LoaiChuongTrinhId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinh_CoQuanQuanLy_CoQuanQuanLyId",
                table: "ChuongTrinh_CoQuanQuanLy",
                column: "CoQuanQuanLyId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_ChucDanhId",
                table: "ChuyenGia",
                column: "ChucDanhId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_ChucVuId",
                table: "ChuyenGia",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_ChuongTrinhId",
                table: "ChuyenGia",
                column: "ChuongTrinhId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_ChuyenNganhId",
                table: "ChuyenGia",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_CoQuanChuTriId",
                table: "ChuyenGia",
                column: "CoQuanChuTriId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_DonViChuQuanId",
                table: "ChuyenGia",
                column: "DonViChuQuanId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_HocHamId",
                table: "ChuyenGia",
                column: "HocHamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_HocViId",
                table: "ChuyenGia",
                column: "HocViId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenGia_LinhVucId",
                table: "ChuyenGia",
                column: "LinhVucId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganh_LinhVucId",
                table: "ChuyenNganh",
                column: "LinhVucId");

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinh_ChuyenGiaId",
                table: "CongTrinh",
                column: "ChuyenGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_CongVanNhiemVu_DocTypeId",
                table: "CongVanNhiemVu",
                column: "DocTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CongVanNhiemVu_NhiemVuId",
                table: "CongVanNhiemVu",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_CoQuanChuTri_DonViChuQuanId",
                table: "CoQuanChuTri",
                column: "DonViChuQuanId");

            migrationBuilder.CreateIndex(
                name: "IX_CoQuanChuTri_NhiemVu_CoQuanChuTriId",
                table: "CoQuanChuTri_NhiemVu",
                column: "CoQuanChuTriId");

            migrationBuilder.CreateIndex(
                name: "IX_CoQuanChuTri_NhiemVu_DonViChuQuanId",
                table: "CoQuanChuTri_NhiemVu",
                column: "DonViChuQuanId");

            migrationBuilder.CreateIndex(
                name: "IX_DonViChuQuan_NhiemVu_DonViChuQuanId",
                table: "DonViChuQuan_NhiemVu",
                column: "DonViChuQuanId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDinhKem_FileTypeId",
                table: "FileDinhKem",
                column: "FileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDinhKem_NhiemVuId",
                table: "FileDinhKem",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_GiaiThuong_ChuyenGiaId",
                table: "GiaiThuong",
                column: "ChuyenGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_HoatDongKhac_ChuyenGiaId",
                table: "HoatDongKhac",
                column: "ChuyenGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_HoiDongKhoaHoc_NhiemVuId",
                table: "HoiDongKhoaHoc",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_HoiDongKhoaHoc_ChuyenGia_ChuyenGiaId",
                table: "HoiDongKhoaHoc_ChuyenGia",
                column: "ChuyenGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_KinhNghiem_ChuyenGiaId",
                table: "KinhNghiem",
                column: "ChuyenGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_LanDieuChinh_NhiemVuId",
                table: "LanDieuChinh",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_LanKiemTra_NhiemVuId",
                table: "LanKiemTra",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiSanPham_DangSanPhamId",
                table: "LoaiSanPham",
                column: "DangSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_ChuongTrinhId",
                table: "NhiemVu",
                column: "ChuongTrinhId");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_ChuyenNganhId",
                table: "NhiemVu",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_CoQuanChuTriId",
                table: "NhiemVu",
                column: "CoQuanChuTriId");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_CoQuanQuanLyKinhPhiId",
                table: "NhiemVu",
                column: "CoQuanQuanLyKinhPhiId");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_CoQuanQuanLyNhiemVuId",
                table: "NhiemVu",
                column: "CoQuanQuanLyNhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_LinhVucId",
                table: "NhiemVu",
                column: "LinhVucId");

            migrationBuilder.CreateIndex(
                name: "IX_NhiemVu_PresidentId",
                table: "NhiemVu",
                column: "PresidentId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherProducts_NhiemVuId",
                table: "OtherProducts",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_LoaiSanPhamId",
                table: "Ownership",
                column: "LoaiSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_NhiemVuId",
                table: "Ownership",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_PhanBoNoiDung_NhiemVuId",
                table: "PhanBoNoiDung",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_I_LoaiSanPhamId",
                table: "Product_I",
                column: "LoaiSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_I_NhiemVuId",
                table: "Product_I",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_II_LoaiSanPhamId",
                table: "Product_II",
                column: "LoaiSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_II_NhiemVuId",
                table: "Product_II",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_III_LoaiSanPhamId",
                table: "Product_III",
                column: "LoaiSanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_III_NhiemVuId",
                table: "Product_III",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_PostgraduateTraining_ChuyenNganhId",
                table: "Product_PostgraduateTraining",
                column: "ChuyenNganhId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_PostgraduateTraining_NhiemVuId",
                table: "Product_PostgraduateTraining",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhLapDoanhNghiep_NhiemVuId",
                table: "ThanhLapDoanhNghiep",
                column: "NhiemVuId");

            migrationBuilder.CreateIndex(
                name: "IX_VanBang_ChuyenGiaId",
                table: "VanBang",
                column: "ChuyenGiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnPham");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CaNhanThamGia");

            migrationBuilder.DropTable(
                name: "ChuongTrinh_CoQuanQuanLy");

            migrationBuilder.DropTable(
                name: "CongTrinh");

            migrationBuilder.DropTable(
                name: "CongVanNhiemVu");

            migrationBuilder.DropTable(
                name: "CoQuanChuTri_NhiemVu");

            migrationBuilder.DropTable(
                name: "DonViChuQuan_NhiemVu");

            migrationBuilder.DropTable(
                name: "FileDinhKem");

            migrationBuilder.DropTable(
                name: "GiaiThuong");

            migrationBuilder.DropTable(
                name: "HoatDongKhac");

            migrationBuilder.DropTable(
                name: "HoiDongKhoaHoc_ChuyenGia");

            migrationBuilder.DropTable(
                name: "KinhNghiem");

            migrationBuilder.DropTable(
                name: "LanDieuChinh");

            migrationBuilder.DropTable(
                name: "LanKiemTra");

            migrationBuilder.DropTable(
                name: "OtherProducts");

            migrationBuilder.DropTable(
                name: "Ownership");

            migrationBuilder.DropTable(
                name: "PhanBoNoiDung");

            migrationBuilder.DropTable(
                name: "Product_I");

            migrationBuilder.DropTable(
                name: "Product_II");

            migrationBuilder.DropTable(
                name: "Product_III");

            migrationBuilder.DropTable(
                name: "Product_PostgraduateTraining");

            migrationBuilder.DropTable(
                name: "ThanhLapDoanhNghiep");

            migrationBuilder.DropTable(
                name: "VanBang");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DocType");

            migrationBuilder.DropTable(
                name: "FileType");

            migrationBuilder.DropTable(
                name: "HoiDongKhoaHoc");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "NhiemVu");

            migrationBuilder.DropTable(
                name: "DangSanPham");

            migrationBuilder.DropTable(
                name: "ChuyenGia");

            migrationBuilder.DropTable(
                name: "CoQuanQuanLy");

            migrationBuilder.DropTable(
                name: "ChucDanh");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "ChuongTrinh");

            migrationBuilder.DropTable(
                name: "ChuyenNganh");

            migrationBuilder.DropTable(
                name: "HocHam");

            migrationBuilder.DropTable(
                name: "HocVi");

            migrationBuilder.DropTable(
                name: "CoQuanChuTri");

            migrationBuilder.DropTable(
                name: "GiaiDoan");

            migrationBuilder.DropTable(
                name: "LoaiChuongTrinh");

            migrationBuilder.DropTable(
                name: "LinhVuc");

            migrationBuilder.DropTable(
                name: "DonViChuQuan");
        }
    }
}
