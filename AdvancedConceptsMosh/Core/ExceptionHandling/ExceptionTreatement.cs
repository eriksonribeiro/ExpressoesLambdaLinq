using System;
using System.IO;

namespace AdvancedConceptsMosh
{
    public static class ExceptionTreatement
    {
        public static void DivisionByZero()
        {
            try
            {
                int x = 0, y = 2;
                
                int result = y / x;

                Console.WriteLine($" {result}");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception: Erro de divisão por zero");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UsingStatement()
        {
            try
            {
                using (var streamReader = new StreamReader(@"C:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
        }

    }
}
