using CPS_App.Models;
using CPS_App.Services;
using CPS_App.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System.Configuration;
using System.Diagnostics;
using System.Security.Principal;
using CommonDBUtils;
using Serilog;
using static CPS_App.Models.CPSModel;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using CPS_App.Data;

namespace CPS_App
{
    public class Program
    {

        public static IConfiguration _configuration { get; set; }
        [STAThread]

        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();

            
            
            
            
            //Application.Run(ServiceProvider.GetRequiredService<ScheduleTask>());
            //Application.Run(ServiceProvider.GetRequiredService<Dashboard>());
            //Application.Run(ServiceProvider.GetRequiredService<Request_Create>());
            //Application.Run(ServiceProvider.GetRequiredService<Register>());
        }
        
        static async Task MainAsync(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            ApplicationConfiguration.Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IHost host = Host.CreateDefaultBuilder()
                            .ConfigureAppConfiguration((hostContext, config) =>
                            {
                                config.AddJsonFile("serilog.config.json");
                            })
                            .ConfigureServices((services) =>
                            {
                                ConfigureServices(services);

                            })
                            .Build();

            var ServiceProvider = host.Services;
            var scheduler = ServiceProvider.GetRequiredService<ScheduleTask>();
            //await scheduler.RequestMappingScheduler();
            Application.Run(ServiceProvider.GetRequiredService<Login>());
            //Application.Run(ServiceProvider.GetRequiredService<Login>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<AppUsers, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddScoped<RegisterServices>();
            
            services.AddSingleton<GenUtil>();
            services.AddSingleton<Db>();
            services.AddSingleton<AccountServices>();
            services.AddSingleton<AppConfig>();
            services.AddScoped<Dashboard>();
            services.AddScoped<Register>();
            services.AddScoped<Login>();
            services.AddSingleton<Validator>();
            services.AddSingleton<frmHome>();
            services.AddSingleton<DbServices>();
            services.AddScoped<ClaimsManager>();
            services.AddScoped<RequestMapping>();
            services.AddScoped<DbGeneralServices>();
            services.AddScoped<POAWorker>();
            services.AddScoped<SearchFunc>();
            services.AddScoped<ManualMappingProcess>();
            services.AddScoped<GenericTableViewWorker>();
            services.AddScoped<CreateDNServices>();
            services.AddSingleton<ScheduleTask>();
            services.AddScoped<StockLevelWorker>();
            services.AddScoped<CreatePoServices>();
            services.Configure<IdentityOptions>(options =>
            {
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

            });

            services.AddScoped<RequestCreate>();
            services.AddScoped<AuthService>();

            services.AddDbContext<ApplicationDbContext>();

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AdminOnly", policy => policy.RequireClaim("roles", "admin"));
            //    options.AddPolicy("AdminUserOnly", policy => policy.RequireClaim("roles", "admin", "user"));
            //});
        }

    }

}