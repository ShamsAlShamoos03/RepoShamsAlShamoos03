using Microsoft.AspNetCore.Hosting;
using ShamsAlShamoos03.Shared.Models;

namespace ShamsAlShamoos03.Infrastructure.Services;

public class QrBatchService
{
    private readonly IWebHostEnvironment _env;
    private readonly QrCodeService _qrCodeService;

    private const int MaxChunkSize = 300;
    private string QrBasePath =>
    Path.Combine(_env.ContentRootPath, "QrFiles");

    public QrBatchService(IWebHostEnvironment env, QrCodeService qrCodeService)
    {
        _env = env;
        _qrCodeService = qrCodeService;
    }

    public List<string> GenerateMultipleQrs(string longText)
    {
        if (string.IsNullOrWhiteSpace(longText))
        {
            return new List<string>();
        }

        string folderName = $"qr_batch_{DateTime.Now:yyyyMMdd_HHmmss}";
        string baseFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "QrFiles", folderName);

        if (!Directory.Exists(baseFolderPath))
        {
            Directory.CreateDirectory(baseFolderPath);
        }

        string textFilePath = Path.Combine(baseFolderPath, folderName + ".txt");
        File.WriteAllText(textFilePath, longText);

        List<string> chunks = SplitText(longText, MaxChunkSize);
        List<string> filePaths = new();

        int partNumber = 1;

        foreach (var chunk in chunks)
        {
            string fileName = $"part_{partNumber}";
            var path = _qrCodeService.GenerateQrToFile(chunk, folderName, fileName);
            filePaths.Add(path);
            partNumber++;
        }

        return filePaths;
    }

    private static List<string> SplitText(string text, int chunkSize)
    {
        List<string> parts = new();

        for (int i = 0; i < text.Length; i += chunkSize)
        {
            int length = Math.Min(chunkSize, text.Length - i);
            parts.Add(text.Substring(i, length));
        }

        return parts;
    }

    public List<string> GenerateQrsFromImage(string imagePath)
    {
        if (!File.Exists(imagePath))
        {
            return new List<string>();
        }

        byte[] imageBytes = File.ReadAllBytes(imagePath);
        string base64String = Convert.ToBase64String(imageBytes);

        return GenerateMultipleQrs(base64String);
    }

    public List<QrFileDto> GetAllQrFiles()
    {
        var result = new List<QrFileDto>();

        if (!Directory.Exists(QrBasePath))
        {
            return result;
        }

        foreach (var folder in Directory.GetDirectories(QrBasePath))
        {
            string folderName = Path.GetFileName(folder);

            foreach (var file in Directory.GetFiles(folder, "*.png"))
            {
                string fileName = Path.GetFileName(file);

                result.Add(new QrFileDto
                {
                    Folder = folderName,
                    FileName = fileName,
                    RelativePath = $"{folderName}/{fileName}"
                });
            }
        }

        return result;
    }

    public string ReadQrText(string relativePath)
    {
        string fullPath = Path.Combine(QrBasePath, relativePath);

        if (!File.Exists(fullPath))
        {
            throw new FileNotFoundException("QR file not found");
        }

        var reader = new QrReaderService();
        return reader.ReadQrFromFile(fullPath);
    }
}
