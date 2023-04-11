using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TicketReservation;
using TicketReservation.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp =>
	new HttpClient
	{
		BaseAddress = new Uri("https://localhost:7205/")
	});
builder.Services.AddScoped<CurrentContextData>();
await builder.Build().RunAsync();