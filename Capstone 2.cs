using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)

        {
            bool shouldQuit = false;

            Console.WriteLine("Welcome to the Task Manager!");
            List<Task> taskList = new List<Task>();
            Task task = new Task("Katie", "Clean kitchen", DateTime.Now, false);
            taskList.Add(task);
            do
            {
                // adds task just created to Tasks
                string action = GetTaskAction();

                switch (action)
                {
                    case "1":
                        ListTasks(taskList);
                        break;
                    case "2":
                        AddTask(taskList);
                        break;
                    case "3":
                        DeleteTask(taskList);
                        break;
                    case "4":
                        MarkComplete(taskList);
                        break;
                    case "5":
                       shouldQuit =  Quit();
                        break;
                }
               
            }
            while (!shouldQuit);
           
        }
        static void ListTasks(List<Task> tasks)
        {
            Console.WriteLine("You have " + tasks.Count.ToString() + " task(s)");
            // \t is a tab for the table
            Console.WriteLine("Done? \t due date \t team member \t\t description");
            foreach (Task task in tasks)
            {
                Console.Write(task.GetCompleted());
                Console.Write(" \t ");
                // outputted date will not include time
                Console.Write(task.GetDueDate().ToShortDateString());
                Console.Write(" \t ");
                Console.Write(task.GetName());
                Console.Write(" \t\t ");
                Console.Write(task.GetDescription());
                Console.WriteLine();
            }

        }
        static string GetTaskAction()
        {
            Console.WriteLine("1. List tasks");
            Console.WriteLine("2. Add task");
            Console.WriteLine("3. Delete task");
            Console.WriteLine("4. Mark task complete");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            return Console.ReadLine();
        }

        static void AddTask(List<Task> tasks)
        {
            Console.WriteLine("Enter member name:");
            string memberName = Console.ReadLine();
            Console.WriteLine("Enter description:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter due date: (mm/dd/yyyy)");
            // passes in input string to method that converts it to a date
            DateTime dueDate = DateTime.Parse (Console.ReadLine());
            Task task = new Task(memberName, description, dueDate, false);
            tasks.Add(task);
        }

        static void DeleteTask(List<Task> tasks)
        {
            Console.WriteLine("Which task number would you like to delete?");
            int taskNumber = int.Parse(Console.ReadLine());

            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
            }
            else
            {
                Console.WriteLine("There is no task with that given number");
            }
            
        }

        static void MarkComplete(List<Task> tasks)
        {
            Console.WriteLine("Which task number would you like to mark complete?");
            int taskNumber = int.Parse(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1].SetCompleted(true);
            }
            else
            {
                Console.WriteLine("There is no task with given number");
            }
        }

        static bool Quit()
        {
            Console.WriteLine("Are you sure? y/n");
            string answer = Console.ReadLine();
            return answer == "y";
        }
    }
}
