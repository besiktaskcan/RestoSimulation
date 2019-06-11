using System.Collections.Generic;
using System.Linq;

namespace Rattrapage.ModelCuisine
{
    class Creator
    {
        public static List<Recette> recettes = new List<Recette>();
        public static List<Ingredient> ingredients = new List<Ingredient>();

        public static List<Plat> platsEnAttente = new List<Plat>();
        
        public Creator()
        {

        }

        public void Instanciation()
        {
            Ingredient pain = new Ingredient("pain", 99);

            Ingredient pates = new Ingredient("pates", 99);
            Ingredient riz = new Ingredient("riz", 99);
            Ingredient poulet = new Ingredient("poulet", 99);
            Ingredient boeuf = new Ingredient("boeuf", 99);
            Ingredient saucetomate = new Ingredient("saucetomate", 99);
            Ingredient creme = new Ingredient("creme", 99);
            Ingredient chocolat = new Ingredient("chocolat", 99);
            Ingredient vanille = new Ingredient("vanille", 99);
            Ingredient oeuf = new Ingredient("oeuf", 99);
            Ingredient farine = new Ingredient("farine", 99);
            Ingredient tomate = new Ingredient("tomate", 99);
            Ingredient mozzarella = new Ingredient("mozzarella", 99);

            Recette bolognaise = new Recette("spaghetti bolognaise", new List<Ingredient> { pates, boeuf, saucetomate }, 10, "PLAT");
            Recette rizpoulet = new Recette("riz au poulet", new List<Ingredient> { riz, poulet, creme }, 10, "PLAT");
            Recette gateauchocolat = new Recette("gateau au chocolat", new List<Ingredient> { chocolat, oeuf, farine }, 10, "DESSERT");
            Recette gateauvanille = new Recette("gateau à la vanille", new List<Ingredient> { vanille, oeuf, farine }, 10, "DESSERT");
            Recette oeufsauplat = new Recette("oeufs au plat", new List<Ingredient> { oeuf }, 10, "ENTREE");
            Recette tomatemozza = new Recette("tomates mozzarella", new List<Ingredient> { tomate, mozzarella }, 5, "ENTREE");

            Recette erreur = new Recette("erreur", new List<Ingredient> {}, 0, "ENTREE");

            recettes.Add(bolognaise);
            recettes.Add(rizpoulet);
            recettes.Add(gateauchocolat);
            recettes.Add(gateauvanille);
            recettes.Add(oeufsauplat);
            recettes.Add(tomatemozza);

            recettes.Add(erreur);

            ingredients.Add(pain);

            ingredients.Add(pates);
            ingredients.Add(riz);
            ingredients.Add(poulet);
            ingredients.Add(boeuf);
            ingredients.Add(saucetomate);
            ingredients.Add(creme);
            ingredients.Add(chocolat);
            ingredients.Add(vanille);
            ingredients.Add(oeuf);
            ingredients.Add(farine);
            ingredients.Add(tomate);
            ingredients.Add(mozzarella);
        }

        public Recette SearchRecetteByName(string name)
        {
            switch (name)
            {
                case "spaghetti bolognaise":
                    var bolognaise = recettes.First(item => item.nomRecette == "spaghetti bolognaise");
                    return bolognaise;

                case "riz au poulet":
                    var rizpoulet = recettes.First(item => item.nomRecette == "riz au poulet");
                    return rizpoulet;

                case "gateau au chocolat":
                    var gateauchocolat = recettes.First(item => item.nomRecette == "gateau au chocolat");
                    return gateauchocolat;

                case "gateau à la vanille":
                    var gateauvanille = recettes.First(item => item.nomRecette == "gateau à la vanille");
                    return gateauvanille;

                case "oeufs au plat":
                    var oeufsauplat = recettes.First(item => item.nomRecette == "oeufs au plat");
                    return oeufsauplat;

                case "tomates mozzarella":
                    var tomatemozza = recettes.First(item => item.nomRecette == "tomates mozzarella");
                    return tomatemozza;

                default:
                    var erreur = recettes.First(item => item.nomRecette == "erreur");
                    return erreur;
            }
        }

        public Ingredient SearchIngredientByName(string name)
        {
            switch (name)
            {
                case "pain":
                    var pain = ingredients.First(item => item.nomIngredient == "pain");
                    return pain;



                case "pates":
                    var pates = ingredients.First(item => item.nomIngredient == "pates");
                    return pates;

                case "riz":
                    var riz = ingredients.First(item => item.nomIngredient == "riz");
                    return riz;

                case "poulet":
                    var poulet = ingredients.First(item => item.nomIngredient == "poulet");
                    return poulet;

                case "boeuf":
                    var boeuf = ingredients.First(item => item.nomIngredient == "boeuf");
                    return boeuf;

                case "saucetomate":
                    var saucetomate = ingredients.First(item => item.nomIngredient == "saucetomate");
                    return saucetomate;

                case "creme":
                    var creme = ingredients.First(item => item.nomIngredient == "creme");
                    return creme;

                case "chocolat":
                    var chocolat = ingredients.First(item => item.nomIngredient == "chocolat");
                    return chocolat;

                case "vanille":
                    var vanille = ingredients.First(item => item.nomIngredient == "vanille");
                    return vanille;

                case "oeuf":
                    var oeuf = ingredients.First(item => item.nomIngredient == "oeuf");
                    return oeuf;

                case "farine":
                    var farine = ingredients.First(item => item.nomIngredient == "farine");
                    return farine;

                case "tomate":
                    var tomate = ingredients.First(item => item.nomIngredient == "tomate");
                    return tomate;

                case "mozzarella":
                    var mozzarella = ingredients.First(item => item.nomIngredient == "mozzarella");
                    return mozzarella;

                default:
                    return new Ingredient("erreur", 1);
            }
        }
    }
}