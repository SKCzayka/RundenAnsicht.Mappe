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
        private Datenholder _Datenholdern;

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
                    int lp = item.LP;
                    int lpmax = item.MaxLP;

                    Datenholder.Kampfteilnehmers.Remove(item);
                    Datenholder.Kampfteilnehmers.Add(new() { Name = name, Init = initiv, Typ =Typen, LP =lp , MaxLP =lpmax});
                    break;

                }
            }


            // Nofify
        }
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

   
      

       
    
