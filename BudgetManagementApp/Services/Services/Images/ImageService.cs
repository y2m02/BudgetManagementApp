using System;
using System.IO;

namespace BudgetManagementApp.Services.Services.Images
{
    public interface IImageService
    {
        string Store(string oldFileDirectory);
    }

    public class ImageService : IImageService
    {
        public string Store(string oldFileDirectory)
        {
            var directory = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Images",
                "Billings"
            );

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            
            var newFileName = Guid.NewGuid();

            var newFilePath = Path.Combine(directory, $"{newFileName}.xlsx");

            File.Copy(oldFileDirectory, newFilePath);

            return newFileName.ToString();
        }
    }
}