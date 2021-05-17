using System;
using UsingLinq.Entities;

namespace UsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqApplication.Execution();
            Console.WriteLine("--------------------------------------------------------------------------------");
            LinqSQLNotation.Execution();
            Console.ReadKey();
        }
    }
}
