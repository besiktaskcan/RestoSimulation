using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rattrapage.ModelCuisine
{
    public class Cuisinier
    {
        private bool estActif;

        public bool EstActif { get => estActif; set => estActif = value; }

        public void Cuisiner(Recette recette)
        {
            Creator creator = new Creator();
            EstActif = true;

            Thread.Sleep(recette.tempsRealisation);

            foreach (Ingredient ingredient in recette.ingredientsRecette)
            {
                creator.SearchIngredientByName(ingredient.nomIngredient).quantiteIngredient = creator.SearchIngredientByName(ingredient.nomIngredient).quantiteIngredient - 1;
            }

            EstActif = false;
            Creator.platsEnAttente.Add(new Plat(recette.nomRecette));
        }
    }
}
