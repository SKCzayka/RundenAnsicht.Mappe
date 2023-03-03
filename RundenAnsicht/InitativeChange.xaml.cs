

namespace RundenAnsicht;

/// <summary>
/// Interaktionslogik für InitativeChange.xaml
/// </summary>
public partial class InitativeChange : Page
{
    public InitiativeChangeViewModel viewModel { get; }
    public InitativeChange(InitiativeChangeViewModel initiativeChangeViewModel)
    {
        viewModel = initiativeChangeViewModel;
        InitializeComponent();
       
    }
    private void IntChange_Click(object sender, RoutedEventArgs e)

    {
        string name = targetname.Text;
        int ini = int.Parse(targetIni.Text);
        viewModel.InitativChange(name, ini);

    }
}
