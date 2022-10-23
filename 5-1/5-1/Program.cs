using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Первый принтер");

            SecondPrinter secondPrinter = new SecondPrinter();
            secondPrinter.Print("Второй принтер");

            Console.ReadLine();
        }
    }
}
