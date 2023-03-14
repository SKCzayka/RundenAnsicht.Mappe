using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RundenAnsicht.Model
{
    public class Kampfteilnehmer
    {
        public string Name { get; set; }
        public int Init { get; set; }
        public int LP { get; set; }
        public int MaxLP { get ; set; }
        public bool Typ { get; set; }

        


        public Kampfteilnehmer(string[] Daten)
        {
            Name= Daten[0];
            Init= int.Parse(Daten[1]);
            LP = int.Parse(Daten[2]);
            MaxLP = int.Parse(Daten[3]);
            Typ= bool.Parse(Daten[4]);

        }
        public Kampfteilnehmer(string name, int init,int lp, int maxlp, bool typ )
        {
            Name=name;
            Init=init;
            LP=lp;
            Typ=typ;
        }
        public Kampfteilnehmer() { }
          
       
     }
}

