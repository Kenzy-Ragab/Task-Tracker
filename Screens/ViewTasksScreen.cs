using System;
using System.Threading.Tasks;
using TaskTracker.Helpers;
using TaskTracker.Models;
using TaskTracker.Services;
using TaskStatus = TaskTracker.Models.TaskStatus;

namespace TaskTracker.Screens
{
    public static class ViewTasksScreen
    {

        // Menu Of View Options
        public static void Show(TaskService taskService)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════╗");
                Console.WriteLine("║       VIEW TASKS FILTER      ║");
                Console.WriteLine("╠══════════════════════════════╣");
                Console.WriteLine("║ [1] All Tasks                ║");
                Console.WriteLine("║ [2] Completed Tasks          ║");
                Console.WriteLine("║ [3] Pending Tasks            ║");
                Console.WriteLine("║ [4] Overdue Tasks            ║");
                Console.WriteLine("║ [5] Main Menu                ║");
                Console.WriteLine("╚══════════════════════════════╝");
                Console.Write("\n-> Select an option (1-5): ");
                var choice = InputHelper.ReadIntNumberBetween(1, 5);

                switch (choice)
                {
                    case 1: ShowList(taskService.GetAll(), "All Tasks"); break;
                    case 2: ShowList(taskService.GetCompleted(), "Completed Tasks"); break;
                    case 3: ShowList(taskService.GetPending(), "Pending Tasks"); break;
                    case 4: ShowList(taskService.GetOverdue(), "Overdue"); break;
                    case 5: return;
                }

            }
        }


        // Show Options
        private static void ShowList(List<TaskModel> tasks, string title)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine($"║          {title.ToUpper(),-26}  ║");
            Console.WriteLine("╚══════════════════════════════════════╝\n");

            if (tasks.Count == 0)
                Console.WriteLine("No tasks found!");
            else
            {
                foreach (var task in tasks)
                {
                    string dueDate = task.DueDate.ToString("dd-MM-yyyy");

                    // visulaizion
                    Console.ForegroundColor = task.Status switch
                    {
                        TaskStatus.Completed => ConsoleColor.Green,
                        TaskStatus.Pending => ConsoleColor.Yellow,
                        TaskStatus.InProgress => ConsoleColor.Cyan,
                        _ => ConsoleColor.White
                    };

                    // printing
                    Console.WriteLine("┌──────────────────────────────────────┐");
                    Console.WriteLine($"│ ID       : {task.Id,-26}│");
                    Console.WriteLine($"│ Title    : {task.Title,-26}│");
                    Console.WriteLine($"│ Desc.    : {task.Description,-26}│");
                    Console.WriteLine($"│ Due Date : {dueDate,-26}│");
                    Console.WriteLine($"│ Priority : {task.Priority,-26}│");
                    Console.WriteLine($"│ Status   : {task.Status,-26}│");
                    Console.WriteLine("└──────────────────────────────────────┘\n");

                    Console.ResetColor();
                }
            }

            Console.WriteLine("\nPress any key to return to filter menu...");    
            Console.ReadKey();
        }
    }
}
