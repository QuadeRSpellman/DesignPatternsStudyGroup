using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SomeApp.Blazor.Services.Decorator;
using SomeApp.Blazor.Services.Factories;
using SomeApp.Blazor.Services.Implementations;
using SomeApp.Blazor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SomeApp.Blazor
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("app");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			builder.Services.AddSingleton<IGlobalInfo, GlobalInfo>();
			builder.Services.AddSingleton<GlobalInfoLoggingDecorator>();
			builder.Services.AddScoped<CommandManager>();
			builder.Services.AddScoped<AddUserCommandFactory>();
			builder.Services.AddScoped<RemoveUserCommandFactory>();

			await builder.Build().RunAsync();
		}
	}
}
