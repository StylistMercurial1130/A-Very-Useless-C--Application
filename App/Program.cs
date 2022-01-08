using System;
using System.Net.NetworkInformation;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(args[0]);
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(args[0]);

            if(reply.Status == IPStatus.Success){
                Console.WriteLine ("Address: {0}", reply.Address.ToString ());
                Console.WriteLine ("RoundTrip time: {0}", reply.RoundtripTime);
                Console.WriteLine ("Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine ("Don't fragment: {0}", reply.Options.DontFragment);
                Console.WriteLine ("Buffer size: {0}", reply.Buffer.Length);
            } else 
                Console.WriteLine(reply.Status);

            if(reply.RoundtripTime > 100)
                Console.WriteLine("Dear lord, Bro jUst GeT A BeTTer InterNET !");
            else if(reply.RoundtripTime < 20)
                    Console.WriteLine("Alright my G!. Ya got good network");




        }
    }
}
