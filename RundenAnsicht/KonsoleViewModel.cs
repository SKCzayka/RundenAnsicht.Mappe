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
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Page"));
            }
        }
        private Anfrage _anfrage;

        public KonsoleViewModel()
        {
            _anfrage = App.serviceProvider.GetService<Anfrage>();

            Page = _anfrage;
        }

        public void Show()
        {
         
        }
    }
}
