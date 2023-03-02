
namespace RundenAnsicht;


public partial class Anfrage : Page
{
    public AnfrageViewModel viewModel { get; }
    public bool Typen { get; set; }
    public Anfrage(AnfrageViewModel anfrageViewModel)
    {
        Typen= true;
        viewModel = anfrageViewModel;
        InitializeComponent();
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {

        string teil= Teilnehmer.Text;
        int Initati = int.Parse(Initativ.Text);
        int lp =int.Parse(Lebenspunkte.Text);
        viewModel.Add(teil, Initati, lp,Typen);
        Initativ.Clear();
        Teilnehmer.Clear();
        Lebenspunkte.Clear();
       

    }
  
    private void NeuSpieler_Checked(object sender, RoutedEventArgs e)
    {
        if (Typen == false) Typen= true;
        
    }

    private void NeuGegner_Checked(object sender, RoutedEventArgs e)
    {
        if (Typen== true) Typen = false;

    }
}
