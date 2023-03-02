

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
                .AddSingleton<Anfrage>()
                .AddSingleton<Ansicht>()
                .AddSingleton<InitativeChange>()
                .AddSingleton<Datenholder>()
                .AddSingleton<AnfrageViewModel>()
                .AddSingleton<KonsoleViewModel>()
                .AddSingleton<AnsichtViewModel>()
                .AddSingleton<InitiativeChangeViewModel>();
                

            serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetRequiredService<Konsole>().Show();

        }
    }
}
