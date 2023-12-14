//The concepts of OOP in C#
using System;
using System.Net;
using System.Threading.Channels;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
namespace OOP_in_Csharp
{
    public class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        private bool _switchedOn;
        private static int _counter = 0;

        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;
            _switchedOn = false;
            _counter++;

        }

        public Computer(string bn, string os)
        {
            _BIOSname = bn;
            _OS = os;
            _switchedOn = false;
            _counter++;
        }

        public Computer()
        {
            _switchedOn = false;
            _counter++;
        }

        //--------------------------------

        public static int getCounter()
        {
            return _counter;
        }

        //--------------------------------
        //Properties
        public string BiosName
        {
            get { return _BIOSname; }
            set { _BIOSname = value; }
        }
        public string IPAddress
        {
            get { return _ipadress; }
            set { _ipadress = value; }
        }
        public bool ON
        {
            get { return _switchedOn; }
            set { _switchedOn = value; }
        }

        //---------------------------------------
        //Métodos de la clase

        static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }


        public static void StartComputer(List<Computer> network, string ip, string compName)
        {
            for (int i = 0; i < network.Count; i++)
            {
                if (network[i]._BIOSname == compName)
                {
                    network[i].ON = true;
                    network[i].IPAddress = ip;
                }
            }
        }

        public static void ShutDownComp(List<Computer> network, string compName)
        {
            for (int i = 0; i < network.Count; i++)
            {
                if (network[i]._BIOSname == compName)
                {
                    network[i].ON = false;
                    network[i].IPAddress = "";
                }
            }
        }

        public static void ShowComp(List<Computer> network)
        {
            for (int i = 0; i < network.Count; i++)
            {
                Console.WriteLine("{0} {1}", network[i].BiosName, network[i].IPAddress);
            }
        }

        public static int getCompsOn(List<Computer> network)
        {
            int countON = 0;
            foreach (Computer c in network)
            {
                if (c.ON) countON++;
            }
            return countON;
        }

        public static List<string> getAdresses(List<string> ips, int N)
        {
            int count = 0;
            string piece = "";

            while (count < N)
            {
                piece = "10.0." + getNum() + "." + getNum();

                if (ips.Contains(piece) == false)
                {
                    ips.Add(piece);
                    count++;
                }
            }
            return ips;
        }

        public static void Ping(List<Computer> network, string ip)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            string pingIP = ip;
            StreamWriter loginfile = File.AppendText("logfile.txt");
            string total_time = "";


            for (int i = 0; i < network.Count; i++)
            {
                Console.WriteLine("Time=" + getNum() + "ms");
                if (pingIP == network[i].IPAddress)
                {
                    loginfile.WriteLine("The ping was done succesfully");
                    Console.WriteLine("The ping was done succesfully");
                    loginfile.Close();
                    return;
                }
            }
            loginfile.WriteLine("It was not possible to ping this IP");

            Console.WriteLine("It was not possible to ping this IP");
           // loginfile.Close();
            time.Stop();
            total_time = time.Elapsed.TotalMilliseconds.ToString();
            loginfile.WriteLine(total_time);
            loginfile.Close();
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            //Creamos una lista donde se almacenarán los ordenadores
            List<Computer> net = new List<Computer>();
            const int allComps = 10;
            int onComps = 5;


            //Creamos una lista de direcciones IP
            Console.WriteLine("\nAvailable IP addresses:");
            List<string> ipaddresses = new List<string>();
            ipaddresses = Computer.getAdresses(ipaddresses, allComps);

            //Declaramos una pila llamada ipsa donde se almacenarán las direcciones ip
            Stack ipsa = new Stack();
            foreach (string e in ipaddresses)
            {
                ipsa.Push(e);
                //   Console.WriteLine(e);        
            }

            //Generamos instancias de la clase Computer
            Console.WriteLine("\nGenerating Computer instances");
            for (int i = 0; i < onComps; i++)
            {
                Computer comp = new Computer("comp" + i.ToString(), "Win10");
                net.Add(comp);
                Computer.StartComputer(net, (string)ipsa.Pop(), comp.BiosName);
            }

            //Mostramos los ordenadores que se encuantran en la red
            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");

            Console.WriteLine("\nTurning off computer");
            Computer.ShutDownComp(net, "comp1");
            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network and " + Computer.getCompsOn(net) + " on");

            Console.WriteLine("\nTurning on computer");
            Computer.StartComputer(net, (string)ipsa.Pop(), "comp1");
            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network and " + Computer.getCompsOn(net) + " on");





            //Hacemos PING a una direccion IP
            Console.WriteLine("Write the IP you want to do the ping: ");
            string pingIP = Console.ReadLine();

            
            Computer.Ping(net, pingIP);


            /*
            StreamWriter loginfile = File.AppendText("logfile.txt");
            loginfile.WriteLine()

             */







            /*
            foreach(string e in ipaddresses)
            {
                Console.WriteLine(e);
            }

            */

            /*
            for (int i = 0; i < numComps; i++)
            {
            Computer comp = new Computer ("comp" + i.ToString(), "Win10");
            net.Add (comp);
            comp.StartComputer();
            }
            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");

            Computer.ShutDownComp(net, "comp3");

            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");

            /*

            
            for (int i = 0; i < net.Count; i++)
            {
                Console.WriteLine("{0} {1}", net[i].BiosName, net[i].IPAddress);
            }

            //-----------------------------------------------------------------------
            net[1].BiosName = "server 1";

            Console.WriteLine(net[1].BiosName);

            Computer special = new Computer();

                        //---------------------------------------------------------------------------------------
                        special.BiosName = "Raspberry.py";
                        special.IPAddress = "12.12.12.44";

                        Console.WriteLine(special.BiosName + " " + special.IPAddress);

                        Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");

                        //------------------------------------------------------------------------------------------
                        */




        }
    }
}