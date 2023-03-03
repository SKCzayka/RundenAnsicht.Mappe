

namespace RundenAnsicht;

/// <summary>
/// Interaktionslogik für InitativeChange.xaml
/// </summary>
public partial class InitativeChange : Page
{
    public InitiativeChangeViewModel ViewModel { get; }
    public InitativeChange(InitiativeChangeViewModel initiativeChangeViewModel)
    {
        ViewModel = initiativeChangeViewModel;
        InitializeComponent();
       
    }
    private void IntChange_Click(object sender, RoutedEventArgs e)

    {
        string name = targetname.Text;
        int ini = int.Parse(targetIni.Text);
        ViewModel.InitativChange(name, ini);

    }
}
