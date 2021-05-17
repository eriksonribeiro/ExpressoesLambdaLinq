using System;
using UsingDelegates.Services;
using UsingDelegates.Entities;
using System.Collections.Generic;

namespace UsingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = ProductService.CreateListOfProduct();
            Number numbers = new Number(10, 20);

            Console.WriteLine("=> Delegate Introdution:\n");
            PrintCalculationService.PrintComumCommands(numbers);
            PrintCalculationService.PrintUsingDelegate(numbers);
            PrintCalculationService.PrintUsingMultiCastDelegate(numbers);

            Console.WriteLine("\n=> Using Delegate Predicate:");
            for (int i = 1; i <= 2; i++)
                ProductService.RemoveProduct(i, list);

            Console.WriteLine("\n=> Using Delegate Action:");
            for (int i = 1; i <= 4; i++)
                ProductService.ChangePrice(i, list);

            Console.WriteLine("\n=> Using Delegate Func:");
            for (int i = 1; i <= 4; i++)
                ProductService.UpperCaseName(i, list);

            Console.ReadKey();
        }
    }
}
