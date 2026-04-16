using D4S.Project.Veicoli.Vehicles;

namespace D4S.Project.Veicoli
{
    public class Program
    {
        #region Main

        static void Main(string[] args)
        {
            List<Veicolo> veicoli = new()
            {
                new Auto("BMW", "M4", 0)
            };

            foreach (Veicolo veicolo in veicoli)
            {
                veicolo.MostraInfo();
                veicolo.Accensione();

                if (veicolo is Auto auto)
                {
                    auto.InserisciMarcia();
                }
                veicolo.Partenza();
                veicolo.Accellerazione();
                veicolo.Frenata();
                veicolo.Spegnimento();
            }
        }

        #endregion
    }
}