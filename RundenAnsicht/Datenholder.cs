using RundenAnsicht.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RundenAnsicht;
public class Datenholder 
{
    public ObservableCollection<Kampfteilnehmer> Kampfteilnehmers { get; set; }

    public Datenholder()
    {
        Kampfteilnehmers = new ObservableCollection<Kampfteilnehmer>();

    }
    
}

    


        
       

