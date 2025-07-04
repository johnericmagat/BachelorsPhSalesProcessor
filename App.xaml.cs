using BachelorsPhSalesProcessor.Abstractions.Persistence;
using BachelorsPhSalesProcessor.Abstractions.Services.BrbRaw;
using BachelorsPhSalesProcessor.Infrastructure;
using BachelorsPhSalesProcessor.Services.BrbRaw;
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
    public partial class App : System.Windows.Application
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
                    string brbRawConnectionString = context.Configuration.GetConnectionString("BrbRawDB");

                    // Register DbContext (EF Core)
                    services.AddDbContext<SalesDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    // Register Dapper contexts
                    services.AddDapperContext(options =>
                        options.ConnectionString = connectionString);

                    services.AddDapperContext(options =>
                        options.ConnectionString = brbRawConnectionString);

                    // Register MediatR handlers
                    services.AddMediatR(cfg =>
                    {
                        cfg.RegisterServicesFromAssembly(typeof(SalesRawService).Assembly);
                    });

                    // Register core services
                    services.AddScoped<ISalesRawService, SalesRawService>();
                    services.AddScoped<IBrbRawRepository, BrbRawRepository>();

                    // Register the WPF Main Window
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
