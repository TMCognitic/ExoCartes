using System.Collections;

namespace ExoCartes
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte[] cartes = new Carte[52];

            int couleur = 0, valeur = 2;

            for (int i = 0; i < cartes.Length; i++)
            {
                if (valeur > 14)
                {
                    valeur = 2;
                    couleur++;
                }

                cartes[i].couleur = (Couleurs)couleur;
                cartes[i].valeur = (Valeurs)valeur;
                valeur++;
            }       

            foreach (Carte carte in cartes)
            {
                Console.WriteLine($"{carte.valeur} de {carte.couleur}");
            }
        }
    }
}