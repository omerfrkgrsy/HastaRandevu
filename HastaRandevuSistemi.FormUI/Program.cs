using AutoMapper;
using HastaRandevuSistemi.Repository;
using HastaRandevuSistemi.Repository.EntityFramework.Abstract;
using HastaRandevuSistemi.Repository.EntityFramework.Context;
using HastaRandevuSistemi.Service.Abstract;
using HastaRandevuSistemi.Service.Concrete;
using HastaRandevuSistemi.Service.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectNoName.Repository.EntityFramework.Concrete;
using System.Configuration;

namespace HastaRandevuSistemi.FormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<Login>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<DataContext>(options => options.UseSqlite("Data Source =" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "test.db"));
                    services.AddTransient<SekreterForm>();
                    services.AddTransient<Login>();
                    services.AddTransient<SekreterGirisForm>();
                    services.AddTransient<SekreterMenu>();
                    services.AddTransient<HastaForm>();
                    services.AddTransient<DoktorForm>();
                    services.AddTransient<RandevuForm>();
                    services.AddTransient<DoktorGiris>();
                    services.AddTransient<RandevuDetay>();
                    services.AddTransient<DoktorMenu>();
                    services.AddSingleton(mapper);
                    services.AddScoped<ISekreterRepository, SekreterRepository>();
                    services.AddScoped<ISekreterService, SekreterService>();
                    services.AddScoped<IDoktorService, DoktorService>();
                    services.AddScoped<IDoktorRepository, DoktorRepository>();
                    services.AddScoped<IHastaService, HastaService>();
                    services.AddScoped<IHastaRepository, HastaRepository>();
                    services.AddScoped<IBransService, BransService>();
                    services.AddScoped<IBransRepository, BransRepository>();
                    services.AddScoped<IRandevuSaatService, RandevuSaatService>();
                    services.AddScoped<IRandevuSaatRepository, RandevuSaatRepository>();
                    services.AddScoped<IRandevuService, RandevuService>();
                    services.AddScoped<IRandevuRepository, RandevuRepository>();
                });
        }
    }
}