using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
using VPCTWebsiteAPI.Identity;

namespace VPCT.Core.DbContext
{
    public static class VPCTInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiaiDoan>().HasData(
                new GiaiDoan
                {
                    Id = 1,
                    Start = 2006,
                    End = 2010,
                    Default = false,
                },
                new GiaiDoan
                {
                    Id = 2,
                    Start = 2011,
                    End = 2015,
                    Default = false,
                },
                new GiaiDoan
                {
                    Id = 3,
                    Start = 2016,
                    End = 2020,
                    Default = true,
                },
                new GiaiDoan
                {
                    Id = 4,
                    Start = 2015,
                    End = 2025,
                    Default = false,
                }
            );
            modelBuilder.Entity<DocType>().HasData(
                new DocType
                {
                    Id = 1,
                    Name = "Công văn đến",
                },
                new DocType
                {
                    Id = 2,
                    Name = "Công văn đi",
                }
            );
            modelBuilder.Entity<FileType>().HasData(
                new FileType
                {
                    Id = 1,
                    Name = "Biên bản kiểm tra định kỳ",
                    MoTa = "Biên bản kiểm tra tiến độ đề tài theo định kỳ"
                },
                new FileType
                {
                    Id = 2,
                    Name = "Thuyết minh nhiệm vụ",
                }
            );
            modelBuilder.Entity<DonViChuQuan>().HasData(
                new DonViChuQuan
                {
                    Id = 1,
                    Name = "Tổ chức xã hội - nghề nghiệp",
                },
                new DonViChuQuan
                {
                    Id = 2,
                    Name = "Sở Khoa học và Công nghệ Tỉnh Lâm Đồng",
                }
            );
            modelBuilder.Entity<CoQuanChuTri>().HasData(
                new CoQuanChuTri
                {
                    Id = 1,
                    Name = "Công ty TNHH Khoa học và công nghệ Nông Tín",
                    DonViChuQuanId = 1,
                    IsEnterprise = true,
                    Address = "Thành phố Quảng Ngãi, tỉnh Quảng Ngãi",
                },
                new CoQuanChuTri
                {
                    Id = 2,
                    Name = "Viện Vật lý kỹ thuật",
                    DonViChuQuanId = 2,
                    IsEnterprise = false,
                    PhoneNumber = "069.516.153",
                },
                new CoQuanChuTri
                {
                    Id = 3,
                    Name = "Trường Đại học Dầu Khí Việt Nam",
                    DonViChuQuanId = 2,
                    IsEnterprise = false,
                    PhoneNumber = "2543.738879",
                    Fax = "0254 3733 579",
                    Address = "762 Cách mạng tháng Tám, phường Long Toàn, Thành phố Bà Rịa, Tỉnh Bà Rịa Vũng Tàu"
                }
            );
            modelBuilder.Entity<CoQuanQuanLy>().HasData(
                new CoQuanQuanLy
                {
                    Id = 1,
                    Name = "Văn phòng các Chương trình trọng điểm cấp nhà nước",
                    Type = CoQuanQuanLy.LoaiQuanLy.CostMangement,
                    Address = "Tâng 12, Bộ KH&CN",
                },
                new CoQuanQuanLy
                {
                    Id = 2,
                    Name = "Vụ Phát triển khoa học và công nghệ địa phương",
                    Type = CoQuanQuanLy.LoaiQuanLy.TaskManagement,
                    Address = "Bộ KH&CN",
                    PhoneNumber = "069.516.153",
                },
                new CoQuanQuanLy
                {
                    Id = 3,
                    Name = "Vụ Khoa học Xã hội, Nhân văn và Tự nhiên",
                    Type = CoQuanQuanLy.LoaiQuanLy.TaskManagement,
                    Address = "Bộ KH&CN",
                }
            );
            modelBuilder.Entity<LinhVuc>().HasData(
                new LinhVuc
                {
                    Id = 1,
                    Name = "Tâm lý học",
                },
                new LinhVuc
                {
                    Id = 2,
                    Name = "Năng lượng nguyên tử",
                },
                new LinhVuc
                {
                    Id = 3,
                    Name = "Cơ khí tự động hóa, Công nghệ vật liệu, AN-QP",
                },
                new LinhVuc
                {
                    Id = 4,
                    Name = "Đo lường",
                }
            );
            modelBuilder.Entity<ChuyenNganh>().HasData(
                new ChuyenNganh
                {
                    Id = 1,
                    Name = "Văn phòng các Chương trình trọng điểm cấp nhà nước",
                    LinhVucId = 1,
                },
                new ChuyenNganh
                {
                    Id = 2,
                    Name = "Vụ Phát triển khoa học và công nghệ địa phương",
                    LinhVucId = 2,
                },
                new ChuyenNganh
                {
                    Id = 3,
                    Name = "Vụ Khoa học Xã hội, Nhân văn và Tự nhiên",
                    LinhVucId = 1,
                }
            );
            modelBuilder.Entity<LoaiChuongTrinh>().HasData(
                new LoaiChuongTrinh
                {
                    Id = 1,
                    Name = "Chương trình độc lập quỹ gen",
                    IsPeriodic = false,
                },
                new LoaiChuongTrinh
                {
                    Id = 2,
                    Name = "Chương trình trọng điểm cấp nhà nước",
                    IsPeriodic = true,
                }
            );
            modelBuilder.Entity<ChuongTrinh>().HasData(
                new ChuongTrinh
                {
                    Id = 1,
                    Name = "Khoa học Thông tin",
                    CoQuanChuTriId = 1,
                    MaChuongTrinh = "16",
                    LoaiChuongTrinhId = 1,
                },
                new ChuongTrinh
                {
                    Id = 2,
                    Name = "Nghiên cứu ứng dụng và phát triển công nghệ phục vụ công nghiệp hóa, hiện đại hóa nông nghiệp và nông thôn.",
                    CoQuanChuTriId = 2,
                    MaChuongTrinh = "KC.07/06-10",
                    LoaiChuongTrinhId = 2,
                    Objective = "1.\tỨng dụng và chuyển giao được các công nghệ tiên tiến và thiết bị phù hợp vào sản xuất nông, lâm, ngư nghiệp; bảo quản và chế biến nông-lâm-thủy sản và ngành nghề nông thôn nhằm xây dựng một nền nông nghiệp hàng hóa có khả năng cạnh tranh cao.\r\n2.\tGóp phần nâng cao năng suất lao động, nâng cao năng suất và chất lượng sản phẩm, đảm bảo hiệu quả, phát triển bền vững trong sản xuất nông-lâm-ngư nghiệp; thúc đẩy chuyển dịch cơ cấu kinh tế nông nghiệp nông thôn theo hướng tăng dần tỷ trọng công nghiệp, dịch vụ, tạo việc làm và tăng thu nhập cho người dân nông thôn.",
                    NoiDung = "1.\tỨng dụng và chuyển giao được các công nghệ tiên tiến và thiết bị phù hợp vào sản xuất nông, lâm, ngư nghiệp; bảo quản và chế biến nông-lâm-thủy sản và ngành nghề nông thôn nhằm xây dựng một nền nông nghiệp hàng hóa có khả năng cạnh tranh cao.\r\n2.\tGóp phần nâng cao năng suất lao động, nâng cao năng suất và chất lượng sản phẩm, đảm bảo hiệu quả, phát triển bền vững trong sản xuất nông-lâm-ngư nghiệp; thúc đẩy chuyển dịch cơ cấu kinh tế nông nghiệp nông thôn theo hướng tăng dần tỷ trọng công nghiệp, dịch vụ, tạo việc làm và tăng thu nhập cho người dân nông thôn.",
                    Product = "1.\tCông nghệ tiên tiến và thiết bị phù hợp được ứng dụng có hiệu quả trong sản xuất nông-lâm-ngư nghiệp phuc vụ việc hiện đại hoá sản xuất nông-lâm-ngư nghiệp;\r\n2.\tCông nghệ tiên tiến và thiết bị phù hợp được ứng dụng có hiệu quả trong  bảo quản và chế biến nông-lâm-thủy sản phục vụ các trang trại và vùng sản xuất tập trung;\r\n3.\tCông nghệ và thiết bị phù hợp được ứng dụng có hiệu quả trong ngành nghề nông thôn, sản xuất các hàng thủ công mỹ nghệ phục vụ tiêu dùng trong nước và xuất khẩu;\r\n4.\tCông nghệ, thiết bị và giải pháp phù hợp được ứng dụng có hiệu quả trong xử lý ô nhiễm môi trường nông nghiệp và nông thôn;\r\n5.\tCác mô hình ứng dụng các công nghệ và thiết bị được áp dụng trong thực tế.",
                    Criteria = "1.\t  Chỉ tiêu về trình độ khoa học: 90% đề tài/dự án có kết quả được công bố trên các tạp chí khoa học công nghệ có uy tín quốc gia; ít nhất 10% đề tài có kết quả được công bố trên các tạp chí khoa học công nghệ quốc tế. \r\n2.\t  Chỉ tiêu về trình độ công nghệ: các thiết bị là sản phẩm mới có tính năng kỹ thuật, kiểu dáng, chất lượng và giá cả có khả năng cạnh tranh với các sản phẩm cùng loại của các nước trong khu vực.\r\n3.\t  Chỉ tiêu sở hữu trí tuệ: Có ít nhất 10% số nhiệm vụ có giải pháp được công nhận sáng chế hoặc giải pháp hữu ích, 15% số nhiệm vụ đã được chấp nhận đơn yêu cầu bảo hộ sở hữu công nghiệp.\r\n4.\t  Chỉ tiêu về đào tạo: 70% số đề tài đào tạo được hoặc đang đào tạo ít nhất 1 tiến sĩ và 1 thạc sĩ (hoặc nhiều cử nhân /kỹ sư); 50 % số dự án đào tạo được ít nhất 1 thạc sĩ (hoặc nhiều cử nhân/kỹ sư). \r\n5.\tChỉ tiêu về cơ cấu nhiệm vụ khi kết thúc chương trình:\r\n-\t40% nhiệm vụ nghiên cứu có kết quả là các công nghệ ứng dụng trong các ngành KT-KT ở giai đoạn tiếp theo.\r\n-\t30% nhiệm vụ nghiên cứu có kết quả được ứng dụng phục vụ trực tiếp cho sản xuất, kinh doanh (kết thúc giai đoạn sản xuất thử nghiệm).\r\n-\t30% nhiệm vụ nghiên cứu có kết quả được ứng dụng rộng rãi trong sản xuất - đời sống hoặc được thương mại hoá.",
                    President = "Phan Thanh Tịnh",
                    VicePresident = "Bùi Cách Tuyến",
                    Member_Secretary = "Nguyễn Đức Long",
                    Admin_Secretary = "Lê Thị Hải Yến",
                    GiaiDoanId = 1,
                },
                new ChuongTrinh
                {
                    Id = 3,
                    Name = "Văn hóa-Xã hội",
                    CoQuanChuTriId = 1,
                    MaChuongTrinh = "07",
                    LoaiChuongTrinhId = 1,
                }
            );
            modelBuilder.Entity<ChuongTrinh_CoQuanQuanLy>().HasData(
                new ChuongTrinh_CoQuanQuanLy
                {
                    ChuongTrinhId = 1,
                    CoQuanQuanLyId = 1,
                },
                new ChuongTrinh_CoQuanQuanLy
                {
                    ChuongTrinhId = 1,
                    CoQuanQuanLyId = 2,
                },
                new ChuongTrinh_CoQuanQuanLy
                {
                    ChuongTrinhId = 2,
                    CoQuanQuanLyId = 1,
                },
                new ChuongTrinh_CoQuanQuanLy
                {
                    ChuongTrinhId = 2,
                    CoQuanQuanLyId = 3,
                },
                new ChuongTrinh_CoQuanQuanLy
                {
                    ChuongTrinhId = 3,
                    CoQuanQuanLyId = 1,
                },
                new ChuongTrinh_CoQuanQuanLy
                {
                    ChuongTrinhId = 3,
                    CoQuanQuanLyId = 2,
                }
            );
            modelBuilder.Entity<ChucDanh>().HasData(
                new ChucDanh
                {
                    Id = 1,
                    Name = "Thứ trưởng",
                },
                new ChucDanh
                {
                    Id = 2,
                    Name = "Vụ trưởng",
                },
                new ChucDanh
                {
                    Id = 3,
                    Name = "Giáo sư",
                }
            );
            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu
                {
                    Id = 1,
                    Name = "Nguyên Quyền Giám đốc",
                },
                new ChucVu
                {
                    Id = 2,
                    Name = "Trưởng Bộ môn",
                },
                new ChucVu
                {
                    Id = 3,
                    Name = "Liên đoàn trưởng",
                }
            );
            modelBuilder.Entity<HocHam>().HasData(
                new HocHam
                {
                    Id = 1,
                    Name = "KS",
                },
                new HocHam
                {
                    Id = 2,
                    Name = "TS",
                },
                new HocHam
                {
                    Id = 3,
                    Name = "ThS",
                }
            );
            modelBuilder.Entity<HocVi>().HasData(
                new HocVi
                {
                    Id = 1,
                    Name = "KS",
                },
                new HocVi
                {
                    Id = 2,
                    Name = "TS",
                },
                new HocVi
                {
                    Id = 3,
                    Name = "ThS",
                },
                new HocVi
                {
                    Id = 4,
                    Name = "KSC",
                },
                new HocVi
                {
                    Id = 5,
                    Name = "bác sĩ",
                }
            );
            modelBuilder.Entity<ChuyenGia>().HasData(
                new ChuyenGia
                {
                    Id = 1,
                    Name = "Lưu Thị Tho",
                    DateOfBirth = new DateTime(1973, 9, 27, 0, 0, 0, DateTimeKind.Utc),
                    Gender = false,
                    Address = "Trường Đại học Công nghiệp Hà Nội",
                    PhoneNumber = "0988278230",
                    Email = "luuthitho1973@gmail.com",
                    CoQuanChuTriId = 1,
                    DonViChuQuanId = 1,
                    LinhVucId = 1,
                    ChuyenNganhId = 1,
                    HocHamId = 1,
                    HocViId = 3,
                    ImageName = "download.jpg"
                },
                new ChuyenGia
                {
                    Id = 2,
                    Name = "Đỗ Văn Vũ",
                    DateOfBirth = new DateTime(1980, 5, 4, 0, 0, 0, DateTimeKind.Utc),
                    Gender = true,
                    Address = "Hà Nội",
                    PhoneNumber = "0913210095",
                    Bank = "Nhà nước",
                    Stk = "1111111111111111",
                    CoQuanChuTriId = 2,
                    DonViChuQuanId = 2,
                    LinhVucId = 4,
                    HocViId = 4,
                    HocHamId = 2,
                    ChucDanhId = 2,
                    ChucVuId = 2,
                    Ex_Info_Participation = "bxcb",
                    Ex_Info_Field = "bxcvbxc",
                    ImageName = "cat2.jpg"
                },
                new ChuyenGia
                {
                    Id = 3,
                    Name = "Nguyễn Tất Tiến",
                    Gender = true,
                    CoQuanChuTriId = 3,
                    DonViChuQuanId = 2,
                    LinhVucId = 1,
                    ChuyenNganhId = 3,
                }
            );
            modelBuilder.Entity<AnPham>().HasData(
                new AnPham
                {
                    Id = 1,
                    Name = "ABC",
                    TapChi = "ABCD",
                    ChuyenGiaId = 1,
                    Year = 2010,
                },
                new AnPham
                {
                    Id = 2,
                    Name = "BCD",
                    TapChi = "ABCE",
                    ChuyenGiaId = 1,
                    Year = 2011,
                }
            );
            modelBuilder.Entity<CongTrinh>().HasData(
                new CongTrinh
                {
                    Id = 1,
                    Name = "ABC",
                    Scope_Address = "ABCD",
                    ChuyenGiaId = 1,
                    Year = 2010,
                },
                new CongTrinh
                {
                    Id = 2,
                    Name = "BCD",
                    Scope_Address = "ABCE",
                    ChuyenGiaId = 1,
                    Year = 2011,
                }
            );
            modelBuilder.Entity<GiaiThuong>().HasData(
                new GiaiThuong
                {
                    Id = 1,
                    Name = "ABC",
                    ChuyenGiaId = 1,
                    Year = 2010,
                },
                new GiaiThuong
                {
                    Id = 2,
                    Name = "BCD",
                    ChuyenGiaId = 1,
                    Year = 2011,
                }
            );
            modelBuilder.Entity<HoatDongKhac>().HasData(
                new HoatDongKhac
                {
                    Id = 1,
                    Name = "ABC",
                    ChuyenGiaId = 1,
                    ThoiGian = "2011-2012",
                },
                new HoatDongKhac
                {
                    Id = 2,
                    Name = "BCD",
                    ChuyenGiaId = 1,
                    ThoiGian = "2011-2012",
                }
            );
            modelBuilder.Entity<KinhNghiem>().HasData(
                new KinhNghiem
                {
                    Id = 1,
                    Name = "ABC",
                    ChuyenGiaId = 1,
                    CoQuan = "XYZ",
                    KinhPhi = 10D,
                    StartYear = 2011,
                    EndYear = 2013,
                    Type = KinhNghiem.LoaiKinhNghiem.Participation
                },
                new KinhNghiem
                {
                    Id = 2,
                    Name = "BCD",
                    ChuyenGiaId = 1,
                    CoQuan = "XYZ",
                    KinhPhi = 10D,
                    StartYear = 2006,
                    EndYear = 2014,
                    Type = KinhNghiem.LoaiKinhNghiem.Presidency
                }
            );
            modelBuilder.Entity<VanBang>().HasData(
                new VanBang
                {
                    Id = 1,
                    Name = "ABC",
                    ChuyenGiaId = 1,
                    Year = 2010,
                },
                new VanBang
                {
                    Id = 2,
                    Name = "BCD",
                    ChuyenGiaId = 1,
                    Year = 2010,
                }
            );
            modelBuilder.Entity<DangSanPham>().HasData(
                new DangSanPham
                {
                    Id = 1,
                    Name = "Dạng I",
                    MoTa = "Mẫu (model, maket); Sản phẩm (là hàng hóa có thể tiêu thụ trên thị trường); Vật liệu; Thiết bị máy móc; Dây chuyền công nghệ; Giống vật nuôi; Giống cây trồng và các loại khác",
                },
                new DangSanPham
                {
                    Id = 2,
                    Name = "Dạng II",
                    MoTa = "Nguyên lý ứng dụng; Phương pháp; Tiêu chuẩn, Quy Phạm; Phần mềm máy tính; Bản vẽ thiết kế; Sơ đồ, bản đồ; Số liệu; Cơ sở dữ liệu; Báo cáo phân tích; Tài liệu dự báo (Phương pháp, quy trình, mô hình...) Đề án quy hoạch; Luận chứng kinh tế - kỹ thuật, Báo cáo nghiên cứu khả thi và các sản phẩm khác",
                },
                new DangSanPham
                {
                    Id = 3,
                    Name = "Dạng III",
                },
                new DangSanPham
                {
                    Id = 4,
                    Name = "Dạng khác",
                    MoTa = "Các sản phẩm không xếp vào các dạng cụ thể",
                },
                new DangSanPham
                {
                    Id = 5,
                    Name = "Quyền sở hữu",
                },
                new DangSanPham
                {
                    Id = 6,
                    Name = "Đào tạo sau đại học",
                }
            );
            modelBuilder.Entity<LoaiSanPham>().HasData(
                new LoaiSanPham
                {
                    Id = 1,
                    Name = "Mẫu (Model, maket)",
                    DangSanPhamId = 1,
                },
                new LoaiSanPham
                {
                    Id = 2,
                    Name = "Sản phẩm (là hàng hóa có thể tiêu thụ trên thị trường)",
                    DangSanPhamId = 1,
                },
                new LoaiSanPham
                {
                    Id = 3,
                    Name = "Nguyên lý ứng dụng",
                    DangSanPhamId = 2,
                },
                new LoaiSanPham
                {
                    Id = 4,
                    Name = "Bài báo đăng trong nước",
                    DangSanPhamId = 3,
                },
                new LoaiSanPham
                {
                    Id = 5,
                    Name = "Sáng chế/ giải pháp hữu ích",
                    DangSanPhamId = 5,
                },
                new LoaiSanPham
                {
                    Id = 6,
                    Name = "Thạc sĩ",
                    DangSanPhamId = 6,
                }
            );
            modelBuilder.Entity<NhiemVu>().HasData(
               new NhiemVu
               {
                   Id = 1,
                   Name = "Nghiên cứu xây dựng hệ thống xử lý nước nhiễm mặn có ứng dụng IoT để cấp nước sinh hoạt cho người dân vùng bị xâm ngập mặn tỉnh Bến Tre và một số tỉnh lân cận",
                   MaNhiemVu = "ĐTĐL.CN-123/21",
                   ChuongTrinhId = 1,
                   Category = Models.MainModels.TaskModel.Enums.LoaiNhiemVu.Topic,
                   PresidentId = 1,
                   Status = Models.MainModels.TaskModel.Enums.TrangThaiNhiemVu.Working,
                   CoQuanChuTriId = 1,
                   LinhVucId = 1,
                   ChuyenNganhId = 1,
                   VPCT_Leader = "Trần Đỗ Đạt",
                   Planning_Specialist = "Lê Khả Trường",
                   CoQuanQuanLyKinhPhiId = 1,
                   CoQuanQuanLyNhiemVuId = 2,
                   DepartmentAdmin = "Nguyễn Tiến Trung",
                   DepartmentAdminSpecialist = "Lê Tiến Hùng",
               },
               new NhiemVu
               {
                   Id = 2,
                   Name = "Nghiên cứu chế tạo vật liệu tổ hợp nền titan gia cường bằng các thành phần cấu trúc nano tiên tiến (ống nano cacbon, graphen, dạng tấm hay dạng ống nano bo nitrua) nhằm ứng dụng trong ngành chấn thương và chỉnh hình",
                   MaNhiemVu = "ĐTĐL.CN.21/23",
                   ChuongTrinhId = 1,
                   Category = Models.MainModels.TaskModel.Enums.LoaiNhiemVu.Topic,
                   PresidentId = 2,
                   Status = Models.MainModels.TaskModel.Enums.TrangThaiNhiemVu.Working,
                   CoQuanChuTriId = 2,
                   LinhVucId = 1,
                   ChuyenNganhId = 3,
                   VPCT_Leader = "Đào Ngọc Chiến",
                   Planning_Specialist = "Lê Khả Trường",
                   CoQuanQuanLyKinhPhiId = 1,
                   CoQuanQuanLyNhiemVuId = 3,
                   DepartmentAdmin = "Nguyễn Thị Thanh Hà",
                   DepartmentAdminSpecialist = "Trần Nam Bình",
                   StartDate_Month = 1,
                   StartDate_Year = 2023,
                   EndDate_Month = 12,
                   EndDate_Year = 2025,
                   MucTieu = "I. Mục tiêu:\r\n1. Phát triển được vật liệu và công nghệ chế tạo tổ hợp nền titan, gia cường bằng 2 hệ vật liệu nano tiên tiến (hệ vật liệu nano cacbon: ống nano cacbon, graphen; hệ vật liệu nano bo nitrua dạng ống hoặc tấm), có độ bền cao, modul đàn hồi thấp, nhằm thay thế các hợp kim titan chứa V, Al, Nb, Fe định hướng ứng dụng trong ngành chấn thương và chỉnh hình;\r\n2. Chế tạo thử một số sản phẩm điển hình như vít, nẹp phục vụ thử nghiệm in vivo trên \r\nđộng vật; \r\n3. Đánh giá khả năng tương thích sinh học của vật liệu và các sản phẩm chế thử bằng thử nghiệm in vivo trên động vật.\r\n",
                   NoiDung = "II.Nội dung\r\nNội dung 1: Nghiên cứu chế tạo và xử lý bề mặt vật liệu gia cường cấu trúc nano (graphen, tấm/ống nano bo nitrua)\r\nNội dung 2: Nghiên cứu phân tán vật liệu cấu trúc nano (CNT, Gr, BNNT và BNNP) với bột titan\r\nNội dung 3: Nghiên cứu công nghệ kết khối hỗn hợp bột tổ hợp titan với vật liệu cấu trúc nano (CNT, Gr, BNNT và BNNP)\r\nNội dung 4: Nghiên cứu ảnh hưởng của hàm lượng, cấu trúc, hình thái học của vật liệu gia cường (CNT, Gr, BNNT và BNNP) đến sự phân tán, cấu trúc, thành phần của vật liệu tổ hợp nền Ti\r\nNội dung 5: Nghiên cứu một số tính chất cơ học, ma sát, mài mòn của vật liệu tổ hợp nền titan gia cường bằng vật liệu cấu trúc nano (CNT, Gr, BNNT và BNNP)\r\nNội dung 6: Nghiên cứu tính chất điện hóa của vật liệu tổ hợp titan gia cường bằng vật liệu cấu trúc nano (CNT, Gr, BNNT và BNNP), và thử nghiệm in vitro trong môi trường giả dịch thể người\r\nNội dung 7: Nghiên cứu công nghệ chế tạo chi tiết cấy ghép bằng vật liệu tổ hợp nền titan gia cường bằng vật liệu cấu trúc nano\r\nNội dung 8: Nghiên cứu thử nghiệm in vivo trên động vật",
                   FundingPlan_FirstYearMonths = 2023,
                   FundingPlan_FirstYear = 2700D,
                   FundingPlan_SecondYearMonths = 2024,
                   FundingPlan_SecondYear = 3100D,
                   FundingPlan_ThirdYearMonths = 2025,
                   FundingPlan_ThirdYear = 900D,
                   ThueKhoanChuyenMon_NganSachNhaNuoc = 3500D,
                   NguyenVatLieu_NganSachNhaNuoc = 2090D,
                   ThietBiMayMoc_NganSachNhaNuoc = 800D,
                   ChiPhiKhac_NganSachNhaNuoc = 310D,
               }
            );
            modelBuilder.Entity<OtherProducts>().HasData(
                 new OtherProducts
                 {
                     Id = 1,
                     Name = "ABC",
                     NhiemVuId = 1,
                 },
                 new OtherProducts
                 {
                     Id = 2,
                     Name = "BCD",
                     NhiemVuId = 2,
                 }
             );
            modelBuilder.Entity<Ownership>().HasData(
                 new Ownership
                 {
                     Id = 1,
                     LoaiSanPhamId = 5,
                     NhiemVuId = 1,
                 },
                 new Ownership
                 {
                     Id = 2,
                     LoaiSanPhamId = 5,
                     NhiemVuId = 1,
                 }
             );
            modelBuilder.Entity<Product_I>().HasData(
                 new Product_I
                 {
                     Id = 1,
                     LoaiSanPhamId = 1,
                     NhiemVuId = 1,
                     Name = "ABC",
                 },
                 new Product_I
                 {
                     Id = 2,
                     LoaiSanPhamId = 2,
                     NhiemVuId = 1,
                     Name = "XYZ",
                 }
             );
            modelBuilder.Entity<Product_II>().HasData(
                 new Product_II
                 {
                     Id = 1,
                     LoaiSanPhamId = 3,
                     NhiemVuId = 1,
                     Name = "ABC",
                 },
                 new Product_II
                 {
                     Id = 2,
                     LoaiSanPhamId = 3,
                     NhiemVuId = 1,
                     Name = "XYZ",
                 }
             );
            modelBuilder.Entity<Product_III>().HasData(
                 new Product_III
                 {
                     Id = 1,
                     LoaiSanPhamId = 4,
                     NhiemVuId = 1,
                     Name = "ABC",
                 },
                 new Product_III
                 {
                     Id = 2,
                     LoaiSanPhamId = 4,
                     NhiemVuId = 1,
                     Name = "XYZ",
                 }
             );
            modelBuilder.Entity<Product_PostgraduateTraining>().HasData(
                 new Product_PostgraduateTraining
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     ChuyenNganhId = 2,
                     TrainingLevel = Models.MainModels.TaskModel.Enums.CapDaoTao.TS,
                 },
                 new Product_PostgraduateTraining
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     TrainingLevel = Models.MainModels.TaskModel.Enums.CapDaoTao.Ths,
                 }
             );
            modelBuilder.Entity<ThanhLapDoanhNghiep>().HasData(
                 new ThanhLapDoanhNghiep
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     Name = "ABC",
                 },
                 new ThanhLapDoanhNghiep
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     Name = "XYZ",
                 }
             );
            modelBuilder.Entity<CaNhanThamGia>().HasData(
                 new CaNhanThamGia
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     Name = "ABC",
                     HocHamId = 1,
                     HocViId = 1,
                 },
                 new CaNhanThamGia
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     Name = "XYZ",
                     HocHamId = 2,
                     HocViId = 2,
                 }
             );
            modelBuilder.Entity<CongVanNhiemVu>().HasData(
                 new CongVanNhiemVu
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     SoCongVan = "ABC",
                     TrichYeu = "ABC",
                     PublishedDate = DateTime.Now,
                     DocTypeId = 1,
                 },
                 new CongVanNhiemVu
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     SoCongVan = "XXX",
                     TrichYeu = "XXX",
                 }
             );
            modelBuilder.Entity<CoQuanChuTri_NhiemVu>().HasData(
                 new CoQuanChuTri_NhiemVu
                 {
                     NhiemVuId = 1,
                     DonViChuQuanId = 2,
                     CoQuanChuTriId = 2,
                     Filer = Models.MainModels.TaskModel.Enums.LoaiHoSo.File,
                 },
                 new CoQuanChuTri_NhiemVu
                 {
                     NhiemVuId = 1,
                     DonViChuQuanId = 1,
                     CoQuanChuTriId = 3,
                     Filer = Models.MainModels.TaskModel.Enums.LoaiHoSo.Current,
                 }
             );
            modelBuilder.Entity<DonViChuQuan_NhiemVu>().HasData(
                 new DonViChuQuan_NhiemVu
                 {
                     NhiemVuId = 1,
                     DonViChuQuanId = 1,
                     Filer = Models.MainModels.TaskModel.Enums.LoaiHoSo.File,
                 },
                 new DonViChuQuan_NhiemVu
                 {
                     NhiemVuId = 1,
                     DonViChuQuanId = 2,
                     Filer = Models.MainModels.TaskModel.Enums.LoaiHoSo.Current,
                 }
             );
            modelBuilder.Entity<FileDinhKem>().HasData(
                 new FileDinhKem
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     FileTypeId = 1,
                     FileName = "abc.pdf",
                 },
                 new FileDinhKem
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     FileTypeId = 2,
                     FileName = "xyz.pdf",
                 }
             );
            modelBuilder.Entity<HoiDongKhoaHoc>().HasData(
                 new HoiDongKhoaHoc
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     Name = "KC.05.03/06-10 - Hội đồng Nghiệm thu",
                     Category = Models.MainModels.TaskModel.Enums.LoaiHoiDong.Evaluation,
                 },
                 new HoiDongKhoaHoc
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     Name = "KC.05.03/06-10 - Hội đồng Tuyển chọn, xét tuyển",
                     Category = Models.MainModels.TaskModel.Enums.LoaiHoiDong.Admission,
                 }
             );
            modelBuilder.Entity<HoiDongKhoaHoc_ChuyenGia>().HasData(
                 new HoiDongKhoaHoc_ChuyenGia
                 {
                     HoiDongKhoaHocId = 1,
                     ChuyenGiaId = 1,
                     ChucDanh = Models.MainModels.TaskModel.Enums.ChucDanhHoiDong.President,
                 },
                 new HoiDongKhoaHoc_ChuyenGia
                 {
                     HoiDongKhoaHocId = 2,
                     ChuyenGiaId = 3,
                     ChucDanh = Models.MainModels.TaskModel.Enums.ChucDanhHoiDong.VicePresident,
                 }
             );
            modelBuilder.Entity<LanDieuChinh>().HasData(
                 new LanDieuChinh
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     Date = DateTime.Now,
                 },
                 new LanDieuChinh
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     Date = DateTime.Today,
                     KinhPhi = 0D,
                 }
             );
            modelBuilder.Entity<LanKiemTra>().HasData(
                 new LanKiemTra
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     EstimatedTestDate = DateTime.Now,
                     KetLuan = "+ Thực hiện đúng tiến độ;\r\n+ Cần đẩy nhanh hơn tiến độ , hoàn thành việc lắp ráp, kiểm tra máy và chạy thử để nghiệm thu.",
                 },
                 new LanKiemTra
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     EstimatedTestDate = DateTime.Today,
                     FinalCost = 0D,
                 }
             );
            modelBuilder.Entity<PhanBoNoiDung>().HasData(
                 new PhanBoNoiDung
                 {
                     Id = 1,
                     NhiemVuId = 1,
                     NoiDung = "ABCXYZ",
                 },
                 new PhanBoNoiDung
                 {
                     Id = 2,
                     NhiemVuId = 1,
                     NoiDung = "DNSukihedihf",
                 }
             );
        }
        public static void SeedIdentity(this ModelBuilder modelBuilder)
        {
            var pwd = "P@$$w0rd";
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            // Seed Roles
            var adminRole = new IdentityRole(UserRoles.LanhDao);
            adminRole.NormalizedName = adminRole.Name!.ToUpper();

            var contributorRole = new IdentityRole(UserRoles.ChuyenVien);
            contributorRole.NormalizedName = contributorRole.Name!.ToUpper();

            var otherRole = new IdentityRole(UserRoles.KeToan);
            otherRole.NormalizedName = otherRole.Name!.ToUpper();

            List<IdentityRole> roles = [
                adminRole,
                contributorRole,
                otherRole
            ];
            modelBuilder.Entity<IdentityRole>().HasData(roles);


            // Seed Users
            var adminUser = new ApplicationUser
            {
                UserName = "admin12",
                Email = "aa@aa.aa",
                EmailConfirmed = true,
                PhoneNumber = "01223456789",
                FullName = "Luu Minh"
            };
            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

            var contributorUser = new ApplicationUser
            {
                UserName = "admin13",
                Email = "mm@mm.mm",
                EmailConfirmed = true,
                PhoneNumber = "01223456789",
                FullName = "Hoang Khanh"
            };
            contributorUser.NormalizedUserName = contributorUser.UserName.ToUpper();
            contributorUser.NormalizedEmail = contributorUser.Email.ToUpper();
            contributorUser.PasswordHash = passwordHasher.HashPassword(contributorUser, pwd);

            List<ApplicationUser> users = [
                adminUser,
                contributorUser,
            ];

            modelBuilder.Entity<ApplicationUser>().HasData(users);

            // Seed UserRoles
            List<IdentityUserRole<string>> userRoles =
            [
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,
                    RoleId = roles.First(q => q.Name == UserRoles.LanhDao).Id
                },

                new IdentityUserRole<string>
                {
                    UserId = users[1].Id,
                    RoleId = roles.First(q => q.Name == UserRoles.ChuyenVien).Id
                }
            ];
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
