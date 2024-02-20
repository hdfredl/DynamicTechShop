using Blazored.LocalStorage;
using DynamicTechShop;
using DynamicTechShop.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage(); // lägg till AddBlazfor för att aktivera funktionen.. glömde bort att använda denna :^ ) 

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddSingleton<DynamicTechShop.Service.CartService>(); // Är en global Cart, dvs alla users ser samma cart. 
builder.Services.AddScoped<CartService>(); // Gör att varje user får en egen Scope, av en CartService. Individuell cart så man alla users delar på en cart.

await builder.Build().RunAsync();
