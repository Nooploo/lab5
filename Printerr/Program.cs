using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("212121");

            DELL1710 dELL1710 = new DELL1710();
            dELL1710.Print("///");

            Console.ReadLine();
        }
    }
}
