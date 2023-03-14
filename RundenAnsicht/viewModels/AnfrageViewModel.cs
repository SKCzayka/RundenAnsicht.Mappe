

namespace RundenAnsicht;

public class AnfrageViewModel

{
    public Datenholder Datenholder { get; set; }

    public AnfrageViewModel(Datenholder datenholder)
    {
        Datenholder= datenholder;
    }

    public void Add(string teil, int Initativ, int lp, bool Typen )
    {
         Datenholder.Kampfteilnehmers.Add(new () { Name = teil, Init = Initativ, LP=lp, MaxLP=lp, Typ =Typen}); 
    }

    
}

 

