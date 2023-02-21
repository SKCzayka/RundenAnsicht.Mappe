using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace RundenAnsicht
{
    /// <summary>
    /// Interaktionslogik für Konsole.xaml
    /// </summary>
    public partial class Konsole : Window
    { 
        private KonsoleViewModel _viewModel;
    
        public Konsole()
        {
            InitializeComponent();
            _viewModel = (KonsoleViewModel)DataContext;
             
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Möchten Sie Schließen? Es wird nicht gespeichert");
            this.Close();
            
        }

    }
}
