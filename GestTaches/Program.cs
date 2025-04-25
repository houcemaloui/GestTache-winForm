using System;
using System.Windows.Forms;
using Autofac;
using GestTaches.Core.Abstractions;
using GestTaches.Core.Services; 
using GestTaches.Data.Repositories;
using GestTaches.Views;

namespace GestTaches
{
    internal static class Program
    {
        /// <summary>
        /// point d'entrée principal de l'application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterType<TacheRepository>().As<ITacheStorage>();
            builder.RegisterType<TacheService>().As<ITacheService>(); 
            var container = builder.Build();

            // résolution des dependances
            var tacheService = container.Resolve<ITacheService>();

            Application.Run(new GestTacheForm(tacheService));
        }
    }
}
