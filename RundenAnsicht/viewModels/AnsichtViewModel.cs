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
        private Datenholder _Datenholdern;
        private ObservableCollection<Kampfteilnehmer> _Round;
        private ObservableCollection<Kampfteilnehmer> _Next_Round;


        public AnsichtViewModel(Datenholder datenholder)
        {
            Datenholder= datenholder;



            Round = Datenholder.Kampfteilnehmers;
            Round = (ObservableCollection<Kampfteilnehmer>)Round.OrderBy(x  =>  x.Init);
            Next_Round = new ObservableCollection<Kampfteilnehmer>();
            
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
            foreach(var Item in Next_Round) 
            {
                Round.Add(Item);
            }
            Round = (ObservableCollection<Kampfteilnehmer>)Round.OrderByDescending(x => x.Init);
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
        public ObservableCollection<Kampfteilnehmer> Round
        { 
            get { return _Round; }
            set
            {
                _Round = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Round"));
            }
         }
        public ObservableCollection<Kampfteilnehmer> Next_Round
        { get { return _Next_Round; }
        set
            {
                _Next_Round = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Next_Round"));
            }
        }
    }
}
