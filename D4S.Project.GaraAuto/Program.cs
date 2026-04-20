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
                new Auto("Pippo", "Audi", "RS6 Avant", 250, 3.6),
                new Auto("Pierino", "Audi", "RS6 Avant Performance", 280, 3.4),
                new Auto("Matteo", "BMW", "M4 Coupé", 250, 4.2),
                new Auto("Tofy", "BMW", "M4 Competition xDrive", 250, 3.5),
            };

            Simulatore simulatore = new Simulatore();

            object lockConsole = new object();
            int[] arriviPerCheckpoint = new int[5];

            Console.WriteLine("=== GRIGLIA DI PARTENZA ===");

            foreach (Auto veicolo in veicoli)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                    $"{veicolo.Pilota} | {veicolo.Marca} {veicolo.Modello} | VelMax: {veicolo.VelocitaMax} km/h | 0-100: {veicolo.ZeroCento:F1}s");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n===> CHECKPOINT 1 <===");
            Console.ResetColor();

            List<Task> gare = new();

            foreach (Auto veicolo in veicoli)
            {
                gare.Add(simulatore.Qualifica(veicolo, veicoli.Count, arriviPerCheckpoint, lockConsole));
            }

            await Task.WhenAll(gare);

            Console.ReadKey();
        }

        #endregion
    }
}