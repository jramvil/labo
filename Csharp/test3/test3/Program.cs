using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


using test3;


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
    }
}