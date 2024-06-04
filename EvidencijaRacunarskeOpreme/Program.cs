using EvidencijaRacunarskeOpreme.Semanticka.SemantickiServisi;
using EvidencijaRacunarskeOpreme.Semanticka.SemantickiServisi.SemantickiInterfejsi;
using EvidencijaRacunarskeOpreme.Tehnoloska.RadSaPodacima;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Hosting;
using System.ComponentModel.Design;
using System.Configuration;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace EvidencijaRacunarskeOpreme
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var host = RegistrujServise().Build();
            ProvajderUsluga = host.Services;
            ApplicationConfiguration.Initialize();
          
            
           
            
            Application.Run(ProvajderUsluga.GetRequiredService<Form1>());
            


        }
        public static IServiceProvider ProvajderUsluga { get; set; }
        public static IHostBuilder RegistrujServise()
        {
            return Host.CreateDefaultBuilder()
            .ConfigureServices((kontekst, servisi) => {
                servisi.AddScoped<IRacunarskaOpremaServis, RacunarskaOpremaServis>();
                servisi.AddDbContext<DbContextBaza>(opcije => opcije.UseSqlServer(ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString));
                servisi.AddTransient<Form1>();
            });

            
        }
    }
}