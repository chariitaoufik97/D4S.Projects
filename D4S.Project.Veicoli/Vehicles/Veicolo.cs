using System;

namespace D4S.Project.Veicoli.Vehicles
{
    public abstract class Veicolo
    {
        #region Proprietà

        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Velocita { get; set; }
        public bool Accesa { get; set; }

        #endregion

        #region Costruttore

        protected Veicolo(string marca, string modello, int velocita)
        {
            Marca = marca;
            Modello = modello;
            Velocita = velocita;
            Accesa = false;
        }

        #endregion

        #region Metodi comuni

        public virtual void MostraInfo()
        {
            Console.WriteLine($"\n|Marca: {Marca}, \n|Modello: {Modello}, \n|Velocità: {Velocita} Km/h");
            Console.WriteLine("");
        }

        public abstract void Accensione();

        public virtual void Partenza()
        {
            if (Accesa)
            {
                Velocita += 5;
                Console.WriteLine($"Partenza in corso... Velocità: {Velocita} Km/h");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Accendi prima il veicolo.");
                Console.WriteLine("");
            }
        }

        public virtual void Accellerazione()
        {
            if (Accesa)
            {
                Console.WriteLine("Accelerazione in corso...");
                Velocita += 15;
                Console.WriteLine($"Velocità: {Velocita} Km/h");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Accendi prima il veicolo.");
                Console.WriteLine("");
            }
        }

        public virtual void Frenata()
        {
            if (Velocita > 0)
            {
                Console.WriteLine("Frenata in corso...");
                Velocita -= 15;

                if (Velocita < 0)
                {
                    Velocita = 0;
                }

                Console.WriteLine($"Velocità: {Velocita} Km/h");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Il veicolo è già fermo.");
                Console.WriteLine("");
            }
        }

        public virtual void Spegnimento()
        {
            if (Velocita == 0)
            {
                Accesa = false;
                Console.WriteLine("Spegnimento in corso...");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Rallenta fino a fermarti prima di spegnere il veicolo.");
                Console.WriteLine("");
            }
        }

        #endregion
    }
}