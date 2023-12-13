using Microsoft.AspNetCore.StaticFiles;

namespace VPCTWebsiteAPI.Service
{
    public interface IFileService
    {
        Task<string> SaveFile(IFormFile FileFile);
        void DeleteFile(string FileName);
        Task<(byte[], string, string)> DownloadFile(string filename);
    }

    public class FileService(IWebHostEnvironment hostEnvironment) : IFileService
    {
        public async Task<string> SaveFile(IFormFile FileFile)
        {
            string FileName = new string(Path.GetFileNameWithoutExtension(FileFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            FileName = FileName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(FileFile.FileName);
            var FilePath = Path.Combine(hostEnvironment.ContentRootPath, "File", FileName);
            using (var fileStream = new FileStream(FilePath, FileMode.Create))
            {
                await FileFile.CopyToAsync(fileStream);
            }
            return FileName;
        }

        public void DeleteFile(string FileName)
        {
            var FilePath = Path.Combine(hostEnvironment.ContentRootPath, "File", FileName);
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }
        public async Task<(byte[],string,string)> DownloadFile(string filename)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "File", filename);

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
