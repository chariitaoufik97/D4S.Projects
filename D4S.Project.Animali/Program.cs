using D4S.Project.Animali.Animali;

namespace D4S.Project.Animali

{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animale> animali = new()
            {
                new Falco("Falco Pellegrino", "Montagna"),
                new Gatto("Gatto Persiano", "Casa"),
                new Serpente("Serpente a sonagli", "Deserto"),
                new Squalo("Squalo Bianco", "Oceano")
            };

            foreach (Animale animale in animali)
            {
                animale.Saluta();
                animale.Muoversi();

                if (animale is Gatto gatto)
                {
                    gatto.Scappare();
                }

                Console.WriteLine("");
            }

            //Falco falco = new Falco("Falco Pellegrino", "Montagna");
            //Gatto gatto = new Gatto("Gatto Persiano", "Casa");
            //Serpente serpente = new Serpente("Serpente a sonagli", "Deserto");
            //Squalo squalo = new Squalo("Squalo Bianco", "Oceano");

            //falco.Saluta();
            //falco.Volare();
            //Console.WriteLine("");

            //gatto.Saluta();
            //gatto.Correre();
            //gatto.Scappare();
            //Console.WriteLine("");

            //serpente.Saluta();
            //serpente.Strisciare();
            //Console.WriteLine("");

            //squalo.Saluta();
            //squalo.Nuotare();
            //Console.WriteLine("");


        }
    }
}

