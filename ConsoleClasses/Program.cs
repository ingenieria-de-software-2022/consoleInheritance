using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ci oi = new Ci();

            oi.Pi = 10.5;
            oi.Meti();
            Console.WriteLine(oi.Pi);

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }
    }
}
