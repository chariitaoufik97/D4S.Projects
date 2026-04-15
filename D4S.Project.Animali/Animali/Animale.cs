namespace D4S.Project.Animali.Animali
{
    public abstract class Animale
    {
        #region Proprietà

        public string Nome { get; set; }
        public string Habitat { get; set; }

        #endregion

        #region Costruttori

        public Animale(string nome, string habitat)
        {
            Nome = nome;
            Habitat = habitat;
        }

        #endregion

        #region Metodi pubblici

        public virtual void Saluta()
        {
            Console.WriteLine($"Ciao sono {Nome}, il mio Habitat è {Habitat}");
        }

        public abstract void Muoversi();

        #endregion
    }
}