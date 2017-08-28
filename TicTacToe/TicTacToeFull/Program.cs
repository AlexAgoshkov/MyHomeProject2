using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFull
{
    class Program
    {
        static void Main(string[] args)
        {
            Action a = new Action();

            View v = new View();

             v.MainShow(a);

            Console.ReadKey();
        }
    }
}
