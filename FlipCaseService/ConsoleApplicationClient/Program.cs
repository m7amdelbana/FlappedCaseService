using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplicationClient.ServiceReferenceFlipCase;

namespace ConsoleApplicationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCaseServiceClient Client = new FlipCaseServiceClient("BasicHttpBinding_IFlipCaseService");
            StringData sd = new StringData();
            Console.Write("Insert Text: ");
            sd.OriginalString = Console.ReadLine();
            sd = Client.FlipTheCase(sd);
            Console.WriteLine("Flipped Text: " + sd.FlippedCaseString);
            Console.ReadLine();

        }
    }
}
