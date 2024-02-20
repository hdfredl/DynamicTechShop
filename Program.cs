using Blazored.LocalStorage;
using DynamicTechShop;
using DynamicTechShop.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage(); // l�gg till AddBlazfor f�r att aktivera funktionen.. gl�mde bort att anv�nda denna :^ ) 

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddSingleton<DynamicTechShop.Service.CartService>(); // �r en global Cart, dvs alla users ser samma cart. 
builder.Services.AddScoped<CartService>(); // G�r att varje user f�r en egen Scope, av en CartService. Individuell cart s� man alla users delar p� en cart.

await builder.Build().RunAsync();
