namespace VPCTWebsiteAPI.Service
{
    using Microsoft.AspNetCore.StaticFiles;

    namespace VPCTWebsiteAPI.Service
    {
        public interface IThongKeService
        {
            Task<string> SaveFile(IFormFile FileFile);
            Task<(byte[], string, string)> DownloadFile(string filename);
        }

        public class ThongKeService(IWebHostEnvironment hostEnvironment) : IThongKeService
        {
            public async Task<string> SaveFile(IFormFile FileFile)
            {
                string FileName = "_CẬP NHẬT KIỂM TRA, XÁC NHẬN NỘI DUNG, BÁO CÁO ĐỊNH KỲ NĂM 2023";
                FileName = FileName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(FileFile.FileName);
                var FilePath = Path.Combine(hostEnvironment.ContentRootPath, "ThongKe", FileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    await FileFile.CopyToAsync(fileStream);
                }
                return FileName;
            }

            public async Task<(byte[], string, string)> DownloadFile(string filename)
            {
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), "ThongKe", filename);

                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(filepath, out var contenttype))
                {
                    contenttype = "application/octet-stream";
                }

                var bytes = await File.ReadAllBytesAsync(filepath);
                return (bytes, contenttype, Path.GetFileName(filepath));
            }
        }
    }

}
