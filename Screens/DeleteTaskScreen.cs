using System;
using TaskTracker.Helpers;
using TaskTracker.Services;

namespace TaskTracker.Screens
{
    public static class DeleteTaskScreen
    {
        public static void Show(TaskService taskService)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║         DELETE TASK          ║");
            Console.WriteLine("╚══════════════════════════════╝\n");

            // check id
            int id = InputHelper.ReadInt("-> Enter Task ID to delete: ");
            var task = taskService.GetById(id);
            if (task == null)
            {
                Console.WriteLine("\n\nTask not found, Nothing was deleted!.");
                return;
            }

            // confirmation
            Console.Write("\nAre you sure you want to delete this task? (y/n): ");
            var confirmation = Console.ReadLine()?.Trim().ToLower();
            if (confirmation != "y")
            {
                Console.WriteLine("\n\nDeletion cancelled.");
                return;
            }

            // deletion
            taskService.Delete(id);
            TaskStorageService.SaveTasksToFile(taskService.GetAll());
            Console.WriteLine("\n\nTask deleted successfully!.");
        }
    }
}
