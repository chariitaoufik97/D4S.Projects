using D4S.Project.Animali.Interfacce;

namespace D4S.Project.Animali.Animali
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