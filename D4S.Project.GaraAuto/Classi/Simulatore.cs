namespace D4S.Project.GaraAuto.Classi
{
    public class Simulatore
    {
        private readonly int[] checkpoints = { 1000, 2000, 3000, 4000, 5000 };

        public async Task Qualifica(
            Auto auto,
            int numeroAutoTotali,
            int[] arriviPerCheckpoint)
            //object lockConsole)
        {
            // Calcolo l'accelerazione media partendo dallo 0-100
            // 100 km/h = 27.78 m/s
            double accelerazione = (100.0 / 3.6) / auto.ZeroCento;

            // Converto la velocità massima da km/h a m/s
            double velocitaMassimaMetriSecondo = auto.VelocitaMax / 3.6;

            // Calcolo in quanto tempo l'auto raggiunge la velocità massima
            double tempoPerVelocitaMassima = velocitaMassimaMetriSecondo / accelerazione;

            // Calcolo quanti metri percorre durante la fase di accelerazione
            double spazioPercorsoInAccelerazione = 0.5 * accelerazione * tempoPerVelocitaMassima * tempoPerVelocitaMassima;

            // Mi servirà per ricavare il tempo parziale tra un checkpoint e il successivo
            double tempoPrecedente = 0;

            // Scorro tutti i checkpoint: 1000, 2000, 3000, 4000, 5000 metri
            for (int i = 0; i < checkpoints.Length; i++)
            {
                int distanzaCheckpoint = checkpoints[i];

                // Tempo totale dalla partenza fino al checkpoint corrente
                double tempoTotale;

                // Se il checkpoint è ancora dentro il tratto di accelerazione,
                // uso la formula del moto uniformemente accelerato
                if (distanzaCheckpoint <= spazioPercorsoInAccelerazione)
                {
                    tempoTotale = Math.Sqrt((2 * distanzaCheckpoint) / accelerazione);
                }
                else
                {
                    // Se l'auto ha già raggiunto la velocità massima:
                    // tempo totale = tempo per accelerare
                    // + tempo per percorrere la distanza restante a velocità costante
                    tempoTotale = tempoPerVelocitaMassima +
                                  ((distanzaCheckpoint - spazioPercorsoInAccelerazione) / velocitaMassimaMetriSecondo);
                }

                // Tempo impiegato solo tra il checkpoint precedente e quello attuale
                double tempoParziale = tempoTotale - tempoPrecedente;

                // Salvo il tempo totale corrente per usarlo al giro successivo
                tempoPrecedente = tempoTotale;

                await Task.Delay((int)tempoParziale * 1000);

                //lock (lockConsole)
                //{
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(
                        $"{auto.Pilota} | {auto.Marca} {auto.Modello} | Checkpoint {distanzaCheckpoint / 1000} km | Tempo totale: {tempoTotale:F2}s | Tempo parziale: {tempoParziale:F2}s");
                    Console.ResetColor();

                    arriviPerCheckpoint[i]++;

                    if (arriviPerCheckpoint[i] == numeroAutoTotali && i < checkpoints.Length - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"\n===> CHECKPOINT {i + 2} <===");
                        Console.ResetColor();
                    }
                //}
            }
        }
    }
}