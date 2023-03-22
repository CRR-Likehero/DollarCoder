using DollarCoder;
using DollarCoder.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<Game>();
builder.Services.AddSingleton<AtmMachine>();
builder.Services.AddSingleton<Player>();
builder.Services.AddSingleton<ItemShop>();
builder.Services.AddSingleton<RandomCode>();
builder.Services.AddSingleton<CoursesShop>();
builder.Services.AddSingleton<CodeEditor>();

await builder.Build().RunAsync();
