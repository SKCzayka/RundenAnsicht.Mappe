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
       public List<Kampfteilnehmer> Kampfteilnehmers { get; set; }
        public AnfrageViewModel()
        {
           
        }


       
            
        
       
    
        public void Add(string teil, int Initativ, bool Typ)
        {
                
            Kampfteilnehmers.Add( new Kampfteilnehmer() { Name = teil, Init = Initativ, Typ=true }); 
        }
    
        
    }
   
     
  
}
