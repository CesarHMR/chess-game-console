using GameComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p = new Position(1, 1);
            Console.WriteLine(p.ToString());


            Console.ReadLine();
        }
    }
}
