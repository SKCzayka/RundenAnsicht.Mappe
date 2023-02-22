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
        private List<Kampfteilnehmer>_Kampfteilnehmers;
      
        public List<Kampfteilnehmer> Kampfteilnehmers
       {
           get { return _Kampfteilnehmers  ; }
           set
           {
                _Kampfteilnehmers= value;
               if (PropertyChanged != null)
                   PropertyChanged(this, new PropertyChangedEventArgs("Kampfteilnehmers"));
                       }
       }
        public void Add(string teil, int Initativ, bool Typ)
        {
            _Kampfteilnehmers.Add(new Kampfteilnehmer() { Name = teil, Init = Initativ, Typ=true }); 
        }
    
        public event PropertyChangedEventHandler? PropertyChanged;
    }
   
     
  
}
