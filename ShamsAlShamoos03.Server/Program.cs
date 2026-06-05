using Microsoft.AspNetCore.DataProtection;
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

var culture = new CultureInfo("fa-IR");

CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

var licenseKey = "MTU4NUAzMjM3MkUzMTJFMzluT08wbzRnYm4zUlFDOVRzWVpYbUtuSEl0aUhTZmNMYjQxekhrV0NVRnlzPQ==";

SyncfusionLicenseProvider.RegisterLicense(licenseKey);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

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

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services
    .AddIdentity<ApplicationUsers, ApplicationRoles>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login";
});

builder.Services.AddAuthorization();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IDapperGenericRepository, DapperGenericRepository>();

builder.Services.AddScoped<APIDataService01>();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddAutoMapper(cfg => { },
    AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

var qrFilesPath = Path.Combine(
    Directory.GetCurrentDirectory(),
    "QrFiles");

if (!Directory.Exists(qrFilesPath))
{
    Directory.CreateDirectory(qrFilesPath);
}

var personelImagePath = @"D:\upload\PersonelImage1";

app.UseRouting();

app.UseBlazorFrameworkFiles();

app.UseStaticFiles();

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

app.UseCors();

app.UseSession();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();
