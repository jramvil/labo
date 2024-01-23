using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismos
{
    class Server : Computer
    {
        public Server(string name, string make, string osystem, bool switched, string dest, string ip) : base(name, make, osystem, switched)
        {
            this.Destination = dest;
            this.Ipaddress = ip;
        }

        // private member variables
        private string _destination;

        // public properties
        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public override void ShutDown()
        {
            Console.WriteLine("************* !!! **************** ");
            Console.Write("You want to shut dowm this server. Are you sure ? (YES/n): ");

            
			string confirm = Console.ReadLine();
			if (confirm == "YES") 
			{
    			this.SwitchedOn = false; 
    			switchedCounter--;
    			Console.WriteLine("The server {0} is shuting down !!!", this.Ipaddress);
			} 
			
        }

        public override void StartComputer()
        {
            this.SwitchedOn = true;
            switchedCounter++;
            Console.WriteLine("The server {0} is starting ...", this.Ipaddress);
        }


      




    } //end of the class Server
}
