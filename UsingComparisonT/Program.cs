using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingComparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.UsingIComparable();
            Menu.UsingMethodReference();
            Menu.UsingMethodReferenceVariable();
            Menu.UsingLambdaVariable();
            Menu.UsingLambdaExpression();

            Console.ReadKey();
        }
    }
}
