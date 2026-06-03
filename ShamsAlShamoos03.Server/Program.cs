using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using ShamsAlShamoos03.Infrastructure;
using ShamsAlShamoos03.Infrastructure.Persistence.Contexts;
using ShamsAlShamoos03.Infrastructure.Persistence.Repositories;
using ShamsAlShamoos03.Infrastructure.Persistence.UnitOfWork;
using ShamsAlShamoos03.Server.Services;
using ShamsAlShamoos03.Shared.Entities;
using Syncfusion.Licensing;
using System.Globalization;
using Microsoft.AspNetCore.DataProtection;
using System.IO;
// ========================================
// فارسی سازی
// ========================================
var culture = new CultureInfo("fa-IR");

CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

// ========================================
// Syncfusion License
// ========================================
var licenseKey = "MTU4NUAzMjM3MkUzMTJFMzluT08wbzRnYm4zUlFDOVRzWVpYbUtuSEl0aUhTZmNMYjQxekhrV0NVRnlzPQ==";

SyncfusionLicenseProvider.RegisterLicense(licenseKey);

// ========================================
// Builder
// ========================================
var builder = WebApplication.CreateBuilder(args);

// ========================================
// Services
// ========================================

// Controllers + Swagger
builder.Services.AddControllers();

 

 
// CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(@"C:\Keys"))
    .SetApplicationName("ShamsAlShamoos");

// Session
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Identity
builder.Services
    .AddIdentity<ApplicationUsers, ApplicationRoles>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login";
});

// Authorization
builder.Services.AddAuthorization();

// Repository + UnitOfWork
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IDapperGenericRepository, DapperGenericRepository>();

builder.Services.AddScoped<APIDataService01>();

// Infrastructure
builder.Services.AddInfrastructure(builder.Configuration);

// AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// ========================================
// Build App
// ========================================
var app = builder.Build();

// ========================================
// Create Folders
// ========================================
var qrFilesPath = Path.Combine(
    Directory.GetCurrentDirectory(),
    "QrFiles");

if (!Directory.Exists(qrFilesPath))
{
    Directory.CreateDirectory(qrFilesPath);
}

var personelImagePath = @"D:\upload\PersonelImage1";

 

// Routing
app.UseRouting();

// Blazor Files
app.UseBlazorFrameworkFiles();

// wwwroot
app.UseStaticFiles();

// QrFiles
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(qrFilesPath),
    RequestPath = "/QrFiles"
});


 
if (!Directory.Exists(personelImagePath))
{
    Directory.CreateDirectory(personelImagePath);
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(personelImagePath),
    RequestPath = "/PersonelImage1"
});

//// Personel Images
//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(personelImagePath),
//    RequestPath = "/PersonelImage1"
//});

// CORS
app.UseCors();

// Session
app.UseSession();

// Auth
app.UseAuthentication();

app.UseAuthorization();

// Controllers
app.MapControllers();

// Blazor Fallback
app.MapFallbackToFile("index.html");

// ========================================
// Run
// ========================================
app.Run();