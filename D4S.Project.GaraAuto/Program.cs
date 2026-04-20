using D4S.Project.GaraAuto.Classi;

namespace D4S.Project.GaraAuto
{
    public class Program
    {
        #region Main

        static void Main(string[] args)
        {
            List<Auto> veicoli = new()
            {
                new Auto("Pippo", "Audi", "RS6 Avant", 250, 3.6),
                new Auto("Pierino", "Audi", "RS6 Avant Performance", 280, 3.4),
                new Auto("Matteo", "BMW", "M4 Coupé", 250, 4.2),
                new Auto("Tofy", "BMW", "M4 Competition xDrive", 250, 3.5),
            };

            Simulatore simulatore = new Simulatore();

            foreach (Auto veicolo in veicoli)
            {
                veicolo.MostraInfo();
                simulatore.Qualifica(veicolo);
            }
        }

        #endregion
    }
}