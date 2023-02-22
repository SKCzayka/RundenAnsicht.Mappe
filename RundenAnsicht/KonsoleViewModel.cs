using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RundenAnsicht
{
    public class KonsoleViewModel : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler? PropertyChanged;

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

        public KonsoleViewModel()
        {
            _anfrage = App.serviceProvider.GetService<Anfrage>();
            _ansicht = App.serviceProvider.GetService<Ansicht>();

            Page = _anfrage;
        }

        public void show()
        {
            Page = _ansicht;
        }
       
    }
}
