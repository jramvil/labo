//Project Computer v.10
////Inheritance

using System;
using System.Collections;
using System.Collections.Generic;

namespace Computer_class
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Computer> network = new List<Computer>();

            //Creating the objects 
            Server zero = new Server("zero", "Dell", "Linux", false, "DHCP", "10.0.0.1");
            Server omega = new Server("omega", "IBM", "Linux", false, "WEB Server", "10.0.0.2");
            Server mysql = new Server("mysql", "IBM", "Linux", false, "MySql", "10.0.0.5");
            Computer alfa = new Computer("alfa", "Dell", "Windows", false);
            Computer beta = new Computer("beta", "Lenovo", "Linux", false);
            Computer gamma = new Computer("gamma", "HP", "Windows", false);
            Computer delta = new Computer("delta", "Dell", "Windows", false);

            //Adding objects Computer to the list network
            network.Add(zero);
            network.Add(omega);
            network.Add(mysql);
            network.Add(alfa);
            network.Add(beta);
            network.Add(gamma);
            network.Add(delta);

            int compsInNetwork = Computer.CountComps();
            Console.WriteLine("We have {0} computers in our network.\n", compsInNetwork);

            //"Swithing on the computers"
            for (int i = 0; i < network.Count; i++)
            {
                network[i].StartDevice();
            }

            Console.WriteLine("We have {0} computers in our network that is switched ON\n", Computer.CountSwitched());
            Computer.ShowComputers(network);
            Console.WriteLine("\n--------------------------------------------------------------------");
            //omega.ShutDown();
            beta.ShutDown();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("\nWe have {0} computers in our network that is switched ON\n", Computer.CountSwitched());
            Computer.ShowComputers(network);

            //Ping from alfa to 10.0.0.14
            Computer.PingToComputer(network, alfa, "10.0.0.14");



            //shutting down server
            network[1].ShutDown();
            Console.WriteLine("\n--------------------------------------------------------------------");
            Computer.ShowComputers(network);


            network[1].StartDevice();
            Console.WriteLine("\n--------------------------------------------------------------------");
            Computer.ShowComputers(network);



        }
    }
}








