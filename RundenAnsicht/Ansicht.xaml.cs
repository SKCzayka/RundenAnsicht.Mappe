using RundenAnsicht.Model;
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
    /// <summary>
    /// Interaktionslogik für Ansicht.xaml
    /// </summary>
    public partial class Ansicht : Page
    {
        public List <Kampfteilnehmer> Round { get; set; }
        public List <Kampfteilnehmer> Next_Round { get; set; }

        public List<Kampfteilnehmer> kampfteilnehmers { get; set; }

        public Ansicht( )
        {
            
            InitializeComponent();
            if(Round != null)
            {
                List<Kampfteilnehmer> Round = kampfteilnehmers.ToList();

            }
            
            Kampfrunde.ItemsSource= Round;
            Neue_Runde.ItemsSource= Next_Round;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
