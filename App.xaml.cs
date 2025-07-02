using BachelorsPhSalesProcessor.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace BachelorsPhSalesProcessor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(config =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    string connectionString = context.Configuration.GetConnectionString("SalesDB");

                    services.AddDbContext<SalesDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    // Register other services and windows
                    services.AddDapperContext(options =>
                        options.ConnectionString = connectionString);

                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost.StartAsync();

            var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();
            base.OnExit(e);
        }
    }
}
