using System;
using Avalonia;
using Data.MemoryFlow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MemoryFlow
{
    internal sealed class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddDbContext<MemoryFlowDbContext>(options =>
                options.UseSqlite("Data Source=./Data/MemoryFlow.db"));

            var serviceProvider = services.BuildServiceProvider();

            // Optionally store serviceProvider globally if needed

            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace();
    }
}
