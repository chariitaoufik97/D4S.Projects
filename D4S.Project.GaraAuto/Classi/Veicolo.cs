namespace D4S.Project.GaraAuto.Classi
{
    public abstract class Veicolo
    {
        #region Proprietà
        public string Pilota { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
        public double VelocitaMax { get; set; }
        public double ZeroCento { get; set; }

        #endregion

        #region Costruttore

        public Veicolo(string pilota, string marca, string modello, double velocitaMax, double zeroCento)
        {
            Marca = marca;
            Modello = modello;
            VelocitaMax = velocitaMax;
            ZeroCento = zeroCento;
            Pilota = pilota;
        }

        #endregion

        #region Metodi comuni

        public virtual void MostraInfo()
        {
            Console.WriteLine($"\n|Pilota: {Pilota}, \n|Marca: {Marca}, \n|Modello: {Modello}, \n|Velocità massima: {VelocitaMax} km/h, \n|Accelerazione 0-100: {ZeroCento}s");
            Console.WriteLine("");
        }
        #endregion
    }
}
