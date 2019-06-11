using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Rattrapage.Model
{
    class HeadWaiter : Employes
    {
        private List<Table> tableLibre1;
        private static Thread headWaiterThread;

        private GroupClient groupClient;

        public HeadWaiter(Room room) : base(room)
        {
            Console.WriteLine("Le maître d'hotel est présent");
            headWaiterThread = new Thread(HeadWaiterThread);
            headWaiterThread.Start();
        }

        public static void HeadWaiterThread()
        {

        }

        public bool PlacerClients(GroupClient groupclients)
        {
            bool canISeat = false;
            Console.WriteLine("HeadWaiter : Combien êtes-vous?");
            Thread.Sleep(500);
            Console.WriteLine("Groupe de clients : Nous sommes " + groupclients.NbrClients);
            Thread.Sleep(500);
            Console.WriteLine("HeadWaiter : Un instant je regarde si il y des tables de libres");
            Thread.Sleep(500);

            foreach(Table table in this.room.Square1.Tables){
                if(!table.Occupied == true && groupclients.NbrClients <= table.NumberPlace){
                    Console.WriteLine("HeadWaiter : Il y a une table dans le carré 1, veuillez suivre le Chef de rang");
                    Thread.Sleep(500);
                    this.room.RankChief.PlacerGroupe(groupclients, table.IdTable);
                    table.Occupied = true;
                    this.room.RoomClerk.CallRoomClerk(table);
                    canISeat = true;
                    break;
                }
            }

            if(canISeat == false){
                 foreach(Table table in this.room.Square2.Tables){
                    if(!table.Occupied == true && groupclients.NbrClients <= table.NumberPlace)
                    {
                        Console.WriteLine("HeadWaiter : Il y a une table dans le carré 2, veuillez suivre le Chef de rang");
                        Thread.Sleep(500);
                        this.room.RankChief2.PlacerGroupe(groupclients, table.IdTable);
                        table.Occupied = true;
                        this.room.RoomClerk.CallRoomClerk(table);
                        canISeat = true;
                        break;
                    }
                 }
            }
            

            if(canISeat == false){
                Console.WriteLine("HeadWaiter : Occupe veuillez attendre");
            }

            return canISeat;

        }

        private static bool FindTablesLibre(Table table)
        {
            return table.Occupied == false;
        }

        public void checkWaitingLine(WaitingLine waitingLine)
        {
            List<GroupClient> listGroupClient = waitingLine.Clients; 
            if(listGroupClient.Count > 0){
                
                bool canISeat = this.PlacerClients(listGroupClient.First());
                if(canISeat == true){
                    listGroupClient.Remove(listGroupClient.First());
                }

            }

        }

        





    }
}
