using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShamsAlShamoos03.Client.Client;
//using ShamsAlShamoos03.Client.Client.Services;
using ShamsAlShamoos03.Client.Services;
using Syncfusion.Blazor;
using Syncfusion.Licensing;
using System.Globalization;

//فارسی کردن
var culture = new CultureInfo("fa-IR");
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;
//فارسی کردن 

var licenseKey = "MTU4NUAzMjM3MkUzMTJFMzluT08wbzRnYm4zUlFDOVRzWVpYbUtuSEl0aUhTZmNMYjQxekhrV0NVRnlzPQ==";

SyncfusionLicenseProvider.RegisterLicense(licenseKey);




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");




// HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// سایر سرویس‌های پروژه


// رجیستر سرویس‌های خودت
builder.Services.AddScoped<HistoryRegisterService>();

// رجیستر Syncfusion
builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped<AuthenticationStateProvider, SimpleAuthProvider>();



builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<SimpleAuthProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(sp =>
    sp.GetRequiredService<SimpleAuthProvider>());




builder.Services.AddScoped(sp =>
{
    string baseUrl;
    if (builder.HostEnvironment.IsDevelopment())
    {
        // محیط توسعه → BaseAddress روی پورت سرور لوکال
        baseUrl = "http://localhost:5224/";
    }
    else
    {
        // محیط Production → BaseAddress داینامیک
        baseUrl = builder.HostEnvironment.BaseAddress;
    }

    return new HttpClient
    {
        BaseAddress = new Uri(baseUrl)
    };
});



await builder.Build().RunAsync();
