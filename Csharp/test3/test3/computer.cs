using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
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
}
