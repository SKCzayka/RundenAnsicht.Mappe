using RundenAnsicht.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RundenAnsicht
{
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

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

        private void IntChange_Click(object sender, RoutedEventArgs e)

        {
            string name = targetname.Text;
            int ini = int.Parse(targetIni.Text);
            viewModel.InitativChange(name, ini);

        }

        private void Beginnen_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Beginn();
            Beginn.Visibility= Visibility.Hidden;
        }

    }
}
