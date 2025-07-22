using System;
using TaskTracker.Models;
using TaskTracker.Services;
using TaskTracker.Helpers;


namespace TaskTracker.Screens
{
    public static class AddTaskScreen
    {
        public static void Show(TaskService service)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║          ADD NEW TASK          ║");
            Console.WriteLine("╚════════════════════════════════╝\n");
            var task = new TaskModel();

            task.Id = service.GetNextId(); //auto-generated task ID
            Console.WriteLine($"-> Task Id: {task.Id}");

            Console.Write("-> Title: ");
            task.Title = Console.ReadLine() ?? "";

            Console.Write("-> Description: ");
            task.Description = Console.ReadLine() ?? "";

            task.DueDate = InputHelper.ReadDate("-> Due Date (yyyy-MM-dd): ");

            Console.Write("\n-> Status:");
            Console.WriteLine("\n   [1] Pending\n   [2] InProgress\n   [3] Completed");
            task.Status = (TaskTracker.Models.TaskStatus)InputHelper.ReadIntNumberBetween(1, 3);

            Console.WriteLine("\n-> Priority:");
            Console.WriteLine("\n   [1] Low\n   [2] Medium\n   [3] High");
            task.Priority = (TaskPriority)InputHelper.ReadIntNumberBetween(1, 3);

            // adding
            service.Add(task);
            TaskStorageService.SaveTasksToFile(service.GetAll());
            Console.WriteLine("\n\nTask added successfully!");
        }
    }
}



