using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RundenAnsicht.viewModels
{
    public class LPviewModel: INotifyPropertyChanged
    {
        private Datenholder _Datenholdern;

        public event PropertyChangedEventHandler? PropertyChanged;
        public LPviewModel(Datenholder datenholder)
        {
            Datenholder = datenholder;
        }

        public void LPChange(string name, int lp, bool HitorHeal )
        {
            foreach (var item in Datenholder.Kampfteilnehmers)
            {
                if (item.Name == name)
                {

                    bool Typen = item.Typ;
                    int initiv = item.Init;
                    int maxlp = item.MaxLP; 

                    if(HitorHeal)
                    { 
                        lp = item.LP -lp;
                    }
                    else
                    {
                        lp = item.LP +lp;
                        if(item.MaxLP < lp)
                        {
                            lp = item.MaxLP;
                        }
                    }
                   

                    Datenholder.Kampfteilnehmers.Remove(item);
                    Datenholder.Kampfteilnehmers.Add(new() { Name = name, Init = initiv, Typ =Typen, LP =lp ,MaxLP = maxlp});
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
