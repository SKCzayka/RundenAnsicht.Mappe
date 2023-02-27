using RundenAnsicht.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RundenAnsicht;
public class Datenholder : INotifyPropertyChanged
{
    private List<Kampfteilnehmer> _Kampfteilnehmers { get; set; }

    public Datenholder()
    {
        Kampfteilnehmers = new List<Kampfteilnehmer>();

    }
    public event PropertyChangedEventHandler? PropertyChanged;


    public List<Kampfteilnehmer> Kampfteilnehmers
    {
        get { return _Kampfteilnehmers; }
        set
        {
            _Kampfteilnehmers = value;
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("kampfteilnehmers"));
        }
    }
}

    


        
       

