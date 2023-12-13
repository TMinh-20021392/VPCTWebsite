using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;
using VPCT.Core.DbContext;
using VPCT.Core.Models.Identity;
using VPCT.Repositories.Infrastructure;
using VPCT.Repositories.IRepositories;
using VPCT.Repositories.IRepositories.MainModels.ExpertModel;
using VPCT.Repositories.IRepositories.MainModels.FieldModel;
using VPCT.Repositories.IRepositories.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.IRepositories.MainModels.ProgramModel;
using VPCT.Repositories.IRepositories.MainModels.TaskModel;
using VPCT.Repositories.Repositories;
using VPCT.Repositories.Repositories.DocAndFileTypes;
using VPCT.Repositories.Repositories.MainModels.ExpertModel;
using VPCT.Repositories.Repositories.MainModels.ProductModel;
using VPCT.Repositories.Repositories.MainModels.ProductModel.TaskProduct;
using VPCT.Repositories.Repositories.MainModels.ProgramModel;
using VPCT.Repositories.Repositories.MainModels.TaskModel;
using VPCTWebsiteAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<VPCTDbContext>().AddDefaultTokenProviders();
builder.Services.AddDbContext<VPCTDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("VPCTDbContext")));


builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

builder.Services.AddScoped<IDocTypeRepository, DocTypeRepository>();
builder.Services.AddScoped<IFileTypeRepository, FileTypeRepository>();
builder.Services.AddScoped<ICoQuanChuTriRepository, CoQuanChuTriRepository>();
builder.Services.AddScoped<ICoQuanQuanLyRepository, CoQuanQuanLyRepository>();
builder.Services.AddScoped<IDonViChuQuanRepository, DonViChuQuanRepository>();
builder.Services.AddScoped<IAnPhamRepository, AnPhamRepository>();
builder.Services.AddScoped<IChucDanhRepository, ChucDanhRepository>();
builder.Services.AddScoped<IChucVuRepository, ChucVuRepository>();
builder.Services.AddScoped<IChuyenGiaRepository, ChuyenGiaRepository>();
builder.Services.AddScoped<ICongTrinhRepository, CongTrinhRepository>();
builder.Services.AddScoped<IGiaiThuongRepository, GiaiThuongRepository>();
builder.Services.AddScoped<IHoatDongKhacRepository, HoatDongKhacRepository>();
builder.Services.AddScoped<IHocHamRepository, HocHamRepository>();
builder.Services.AddScoped<IHocViRepository, HocViRepository>();
builder.Services.AddScoped<IKinhNghiemRepository, KinhNghiemRepository>();
builder.Services.AddScoped<IVanBangRepository, VanBangRepository>();
builder.Services.AddScoped<IChuyenNganhRepository, ChuyenNganhRepository>();
builder.Services.AddScoped<ILinhVucRepository, LinhVucRepository>();
builder.Services.AddScoped<IDangSanPhamRepository, DangSanPhamRepository>();
builder.Services.AddScoped<ILoaiSanPhamRepository, LoaiSanPhamRepository>();
builder.Services.AddScoped<IOtherProductsRepository, OtherProductsRepository>();
builder.Services.AddScoped<IOwnershipRepository, OwnershipRepository>();
builder.Services.AddScoped<IProduct_I_Repository, Product_I_Repository>();
builder.Services.AddScoped<IProduct_II_Repository, Product_II_Repository>();
builder.Services.AddScoped<IProduct_III_Repository, Product_III_Repository>();
builder.Services.AddScoped<IProduct_PostgraduateTraining_Repository, Product_PostgraduateTraining_Repository>();
builder.Services.AddScoped<IThanhLapDoanhNghiepRepository, ThanhLapDoanhNghiepRepository>();
builder.Services.AddScoped<ILoaiChuongTrinhRepository, LoaiChuongTrinhRepository>();
builder.Services.AddScoped<IChuongTrinhRepository, ChuongTrinhRepository>();
builder.Services.AddScoped<IChuongTrinh_CoQuanQuanLyRepository, ChuongTrinh_CoQuanQuanLyRepository>();
builder.Services.AddScoped<ICaNhanThamGiaRepository, CaNhanThamGiaRepository>();
builder.Services.AddScoped<ICongVanNhiemVuRepository, CongVanNhiemVuRepository>();
builder.Services.AddScoped<ICoQuanChuTri_NhiemVuRepository, CoQuanChuTri_NhiemVuRepository>();
builder.Services.AddScoped<IDonViChuQuan_NhiemVuRepository, DonViChuQuan_NhiemVuRepository>();
builder.Services.AddScoped<IFileDinhKemRepository, FileDinhKemRepository>();
builder.Services.AddScoped<IHoiDongKhoaHocRepository, HoiDongKhoaHocRepository>();
builder.Services.AddScoped<IHoiDongKhoaHoc_ChuyenGiaRepository, HoiDongKhoaHoc_ChuyenGiaRepository>();
builder.Services.AddScoped<INhiemVuRepository, NhiemVuRepository>();
builder.Services.AddScoped<ILanDieuChinhRepository, LanDieuChinhRepository>();
builder.Services.AddScoped<ILanKiemTraRepository, LanKiemTraRepository>();
builder.Services.AddScoped<IPhanBoNoiDungRepository, PhanBoNoiDungRepository>();
builder.Services.AddScoped<IGiaiDoanRepository, GiaiDoanRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IFileService, FileService>();


builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options => {
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]!))
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder =>
{
    builder
   .AllowAnyOrigin()
   .AllowAnyMethod()
   .AllowAnyHeader();
});

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "Images")),
    RequestPath = "/Images"
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "File")),
    RequestPath = "/File"
});
app.MapControllers();

app.Run();
