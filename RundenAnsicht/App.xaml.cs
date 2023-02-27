using Microsoft.Extensions.DependencyInjection;
using RundenAnsicht.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RundenAnsicht
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ServiceProvider serviceProvider { get; private set; }
        
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ServiceCollection services = new ServiceCollection();

            services
                .AddSingleton<Konsole>()
                .AddTransient<Anfrage>()
                .AddSingleton<Ansicht>()
                .AddSingleton<Datenholder>()
                .AddSingleton<AnfrageViewModel>()
                .AddSingleton<KonsoleViewModel>()
                .AddSingleton<AnsichtViewModel>();
                

            serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetRequiredService<Konsole>().Show();

        }
    }
}
