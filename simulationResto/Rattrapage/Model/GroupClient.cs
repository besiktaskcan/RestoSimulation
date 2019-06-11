using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Rattrapage.ModelCuisine;

namespace Rattrapage.Model
{
    class GroupClient
    {
        private List<Clients> customers;
        private int nbrClients;

        private string stateGroup;
        private Table tableGroup;

        private Cuisine cuisine;
        private List<string> commande = new List<string>();

        private Card card;
        public Card Card { get => card; set => card = value; }

        private Thread groupClientsThread;

        public GroupClient()
        {
            customers = new List<Clients>();
            Random rand = new Random();
            nbrClients = rand.Next(2, 8);

            for(int i = 0; i < nbrClients; i++){
                customers.Add(new Clients());
            }
        }

        public void GroupClientThread()
        {

        }

        public void GroupClientChoice(Card card)
        {
            this.card = card;
            foreach(Clients clients in this.customers)
            {
                clients.choice(this.card);
            }
        }

        public void TakeGroupClientChoice()
        {
            foreach (Clients clients2 in this.customers)
            {
                Console.WriteLine("Clients : entrée - " + clients2.HaveChoice[0] + ", plat - " + clients2.HaveChoice[1] + ", dessert - " + clients2.HaveChoice[2]);
                commande.Add(clients2.HaveChoice[0]);
                commande.Add(clients2.HaveChoice[1]);
                commande.Add(clients2.HaveChoice[2]);

            }
            Console.WriteLine("Chef de rang : La commande de la table est envoyé en cuisine.");
            Cuisine cuisine = new Cuisine(commande);
        }

        public void AddClients(Clients clients)
        {
            this.customers.Add(clients);
        }

        public List<Clients> clients { get => customers; }
        public Table GroupTable { get => tableGroup; set => tableGroup = value; }
        public int NbrClients { get => nbrClients; }
    }
}
