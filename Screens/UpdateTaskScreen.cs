using System;
using TaskTracker.Helpers;
using TaskTracker.Models;
using TaskTracker.Services;
using TaskStatus = TaskTracker.Models.TaskStatus;

namespace TaskTracker.Screens
{
    public static class UpdateTaskScreen
    {
        public static void Show(TaskService taskService)
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║          UPDATE TASK STATUS        ║");
            Console.WriteLine("╚════════════════════════════════════╝\n");

            // check id
            int id = InputHelper.ReadInt("-> Enter Task ID: ");
            var task = taskService.GetById(id);
            if (task == null)
            {
                Console.WriteLine("\n\t\tTask not found!.");
                return;
            }

            // choice
            Console.WriteLine("\n-> Select New Status:");
            Console.WriteLine("[1] Pending");
            Console.WriteLine("[2] In Progress");
            Console.WriteLine("[3] Completed");

            Console.Write("\n-> Choose an option (1-3): ");
            int choice = InputHelper.ReadIntNumberBetween(1, 3);
            task.Status = choice switch
            {
                1 => TaskStatus.Pending,
                2 => TaskStatus.InProgress,
                3 => TaskStatus.Completed,
                _ => task.Status 
            };

            // updating
            taskService.Update(task);
            TaskStorageService.SaveTasksToFile(taskService.GetAll());
            Console.WriteLine("\n\nTask status updated successfully!");
        }
    }
}