using D4S.Project.GaraAuto.Classi;
 //object lockConsole = new object();
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
                new Auto("Marco", "Lamborghini", "Aventador SVJ", 350, 2.8),
                new Auto("Andrea", "McLaren", "720S", 350, 2.9),
                new Auto("Giovanni", "Porsche", "911 GT3 RS", 296, 3.2),
            };

            Simulatore simulatore = new Simulatore();

            //object lockConsole = new object();
            int[] arriviPerCheckpoint = new int[5];

            Console.WriteLine("=== GRIGLIA DI PARTENZA ===");

            foreach (Auto veicolo in veicoli)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(
                    $"{veicolo.Pilota} | {veicolo.Marca} {veicolo.Modello} | VelMax: {veicolo.VelocitaMax} km/h | 0-100: {veicolo.ZeroCento:F1}s");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n===> CHECKPOINT 1 <===");
            Console.ResetColor();

            List<Task> gare = new();

            foreach (Auto veicolo in veicoli)
            {
                gare.Add(simulatore.Qualifica(veicolo, veicoli.Count, arriviPerCheckpoint/*, lockConsole*/));
            }

            await Task.WhenAll(gare);

            Console.ReadKey();
        }

        #endregion
    }
}