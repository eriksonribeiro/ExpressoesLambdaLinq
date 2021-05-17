using System;

namespace AdvancedConceptsMosh
{
    partial class Program
    {
        public class UsingEnum
        {
            public WeekDays weekDay { get; set; }
            public void ShowEnum()
            {
                Console.WriteLine($"Dia da Semana: {weekDay}");
                Console.WriteLine($"Dia da Semana: {weekDay.GetHashCode()}");
            }
        }
    }
}
