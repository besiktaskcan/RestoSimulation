using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rattrapage.ModelCuisine
{
    public class Cuisine
    {
        private static Creator Creator;
        private static Cuisinier Cuisinier;

        private static readonly List<Recette> recette = new List<Recette>();

        private static readonly List<string> entrees = new List<string> { "oeufs au plat", "tomates mozzarella" };
        private static readonly List<string> plats = new List<string> { "spaghetti bolognaise", "riz au poulet" };
        private static readonly List<string> deserts = new List<string> { "gateau au chocolat", "gateau à la vanille" };

        private static readonly List<string> typeavencement = new List<string> { "ENTREE", "PLAT", "DESSERT", "terminé" };

        public Cuisine(List<string> commande)
        {
            Cuisinier = new Cuisinier();

            Creator = new Creator();
            Creator.Instanciation();

            int platencours = 0;


            foreach (string nomrecette in commande)
            {
                recette.Add(Creator.SearchRecetteByName(nomrecette));
            }

            while (platencours != 3)
            {
                foreach (Recette recipe in recette.Where(type => type.typePlat== typeavencement[platencours]))
                {
                    Cuisinier.Cuisiner(recipe);

                    if (platencours != 0)
                    {
                        Console.WriteLine("Le " + recipe.typePlat + ": " + recipe.nomRecette + " est prêt.");
                    }
                    else
                    {
                        Console.WriteLine("L' " + recipe.typePlat + ": " + recipe.nomRecette + " est prêt.");
                    }

                }

                if (platencours != 0)
                {
                    Console.WriteLine("Tous les " + typeavencement[platencours] + " de la table sont prêts.");
                }
                else
                {
                    Console.WriteLine("Toutes les " + typeavencement[platencours] + " de la table sont prêtes.");
                }
                Console.WriteLine("Les assiettes peuvent être ammenées à la table pour dégustation.");

                platencours++;
                Thread.Sleep(10000);

            }

            Console.WriteLine("Les clients de la table ont terminé. Ils se dirigent vers la réception pour aller payer l'addition.");
            Thread.Sleep(5000);
        }
    }
}
