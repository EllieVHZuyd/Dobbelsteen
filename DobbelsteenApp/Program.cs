using DobbelsteenApp.Models;

namespace DobbelsteenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dobbelsteen dobbelsteen = new Dobbelsteen();
            dobbelsteen.Kleur = "Geel";
            dobbelsteen.AantalKanten = 4;
            dobbelsteen.AantalMogelijkheden = 4;
            dobbelsteen.Symbolen = "Getallen";
            dobbelsteen.Oogkleuren = "Zwart";
            dobbelsteen.Vorm = "Pyramide";

            Console.WriteLine($"Kleur: {dobbelsteen.Kleur}\nKleur ogen: {dobbelsteen.Oogkleuren}\nAantal kanten: {dobbelsteen.AantalKanten}\nAantal mogelijkheden: {dobbelsteen.AantalMogelijkheden}\nSoort symbolen: {dobbelsteen.Symbolen}\nVorm: {dobbelsteen.Vorm}");
            Console.ReadKey();
        }
    }
}
