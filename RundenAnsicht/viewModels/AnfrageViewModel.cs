using RundenAnsicht.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RundenAnsicht
{
    public class AnfrageViewModel

    {
        public Datenholder Datenholder { get; set; }

        public AnfrageViewModel(Datenholder datenholder)
        {
            Datenholder= datenholder;
        }
    
        public void Add(string teil, int Initativ, bool Typen)
        {
             Datenholder.Kampfteilnehmers.Add(new () { Name = teil, Init = Initativ, Typ =Typen}); 
        }
    
        
    }
   
     
  
}
