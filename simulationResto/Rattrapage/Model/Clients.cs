using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapage.Model
{
    class Clients
    {
        private string nameClient;
        private int idClient;
        private List<string> order;
        private string[] haveChoice;
        public string[] HaveChoice { get => haveChoice; }
        private Table table;

        public Clients()
        {
            
        }

        public void choice(Card card)
        {
            Random rand = new Random();
            
            haveChoice = new string[3] {card.Entrees[rand.Next(card.Entrees.Count)], card.Plats[rand.Next(card.Plats.Count)], card.Deserts[rand.Next(card.Deserts.Count)]};
        } 
    }
}
