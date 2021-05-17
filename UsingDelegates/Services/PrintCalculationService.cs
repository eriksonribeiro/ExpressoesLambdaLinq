using System;
using UsingDelegates.Entities;

namespace UsingDelegates.Services
{
   public static class PrintCalculationService
    {
        delegate double BinaryNumericOperation(double x, double y);
        delegate void ShowBinaryNumericOperation(double x, double y);
        public static void PrintComumCommands(Number n)
        {
            //Using Normal Commands

            Console.WriteLine($"1 - Using Comum Commands\n" +
                              $"MAX    between {n.ValueX} and {n.ValueY} = {CalculationService.Max(n.ValueX, n.ValueY)}\n" +
                              $"SUM    of      {n.ValueX} and {n.ValueY} = {CalculationService.Sum(n.ValueX, n.ValueY)}\n" +
                              $"SQUARE of      {n.ValueX}  = {CalculationService.Square(n.ValueX)}\n" +
                              $"----------------------------------------------------");
        }

        public static void PrintUsingDelegate(Number n)
        {
            //Using Delegate
            double max, sum, square;


            BinaryNumericOperation opMax = CalculationService.Max;
            BinaryNumericOperation opSum = CalculationService.Sum;
           // BinaryNumericOperation OpSquare = CalculationService.Square; Dont work because the signature its different.

            max = opMax.Invoke(n.ValueX, n.ValueY);
            sum = opSum.Invoke(n.ValueX, n.ValueY);
            square = CalculationService.Square(n.ValueX);

            Console.WriteLine($"2 - Using Delegate\n" +
                              $"MAX    between {n.ValueX} and {n.ValueY} = {max}\n" +
                              $"SUM    of      {n.ValueX} and {n.ValueY} = {sum}\n" +
                              $"SQUARE of      {n.ValueX}  = {square}\n" +
                              $"----------------------------------------------------");

        }

        public static void PrintUsingMultiCastDelegate(Number n)
        {
            //Using Multi Cast Delegate Interation
            ShowBinaryNumericOperation operation = CalculationService.ShowMax;
            operation += CalculationService.ShowSum;
            operation.Invoke(n.ValueX, n.ValueY);
        }

    }
}
