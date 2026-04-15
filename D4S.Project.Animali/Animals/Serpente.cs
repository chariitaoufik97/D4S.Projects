using D4S.Project.Animali.Interfaces;

namespace D4S.Project.Animali.Animals
{
    public class Serpente : Animale, IRettile
    {
        #region Costruttori

        public Serpente(string nome, string habitat) : base(nome, habitat) { }

        #endregion

        #region Metodi pubblici

        public void Strisciare()
        {
            Console.WriteLine("Mi muovo strisciando");
        }

        #endregion

        #region Override

        public override void Muoversi()
        {
            Strisciare();
        }

        #endregion
    }
}