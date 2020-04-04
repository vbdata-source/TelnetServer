using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NetworkLibrary;
using NetworkLibrary.EventArgs;

namespace TelnetServer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //definiere einen Endpoint für den Listener 
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 8310);

            //initialisiere Netzwerk Listener
            var Listener = new AsyncSocketListener(ep);

            //gibt empfangenen Text auf der Konsole aus
            Listener.ClientConnectedHandler += GiveOutText;

            //Starte Listen
            await Listener.Listen();

        }

        static void GiveOutText(object sender, ClientConnectedEventArgs e)
        {
            Console.WriteLine(e.message);
        }
    }
}
