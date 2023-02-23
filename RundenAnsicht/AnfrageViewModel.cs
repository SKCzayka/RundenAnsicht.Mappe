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
        private List<Kampfteilnehmer> Kampfteilnehmers;

        public List <Kampfteilnehmer> kampfteilnehmers
        {
            get { return Kampfteilnehmers;}
            set
            {
                Kampfteilnehmers = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("kampfteilnehmers"));
            }
        }    
       
    public event PropertyChangedEventHandler? PropertyChanged;
        public void Add(string teil, int Initativ, bool Typ)
        {
            Kampfteilnehmers.Add(new Kampfteilnehmer() { Name = teil, Init = Initativ, Typ=true }); 
        }
    
        
    }
   
     
  
}
