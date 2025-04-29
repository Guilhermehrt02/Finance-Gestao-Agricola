using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;

namespace Application.Services
{
    public class UploadServices(IWebHostEnvironment webHostEnvironment) : IUploadServices
    {
        private readonly IWebHostEnvironment _webHostEnvironment = webHostEnvironment;

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            if (file.Length == 0 || file == null)
            {
                throw new ArgumentException("File is empty");
            }
            if (file.Length > 5 * 1024 * 1024) // 5 MB limit
            {
                throw new ArgumentException("File size exceeds the limit of 5 MB");
            }

            var uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath ?? "wwwroot", "uploads");
            
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(uploadsFolder, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var relativePath = Path.Combine("uploads", fileName).Replace("\\", "/");

            
            return JsonSerializer.Serialize(new { Path = relativePath });
        }
    }
}