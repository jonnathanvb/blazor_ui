using app;
using app.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(Configuracao.urlBase) });

builder.Services.AddScoped<LoginServices, LoginServices>();
builder.Services.AddScoped<ProdutoServices, ProdutoServices>();



await builder.Build().RunAsync();
