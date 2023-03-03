

using RundenAnsicht.viewModels;

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
                //Seiten und Fenster
                .AddSingleton<Konsole>()
                .AddSingleton<Anfrage>()
                .AddSingleton<Ansicht>()
                .AddSingleton<InitativeChange>()
                .AddSingleton<LPChange>()

                //Datehaltert
                .AddSingleton<Datenholder>()

                //ViewModels
                .AddSingleton<AnfrageViewModel>()
                .AddSingleton<KonsoleViewModel>()
                .AddSingleton<AnsichtViewModel>()
                .AddSingleton<InitiativeChangeViewModel>()
                .AddSingleton<LPviewModel>();
                

            serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetRequiredService<Konsole>().Show();

        }
    }
}
