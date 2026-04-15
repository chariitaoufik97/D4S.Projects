using D4S.Project.Animali.Interfaces;

namespace D4S.Project.Animali.Animals
{
    public class Falco : Animale, IUccello
    {
        #region Costruttori

        public Falco(string nome, string habitat) : base(nome, habitat) { }

        #endregion

        #region Metodi pubblici

        public void Volare()
        {
            Console.WriteLine("Mi muovo volando");
        }

        #endregion

        #region Override

        public override void Muoversi()
        {
            Volare();
        }

        #endregion
    }
}