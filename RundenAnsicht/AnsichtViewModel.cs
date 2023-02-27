using RundenAnsicht.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RundenAnsicht
{
    public class AnsichtViewModel : INotifyPropertyChanged
    {
        private Datenholder _Datenholdern { get; set; }
        public List<Kampfteilnehmer> Round { get; set; }
        public List<Kampfteilnehmer> Next_Round { get; set; }


        public AnsichtViewModel(Datenholder datenholder)
        {
            Datenholder= datenholder;

            Next_Round = new List<Kampfteilnehmer>();
            Round = Datenholder.Kampfteilnehmers;
            Round.OrderByDescending(Kampfteilnehmer => Kampfteilnehmer.Init).ToList();
        }

        public void Next_One()
        {
            if (Round.Count > 0)
            {
                Next_Round.Add(Round[0]);
                Round.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Kein Teilnehmer vorhanden, Bitte Starten Sie eine Neue Runde");
            }
        }

        public void Round_End()
        {
            Round = Next_Round;
            Next_Round.Clear();

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public Datenholder Datenholder
        {
            get { return _Datenholdern; }
            set
            {
                _Datenholdern = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Datenholder"));
            }
        }
        
    }
}
