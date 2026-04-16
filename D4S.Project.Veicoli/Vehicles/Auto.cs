using System;
using D4S.Project.Veicoli.Interfaces;

namespace D4S.Project.Veicoli.Vehicles
{
    public class Auto : Veicolo, ITerrestre
    {
        #region Costruttore

        public Auto(string marca, string modello, int velocita)
            : base(marca, modello, velocita)
        {
        }

        #endregion

        #region Override metodi base

        public override void MostraInfo()
        {
            base.MostraInfo();
        }

        public override void Accensione()
        {
            Accesa = true;
            Console.WriteLine("Accensione auto in corso...");
            Velocita = 1;
            Console.WriteLine($"Velocità iniziale: {Velocita} Km/h");
            Console.WriteLine("");
        }

        public override void Partenza()
        {
            base.Partenza();
        }

        public override void Accellerazione()
        {
            base.Accellerazione();
        }

        public override void Frenata()
        {
            base.Frenata();
        }

        public override void Spegnimento()
        {
            base.Spegnimento();
        }

        #endregion

        #region Metodi specifici Auto

        public void InserisciMarcia()
        {
            if (Accesa)
            {
                Console.WriteLine("Marcia inserita.");
                Console.WriteLine($"Velocità: {Velocita} Km/h");
            }
            else
            {
                Console.WriteLine("Accendi prima il veicolo.");
            }
        }

        #endregion
    }
}