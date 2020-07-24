using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstItem = new WorkItem("Present O'Reilly session");
            firstItem.Priority = 1;
            firstItem.Completed = false;

            var secondItem = new WorkItem("Fix coffee");
            secondItem.Priority = 5;

            secondItem.IncreasePriority();
            secondItem.Completed = true;

            // Console.WriteLine($"{firstItem.Description} - {firstItem.Priority} - {firstItem.Completed}");
            // Console.WriteLine($"{secondItem.Description} - {secondItem.Priority} - {secondItem.Completed}");

            LogItem(firstItem);
            LogItem(new PersonalItem() { Description = "Brush teeth", Completed = true });
        }

        static void LogItem(IToDoItem item)
        {
            // Console.WriteLine($"{item.Description} - {item.Completed}");
            
            string jsonItem = JsonConvert.SerializeObject(item);
            Console.WriteLine(jsonItem);
        }
    }
}
