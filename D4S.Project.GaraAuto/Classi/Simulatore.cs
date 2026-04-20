namespace D4S.Project.GaraAuto.Classi
{
    public class Simulatore
    {
        private readonly int[] checkpoints = { 1000, 2000, 3000, 4000, 5000 };

        public void Qualifica(Auto auto)
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
            foreach (int distanzaCheckpoint in checkpoints)
            {
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

                // Stampo il checkpoint in giallo
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Pilota: {auto.Pilota} |Checkpoint {distanzaCheckpoint / 1000} km | Tempo totale: {tempoTotale:F2}s | Tempo parziale: {tempoParziale:F2}s");
                Console.ResetColor();
            }

            // Stampo il tempo finale in rosso
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nTempo finale: {tempoPrecedente:F2}s");
            Console.ResetColor();
        }
    }
}