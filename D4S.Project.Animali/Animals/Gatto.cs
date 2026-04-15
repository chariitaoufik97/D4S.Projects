using D4S.Project.Animali.Interfaces;

namespace D4S.Project.Animali.Animals
{
    public class Gatto : Animale, IMammifero
    {
        #region Costruttori

        public Gatto(string nome, string habitat) : base(nome, habitat) { }

        #endregion

        #region Metodi pubblici

        public void Correre()
        {
            Console.WriteLine("Mi muovo correndo");
        }

        public void Scappare()
        {
            Console.WriteLine("Trovami se ci riesci :)");
        }

        #endregion

        #region Override

        public override void Muoversi()
        {
            Correre();
        }

        #endregion
    }
}