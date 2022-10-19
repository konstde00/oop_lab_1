using System;
using System.Windows.Forms;
using Excel.service;
using Excel.service.impl;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Excel
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var host = CreateHostBuilder().Build();

            Application.Run(host.Services.GetRequiredService<MyExcel>());
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services)=>{
                    services.AddTransient<ICellService, CellService>();
                    services.AddTransient<ITableService, TableService>();
                    services.AddTransient<MyExcel>();
                });
        }

    }
}
