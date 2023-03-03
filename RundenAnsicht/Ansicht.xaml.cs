

namespace RundenAnsicht;

/// <summary>
/// Interaktionslogik für Ansicht.xaml
/// </summary>
public partial class Ansicht : Page, INotifyPropertyChanged
{
    private AnsichtViewModel _viewModel;
    public Ansicht(AnsichtViewModel ansichtViewModel)
    {
        ViewModel= ansichtViewModel;
        InitializeComponent();


        Kampfrunde.ItemsSource= ViewModel.Round;

        Neue_Runde.ItemsSource= ViewModel.Next_Round;

    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void Next_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.Next_One();

    }

    private void Round_Next_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.Round_End();
    }
    public AnsichtViewModel ViewModel
    {
        get { return _viewModel; }
        set
        {
            _viewModel = value;
            if (PropertyChanged !=null)
                PropertyChanged(this, new PropertyChangedEventArgs("viewModel"));
        }

    }
    //vorsortierung
    private void Beginnen_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.SortDatenholder();
        Beginn.Visibility= Visibility.Hidden;
    }

    //Änderungs menü
    private void IniChange_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.IniShow();
        check.Visibility= Visibility.Visible;
        
    }

    private void LPChange_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.LPshow();
        check.Visibility= Visibility.Hidden;
    }

    private void Check_Click(object sender, RoutedEventArgs e)
    {
        ViewModel.Check();
        check.Visibility = Visibility.Hidden;
    }
}
