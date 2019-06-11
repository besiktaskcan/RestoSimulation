using System.Collections.Generic;

namespace Rattrapage.ModelCuisine
{
    public class Recette
    {
        public string nomRecette;
        public List<Ingredient> ingredientsRecette;
        public int tempsRealisation;
        public string typePlat;

        public Recette(string nom, List<Ingredient> ingredients, int temps, string type)
        {
            nomRecette = nom;
            ingredientsRecette = ingredients;
            tempsRealisation = temps * 1000;
            typePlat = type;
        }
    }
}