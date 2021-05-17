using System;

namespace AdvancedConceptsMosh
{ 
    public static class DelegatesConcepts
    {
        public static void FuncWithLambdaExpression()
        {
            //Func<in, Out>
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));
        }
        
    }
}
