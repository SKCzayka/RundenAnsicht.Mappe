using RundenAnsicht.viewModels;
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
    /// Interaktionslogik für LPChange.xaml
    /// </summary>
    public partial class LPChange : Page
    {
        public LPviewModel ViewModel { get; }
        public bool HitorHeal { get; set; }
        public LPChange(LPviewModel lpviewModel)
        {


            ViewModel = lpviewModel;
            InitializeComponent();

        }
        private void LPChange_Click(object sender, RoutedEventArgs e)

        {
                string name = targetname.Text;
                int lp = int.Parse(targetLP.Text);
                ViewModel.LPChange(name, lp, HitorHeal);

            
        }

        private void Hit_Checked(object sender, RoutedEventArgs e)
        {
            if( HitorHeal == false)
            {  HitorHeal =true; }
        }

        private void Heal_Checked(object sender, RoutedEventArgs e)
        {
            if ( HitorHeal)
            { HitorHeal =false; }
        }
    }
    
}
