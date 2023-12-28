using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    public class Server : Computer
    {
        public Server(string bn, string ip, string os, string type) : base(bn, ip, os)
        {
            this.Type = type;
        }

        public Server() { }

        protected string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

       /* public override void StartComputer(List<Computer> network, string ip, string compName)
        {
            IPAddress = ip + "10";
        }
       */

    }
}
