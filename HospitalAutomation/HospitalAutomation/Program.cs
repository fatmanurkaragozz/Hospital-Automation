using System;
using System.Windows.Forms;
using HospitalAutomation.Services;
using Microsoft.Extensions.DependencyInjection;
using HospitalAutomation.Interfaces;

namespace HospitalAutomation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// Bağımlılık enjeksiyon konteynerini başlatıyoruz
            //var serviceProvider = new ServiceCollection()  // System.Web.Services.Description yerine Microsoft.Extensions.DependencyInjection kullanıyoruz
            //    .AddTransient<IRandevuService, RandevuService>()  // RandevuService'i IRandevuService olarak kaydediyoruz
            //    .AddTransient<IHastaService, HastaService>()      // HastaService'i IHastaService olarak kaydediyoruz
            //    .AddTransient<IRaporService, RaporService>()
            //    //.AddTransient<IBransService, BransService>()
            //    //.AddTransient<IDoktorService, DoktorService>()
            //    //.AddTransient<ISekreterService, SekreterService>()



            //    .AddSingleton<SqlBaglantisi>()                     // SqlBaglantisi'ni singleton olarak kaydediyoruz
            //    .BuildServiceProvider();

            // FormAnaSayfa formunu DI konteyneriyle başlatıyoruz
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAnaSayfa());
            // serviceProvider.GetService<IRandevuService>(),serviceProvider.GetService<IHastaService>()
        }
    }
}
