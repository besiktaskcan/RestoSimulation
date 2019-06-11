using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapage.Model
{
    class Card
    {
        private static readonly List<string> entrees = new List<string> { "oeufs au plat", "tomates mozzarella" };
        private static readonly List<string> plats = new List<string> { "spaghetti bolognaise", "riz au poulet" };
        private static readonly List<string> desserts = new List<string> { "gateau au chocolat", "gateau à la vanille" };

        public  List<string> Entrees { get => entrees; }
        public  List<string> Plats { get => plats;  }
        public  List<string> Deserts { get => desserts; }


    }
}
