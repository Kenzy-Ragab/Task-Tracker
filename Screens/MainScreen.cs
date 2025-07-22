using System;
using TaskTracker.Models;
using TaskTracker.Screens;
using TaskTracker.Services;

namespace TaskTracker.Screens
{
    public static class MainScreen
    {
        public static void Show(TaskService taskService)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════╗");
                Console.WriteLine("║        TASK TRACKER          ║");
                Console.WriteLine("╠══════════════════════════════╣");
                Console.WriteLine("║ [1] Add New Task             ║");    
                Console.WriteLine("║ [2] View Tasks               ║");
                Console.WriteLine("║ [3] Update Task              ║");
                Console.WriteLine("║ [4] Delete Task              ║");
                Console.WriteLine("║ [5] Exit                     ║");
                Console.WriteLine("╚══════════════════════════════╝");
                Console.Write("\n-> Select an option (1-5): ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddTaskScreen.Show(taskService); break;
                    case "2": ViewTasksScreen.Show(taskService); break;
                    case "3": UpdateTaskScreen.Show(taskService); break;
                    case "4": DeleteTaskScreen.Show(taskService); break;
                    case "5": Console.WriteLine("\nThank you for using Task Tracker!\nKeep pushing forward \nGoodbye."); return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
    
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
