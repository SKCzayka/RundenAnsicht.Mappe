using Microsoft.Extensions.DependencyInjection;
using RundenAnsicht.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RundenAnsicht
{
    public class KonsoleViewModel : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler? PropertyChanged;
        public Datenholder Datenholder { get; set; }

        private Page _page;

        public Page Page { 
            get { return _page; }
            set 
            {
                _page = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Page"));
            }
        }
        private Anfrage _anfrage;
        private Ansicht _ansicht;

        public KonsoleViewModel(Datenholder datenholder)
            
        {
            Datenholder = datenholder;
            _anfrage = App.serviceProvider.GetService<Anfrage>();
            _ansicht = App.serviceProvider.GetService<Ansicht>();

            Page = _anfrage;
        }

        public bool Show()
        {
            
            
            bool oneHero=false;
            bool oneEnemy=false;
             foreach(var item in Datenholder.Kampfteilnehmers) 
            { 
                if(item.Typ ==true)
                {
                    oneHero= true;
                }

                else if (item.Typ == false)
                {
                    oneEnemy= true;
                }
                
            }

            if(Datenholder.Kampfteilnehmers.Count > 0 && oneHero && oneEnemy)
            {
                Page = _ansicht;
                return true;
            }
            else
            {
                MessageBox.Show("Bitte mindesten ein Spieler und Ein Gegner müssenh vorhanden sein");
                return false;
            }
            
        }
       
    }
}
