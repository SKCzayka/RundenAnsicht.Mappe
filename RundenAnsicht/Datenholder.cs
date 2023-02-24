using RundenAnsicht.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RundenAnsicht;
    public class Datenholder //: INotifyPropertyChanged
    {
    public Datenholder()
    {
        List<Kampfteilnehmer> kampfteilnehmers = new List<Kampfteilnehmer>();

    }
        
        /*public List<Kampfteilnehmer> kampfteilnehmers
        {
            get { return _kampfteilnehmers; }
            set
            {
                _kampfteilnehmers = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("kampfteilnehmers"));
            }
        }

    public event PropertyChangedEventHandler? PropertyChanged;*/
}

