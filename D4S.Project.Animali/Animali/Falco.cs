using D4S.Project.Animali.Interfacce;

namespace D4S.Project.Animali.Animali
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