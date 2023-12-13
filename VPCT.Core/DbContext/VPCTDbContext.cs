using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VPCT.Core.Config;
using VPCT.Core.Config.DocAndFileTypes;
using VPCT.Core.Config.MainModels;
using VPCT.Core.Config.MainModels.DepartmentModel;
using VPCT.Core.Config.MainModels.ExpertModel;
using VPCT.Core.Config.MainModels.FieldModel;
using VPCT.Core.Config.MainModels.ProductModel;
using VPCT.Core.Config.MainModels.ProductModel.TaskProduct;
using VPCT.Core.Config.MainModels.ProgramModel;
using VPCT.Core.Config.MainModels.TaskModel;
using VPCT.Core.Models;
using VPCT.Core.Models.DocAndFileTypes;
using VPCT.Core.Models.Identity;
using VPCT.Core.Models.MainModels.DepartmentModel;
using VPCT.Core.Models.MainModels.ExpertModel;
using VPCT.Core.Models.MainModels.FieldModel;
using VPCT.Core.Models.MainModels.ProductModel;
using VPCT.Core.Models.MainModels.ProductModel.TaskProduct;
using VPCT.Core.Models.MainModels.ProgramModel;
using VPCT.Core.Models.MainModels.TaskModel;

namespace VPCT.Core.DbContext
{
    public partial class VPCTDbContext : IdentityDbContext<ApplicationUser>
    {
        public VPCTDbContext() { }
        public VPCTDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(DocTypeConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(FileTypeConfig).Assembly);

            builder.ApplyConfigurationsFromAssembly(typeof(DepartmentConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ManagingDepartmentConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OrganizationConfig).Assembly);

            builder.ApplyConfigurationsFromAssembly(typeof(ExpertConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(AcademicDegreeConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(AcademicTitleConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(AwardConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(DiplomaConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ExperienceConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OtherActivityConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(PositionConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ProjectConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(PublicationConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(TitleConfig).Assembly);

            builder.ApplyConfigurationsFromAssembly(typeof(FieldConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(SpecializationConfig).Assembly);

            builder.ApplyConfigurationsFromAssembly(typeof(ProductCategoryConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ProductSubCategoryConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(BusinessEstablishmentConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OtherProductsConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(OwnershipConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(Product_IConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(Product_IIConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(Product_IIIConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(Product_PostgraduateTrainingConfig).Assembly);

            builder.ApplyConfigurationsFromAssembly(typeof(ProgramCategoryConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ProgramConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(Program_ManagingDepartmentConfig).Assembly);

            builder.ApplyConfigurationsFromAssembly(typeof(TaskConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(AttachmentsConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(DocumentsConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(DistributionConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ExpertCouncilRoleConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ModificationConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ParticipatorConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(ScienceCouncilConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(TaskDepartmentConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(TaskOrganizationConfig).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(TestConfig).Assembly);

            builder.ApplyConfigurationsFromAssembly(typeof(PeriodConfig).Assembly);


            builder.Seed();
            builder.SeedIdentity();
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=VPCT;Integrated Security=true";
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public DbSet<DonViChuQuan> DonViChuQuan { get; set; } = null!;
        public DbSet<CoQuanQuanLy> CoQuanQuanLy { get; set; } = null!;
        public DbSet<CoQuanChuTri> CoQuanChuTri { get; set; } = null!;

        public DbSet<ChuyenGia> ChuyenGia { get; set; } = null!;
        public DbSet<HocVi> HocVi { get; set; } = null!;
        public DbSet<HocHam> HocHam { get; set; } = null!;
        public DbSet<HoatDongKhac> HoatDongKhac { get; set; } = null!;
        public DbSet<GiaiThuong> GiaiThuong { get; set; } = null!;
        public DbSet<VanBang> VanBang { get; set; } = null!;
        public DbSet<KinhNghiem> KinhNghiem { get; set; } = null!;
        public DbSet<ChucVu> ChucVu { get; set; } = null!;
        public DbSet<CongTrinh> CongTrinh { get; set; } = null!;
        public DbSet<ChucDanh> ChucDanh { get; set; } = null!;
        public DbSet<AnPham> AnPham { get; set; } = null!;

        public DbSet<LinhVuc> LinhVuc { get; set; } = null!;
        public DbSet<ChuyenNganh> ChuyenNganh { get; set; } = null!;

        public DbSet<DangSanPham> DangSanPham { get; set; } = null!;
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; } = null!;

        public DbSet<ChuongTrinh> ChuongTrinh { get; set; } = null!;
        public DbSet<LoaiChuongTrinh> LoaiChuongTrinh { get; set; } = null!;
        public DbSet<ChuongTrinh_CoQuanQuanLy> ChuongTrinh_CoQuanQuanLys { get; set; } = null!;

        public DbSet<NhiemVu> NhiemVu { get; set; } = null!;
        public DbSet<HoiDongKhoaHoc> HoiDongKhoaHoc { get; set; } = null!;
        public DbSet<CaNhanThamGia> CaNhanThamGia { get; set; } = null!;
        public DbSet<HoiDongKhoaHoc_ChuyenGia> HoiDongKhoaHoc_ChuyenGia { get; set; } = null!;
        public DbSet<FileDinhKem> FileDinhKem { get; set; } = null!;
        public DbSet<PhanBoNoiDung> PhanBoNoiDung { get; set; } = null!;  
        public DbSet<CongVanNhiemVu> CongVanNhiemVu { get; set; } = null!;
        public DbSet<LanDieuChinh> LanDieuChinh { get; set; } = null!;
        public DbSet<LanKiemTra> LanKiemTra { get; set; } = null!;
        public DbSet<DonViChuQuan_NhiemVu> DonViChuQuan_NhiemVu { get; set; } = null!;
        public DbSet<CoQuanChuTri_NhiemVu> CoQuanChuTri_NhiemVu { get; set; } = null!;


        public DbSet<Ownership> Ownerships { get; set; } = null!;
        public DbSet<Product_I> Product_Is { get; set; } = null!;
        public DbSet<Product_II> Product_IIs { get; set; } = null!;
        public DbSet<Product_III> Product_IIIs { get; set; } = null!;
        public DbSet<Product_PostgraduateTraining> Product_PostgraduateTraining { get; set; } = null!;
        public DbSet<ThanhLapDoanhNghiep> ThanhLapDoanhNghiep { get; set; } = null!;
        public DbSet<OtherProducts> OtherProducts { get; set; } = null!;

        public DbSet<GiaiDoan> GiaiDoan { get; set; } = null!;

        public DbSet<DocType> DocTypes { get; set; } = null!;
        public DbSet<FileType> FileTypes { get; set; } = null!;
    }
}
