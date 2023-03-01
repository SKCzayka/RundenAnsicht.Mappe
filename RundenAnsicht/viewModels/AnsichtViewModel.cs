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
using System.Windows.Media;

namespace RundenAnsicht
{
    public class AnsichtViewModel : INotifyPropertyChanged
    {
        private Datenholder _Datenholdern;
        public ObservableCollection<Kampfteilnehmer> Round { get; set; }
        public ObservableCollection<Kampfteilnehmer> Next_Round { get; set; }
        private ObservableCollection<Kampfteilnehmer> _Halter;


        public AnsichtViewModel(Datenholder datenholder)
        {
            Datenholder= datenholder;

            Next_Round = new ObservableCollection<Kampfteilnehmer>();
            Round = new ObservableCollection<Kampfteilnehmer>();
            Halter= new ObservableCollection<Kampfteilnehmer>();

            
        }
        public void Beginn()
        {
            Halter =  new ObservableCollection<Kampfteilnehmer>(Datenholder.Kampfteilnehmers.OrderByDescending(x => x.Init));// Erstellt eine neue Sequence
            foreach (var item in Halter)
            {
              Round.Add(item);    
            }
           
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

            Next_Round.Clear();

        }

        public void InitativChange(string name, int initiv)
        {
           foreach (var item in Round)
            {
                if(item.Name == name)
                {
                    bool Typen = item.Typ;

                    Round.Remove(item);
                    Round.Add(new() { Name = name, Init = initiv, Typ =Typen });
                    break;
                
                }
            }
            Halter = new ObservableCollection<Kampfteilnehmer>(Round.OrderByDescending(x => x.Init));
            Round.Clear();
            foreach(var item in Halter) 
            { Round.Add(item); }
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
        public ObservableCollection<Kampfteilnehmer> Halter
        {
            get { return _Halter; }
            set
            {
                _Halter = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Round"));
            }
         }
       
        }
    }

