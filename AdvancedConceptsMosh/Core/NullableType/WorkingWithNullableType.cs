using System;

namespace AdvancedConceptsMosh
{
    public static class WorkingWithNullableType
    {
        public static void ShowResult()
        {
            /// Sumary
            /// For default DateTime cannot be null
            /// DateTime date = null;
            /// So we need treat that

            //First:
            Nullable<DateTime> date = null;
            Console.WriteLine($"One: {date}");

            //Second and the same above
            DateTime? date2 = date;
            Console.WriteLine($"Two: {date2}");

            //Treatment
            DateTime  date3 = date2.GetValueOrDefault();
            Console.WriteLine($"Three: {date3}");

            //Treatment Two
            date3 = date2 ?? DateTime.Today;
            Console.WriteLine($"Four: {date3}");

        }
    }
}
