﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Rattrapage.Model;

namespace Rattrapage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Le resto est ouvert");
            
            //Room mainRoom = new Room();
            Room mainRoom = Room.Instance;
            WaitingLine waitingline = new WaitingLine();


            for(int i = 0; i < 10; i++){
                waitingline.AjouterClientsWaitline(new GroupClient());
                mainRoom.HeadWaiter.checkWaitingLine(waitingline);
            }

            foreach(Table table in mainRoom.Square1.Tables){
                Console.WriteLine(table.Occupied);
                if(table.Occupied == true){
                     Console.WriteLine("Avec un groupe de : " + table.Clients.NbrClients + " table id : " + table.IdTable);
                    
                }
            }

            foreach(Table table in mainRoom.Square2.Tables){
                Console.WriteLine(table.Occupied);
                if(table.Occupied == true){
                     Console.WriteLine("Avec un groupe de : " + table.Clients.NbrClients + " table id : " + table.IdTable);
                }
            }


            Console.ReadLine();
            
            /*IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8080);
            TcpClient client = default(TcpClient);

            try
            {
                server.Start();
                Console.WriteLine("Le restaurant est ouvert...");
                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }

            while (true)
            {
                client = server.AcceptTcpClient();

                byte[] receiveBuffer = new byte[100];
                NetworkStream stream = client.GetStream();

                stream.Read(receiveBuffer, 0, receiveBuffer.Length);
                string msg = Encoding.ASCII.GetString(receiveBuffer, 0, receiveBuffer.Length);

                Console.WriteLine(msg);
               
            }*/

        }
    }
}
