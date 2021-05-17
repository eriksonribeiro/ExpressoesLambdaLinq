using System;
using System.Threading.Tasks;

namespace AdvancedConceptsMosh
{
    public static class Tarefas
    {
        public static void LerData()
        {
            Console.WriteLine($"Data: {DateTime.Now}");
        }

        public static void ShowTasks()
        {
            #region Task
            Console.WriteLine("\nUsing Tasks");
            // Using Task + Action

            Task task1 = new Task(new Action(Tarefas.LerData));

            //Using Anonymous Method
            Task task2 = new Task(delegate { Console.WriteLine($"Data: {DateTime.Now}"); });

            //Using Lambda
            Task task3 = new Task(() => Tarefas.LerData());
            Task task4 = new Task(() => { Console.WriteLine($"Data: {DateTime.Now}"); });

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            #endregion
        }
    }
}
