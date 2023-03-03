﻿

namespace RundenAnsicht;

/// <summary>
/// Interaktionslogik für Ansicht.xaml
/// </summary>
public partial class Ansicht : Page, INotifyPropertyChanged
{
    private AnsichtViewModel _viewModel;
    public Ansicht(AnsichtViewModel ansichtViewModel)
    {
        viewModel= ansichtViewModel;
        InitializeComponent();


        Kampfrunde.ItemsSource= viewModel.Round;

        Neue_Runde.ItemsSource= viewModel.Next_Round;

    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void Next_Click(object sender, RoutedEventArgs e)
    {
        viewModel.Next_One();

    }

    private void Round_Next_Click(object sender, RoutedEventArgs e)
    {
        viewModel.Round_End();
    }
    public AnsichtViewModel viewModel
    {
        get { return _viewModel; }
        set
        {
            _viewModel = value;
            if (PropertyChanged !=null)
                PropertyChanged(this, new PropertyChangedEventArgs("viewModel"));
        }

    }
    private void Beginnen_Click(object sender, RoutedEventArgs e)
    {
        viewModel.Beginn();
        Beginn.Visibility= Visibility.Hidden;
    }

    private void IniChange_Click(object sender, RoutedEventArgs e)
    {
        viewModel.IniShow();
        back.Visibility= Visibility.Visible;
        
    }

    private void LPChange_Click(object sender, RoutedEventArgs e)
    {
        viewModel.LPshow();
        back.Visibility= Visibility.Hidden;
    }

    private void back_Click(object sender, RoutedEventArgs e)
    {
        viewModel.Back();
        back.Visibility = Visibility.Hidden;
    }
}
