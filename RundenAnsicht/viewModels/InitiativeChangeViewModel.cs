using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace RundenAnsicht
{
    public class InitiativeChangeViewModel : INotifyPropertyChanged
    {
        public Datenholder _Datenholder;

        public event PropertyChangedEventHandler? PropertyChanged;
        public InitiativeChangeViewModel(Datenholder datenholder)
        {
            Datenholder = datenholder;   
        }

        public void InitativChange(string name, int initiv)
        {
            foreach (var item in Datenholder.Kampfteilnehmers)
            {
                if (item.Name == name)
                {
                    bool Typen = item.Typ;

                    Datenholder.Kampfteilnehmers.Remove(item);
                    Datenholder.Kampfteilnehmers.Add(new() { Name = name, Init = initiv, Typ =Typen });
                    break;

                }
            }

        }
        public Datenholder Datenholder 
        { 
            get { return _Datenholder; }
            set {
                _Datenholder = value;
                if (value != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Datenholder"));
            }
        }
    }

 }

   
      

       
    
