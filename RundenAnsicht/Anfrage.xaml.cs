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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RundenAnsicht
{
    
    public partial class Anfrage : Page
    {
        private AnfrageViewModel viewModel = new AnfrageViewModel();
        public bool Typen { get; set; }
        public Anfrage()
        {
            InitializeComponent();
            

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            string teil= Teilnehmer.Text;
            int Initati = int.Parse(Initativ.Text);
            viewModel.Add(teil, Initati,Typen);  

        }
      
        private void NeuSpieler_Checked(object sender, RoutedEventArgs e)
        {
            if (Typen == false) Typen= true;
            
        }

        private void NeuGegner_Checked(object sender, RoutedEventArgs e)
        {
            if (Typen) Typen = false;

        }
    }
}
