using RundenAnsicht.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RundenAnsicht
{
    public class AnfrageViewModel : INotifyPropertyChanged
    {
       private List<Kampfteilnehmer> _spielerList;
      
    
        public List<Kampfteilnehmer> spielerList
       {
           get { return _spielerList; }
           set
           { _spielerList = value;
               if (PropertyChanged != null)
                   PropertyChanged(this, new PropertyChangedEventArgs("spielerliste"));
                       }
       }
    
        public event PropertyChangedEventHandler? PropertyChanged;
    }
   
     
  
}
