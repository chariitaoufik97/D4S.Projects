using System.Threading.Tasks;
using D4S.Project.GaraAuto.Classi;

namespace D4S.Project.GaraAuto
{
    public class Program
    {
        #region Main

        static async Task Main(string[] args)
        {
            List<Auto> veicoli = new()
            {
                new Auto("Luca", "Ferrari", "SF90 Stradale", 340, 2.5),
                new Auto("Matteo", "Lamborghini", "Aventador SVJ", 350, 2.8),
                new Auto("Tofy", "McLaren", "720S", 341, 2.9),
                new Auto("Giovanni", "Porsche", "911 GT3 RS", 296, 3.2),

            };


            Simulatore simulatore = new Simulatore();

            foreach (Auto veicolo in veicoli)
            {


                //veicolo.MostraInfo()
                simulatore.Qualifica(veicolo);
                Console.WriteLine(new string('-', 70));
            }
            Console.ReadKey();
        }

        #endregion
    }
}