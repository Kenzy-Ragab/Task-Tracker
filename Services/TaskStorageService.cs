using System;
using TaskTracker.Models;
using TaskStatus = TaskTracker.Models.TaskStatus;

namespace TaskTracker.Services
{
    public static class TaskStorageService
    {
        private static readonly string FilePath =Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.txt") ;

        public static List<TaskModel> LoadTasksFromFile()
        {
            List<TaskModel> tasks = new List<TaskModel>();
            try
            {
                if (!File.Exists(FilePath))
                    return tasks; //return Empty

                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 6
                            && Enum.TryParse(parts[4], out TaskStatus status)
                            && Enum.TryParse(parts[5], out TaskPriority priority))
                        {
                            tasks.Add(new TaskModel
                            {
                                Id = int.Parse(parts[0]),
                                Title = parts[1],
                                Description = parts[2],
                                DueDate = DateTime.Parse(parts[3]),
                                Status = status,
                                Priority = priority
                            });
                        }
                    }
                }
                Console.WriteLine("\n\nTasks loaded from file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nError loading tasks: " + ex.Message);
            }
            return tasks;
        }

        public static void SaveTasksToFile(List<TaskModel> tasks)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (var task in tasks)
                    {
                        string line = $"{task.Id}|{task.Title}|{task.Description}|{task.DueDate.ToString("yyyy-MM-dd")}|{task.Status}|{task.Priority}";
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("\n\nTasks saved to file.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("\n\nError saving tasks: " + ex.Message);
            }

        }

    }
}
