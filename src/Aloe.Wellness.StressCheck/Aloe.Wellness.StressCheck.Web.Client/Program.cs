using Aloe.Wellness.StressCheck.Shared.Services;
using Aloe.Wellness.StressCheck.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the Aloe.Wellness.StressCheck.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
