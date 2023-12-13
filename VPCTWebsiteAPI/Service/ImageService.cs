namespace VPCTWebsiteAPI.Service
{
    public interface IImageService
    {
        Task<string> SaveImage(IFormFile imageFile);
        void DeleteImage(string imageName);
    }

    public class ImageService(IWebHostEnvironment hostEnvironment) : IImageService
    {
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new string(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(hostEnvironment.ContentRootPath, "Images", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }

        public void DeleteImage(string imageName)
        {
            var imagePath = Path.Combine(hostEnvironment.ContentRootPath, "Images", imageName);
            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }
    }

}
