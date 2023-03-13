


namespace RundenAnsicht;

public class AnsichtViewModel : INotifyPropertyChanged
{
    private Datenholder _Datenholdern;
    public ObservableCollection<Kampfteilnehmer> Round { get; set; }
    public ObservableCollection<Kampfteilnehmer> Next_Round { get; set; }
    private ObservableCollection<Kampfteilnehmer> _Halter;
    private Page _page;


    public AnsichtViewModel(Datenholder datenholder)
    {
        Datenholder= datenholder;

        Next_Round = new ObservableCollection<Kampfteilnehmer>();
        Round = new ObservableCollection<Kampfteilnehmer>();
        Halter= new ObservableCollection<Kampfteilnehmer>();

        _initativeChange= App.serviceProvider.GetService<InitativeChange>();
        _lpChange= App.serviceProvider.GetService<LPChange>();

        Page = new Page();


    }

    // Seiten Ändern

    private InitativeChange _initativeChange;
    private LPChange _lpChange;


    public void IniShow()
    {
        if (Page != _initativeChange)
        {
            Page = _initativeChange;
        }
    }

    public void LPshow()
    {
        if (Page != _lpChange)
        {
            Page = _lpChange;
        }
    }


    //Sortieren
    public void SortDatenholder()
    {
        Halter =  new ObservableCollection<Kampfteilnehmer>(Datenholder.Kampfteilnehmers.OrderByDescending(x => x.Init));// Erstellt eine neue Sequence
        foreach (var item in Halter)
        {
            Round.Add(item);
        }
        Halter.Clear();
    }
    public void Sortall()
    {
        foreach (var item in Datenholder.Kampfteilnehmers)
        {
            foreach (var itemRound in Round)
            {
                if (item.Name == itemRound.Name && item.Init != itemRound.Init)
                {
                    Round.Remove(itemRound);
                    Round.Add(item);


                    Halter =  new ObservableCollection<Kampfteilnehmer>(Round.OrderByDescending(x => x.Init));// Erstellt eine neue Sequence
                    Round.Clear();
                    foreach (var items in Halter)
                    {
                        Round.Add(items);
                    }
                    return;
                }
            }
            foreach (var itemRound_Next in Next_Round)
            {
                if (item.Name == itemRound_Next.Name && itemRound_Next != item)
                {
                    Next_Round.Remove(itemRound_Next);
                    Next_Round.Add(item);
                    Halter = new ObservableCollection<Kampfteilnehmer>(Next_Round.OrderByDescending(x => x.Init));
                    Next_Round.Clear();
                    foreach (var items in Halter)
                    {
                        Next_Round.Add(items);
                        return;
                    }

                }
            }
        }
    }




    //Button funktionen

    public void Next_One()
    {

        if (Round.Count > 0)
        {
            Next_Round.Add(Round[0]);
            Round.RemoveAt(0);
        }
        else
        {
            MessageBox.Show("Kein Teilnehmer vorhanden, Bitte Starten Sie eine Neue Runde");
        }

    }

    public void Check()
    {
        Sortall();
        Page =new Page();
    }

    public void Round_End()
    {
        foreach (var Item in Next_Round)
        {
            Round.Add(Item);
        }

        Next_Round.Clear();

    }


    //Notifi kram

    public event PropertyChangedEventHandler? PropertyChanged;

    public Datenholder Datenholder
    {
        get { return _Datenholdern; }
        set
        {
            _Datenholdern = value;
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Datenholder"));
        }
    }
    public ObservableCollection<Kampfteilnehmer> Halter
    {
        get { return _Halter; }
        set
        {
            _Halter = value;
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Round"));
        }
    }

    public Page Page
    {
        get { return _page; }
        set
        {
            _page = value;
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Page"));
        }
    }
}


