using D4S.Project.Animali.Interfacce;

namespace D4S.Project.Animali.Animali
{
    public class Squalo : Animale, IPesce
    {
        #region Costruttori

        public Squalo(string nome, string habitat) : base(nome, habitat) { }

        #endregion

        #region Metodi pubblici

        public void Nuotare()
        {
            Console.WriteLine("Mi muovo nuotando");
        }

        #endregion

        #region Override

        public override void Muoversi()
        {
            Nuotare();
        }

        #endregion
    }
}