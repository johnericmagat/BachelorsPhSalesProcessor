using BachelorsPhSalesProcessor.Abstractions.Persistence.BrbRaw;
using BachelorsPhSalesProcessor.Abstractions.Services.BrbRaw;
using BachelorsPhSalesProcessor.Infrastructure;
using BachelorsPhSalesProcessor.Infrastructure.BrbRaw;
using BachelorsPhSalesProcessor.Infrastructure.Dapper.Context;
using BachelorsPhSalesProcessor.Infrastructure.Sales;
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
                    var connectionString = context.Configuration.GetConnectionString("SalesDB");
                    var brbRawConnectionString = context.Configuration.GetConnectionString("BrbRawDB");

                    // EF Core contexts
                    services.AddDbContext<SalesDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    services.AddDbContext<BrbRawDbContext>(options =>
                        options.UseSqlServer(brbRawConnectionString));

                    // Dapper contexts
                    services.Configure<DapperContextOptions>("Sales", o => o.ConnectionString = connectionString);
                    services.Configure<DapperContextOptions>("BrbRaw", o => o.ConnectionString = brbRawConnectionString);

                    services.AddTransient<ISalesDapperContext, SalesDapperContext>();
                    services.AddTransient<IBrbRawDapperContext, BrbRawDapperContext>();

                    // MediatR
                    services.AddMediatR(cfg =>
                    {
                        cfg.RegisterServicesFromAssembly(typeof(SalesRawService).Assembly);
                    });

                    // Application services
                    services.AddScoped<ISalesRawService, SalesRawService>();
                    services.AddScoped<IBrbRawRepository, BrbRawRepository>();

                    // WPF
                    services.AddSingleton<MainWindow>();
                })
                .Build();

            MigrateDatabaseExtension.MigrateDatabases(AppHost.Services,
                typeof(SalesDbContext),
                typeof(BrbRawDbContext));
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
