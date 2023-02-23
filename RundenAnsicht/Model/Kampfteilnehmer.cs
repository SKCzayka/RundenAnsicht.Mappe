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

        public bool Typ { get; set; }


        public Kampfteilnehmer(string[] Daten)
        {
            Name= Daten[0];
            Init= int.Parse(Daten[1]);
            Typ= bool.Parse(Daten[2]);

        }
        public Kampfteilnehmer(string name, int init, bool typ)
        {
            Name=name;
            Init=init;
            Typ=typ;
        }
        public Kampfteilnehmer() { }
              
     }
}

