using System;
using TaskTracker.Models;

namespace TaskTracker.Services
{
    public class TaskService
    {
        // Declarition List
        private List<TaskModel> _tasks;

        // Constructor To LoadDate
        public TaskService() => _tasks = TaskStorageService.LoadTasksFromFile();
       
        // Methods of Menu Options 
        public  void Add(TaskModel task) => _tasks.Add(task); 
        public  void Update(TaskModel updateTask)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == updateTask.Id);
            if (task != null)
            {
                task.Title = updateTask.Title;
                task.Description = updateTask.Description;
                task.DueDate = updateTask.DueDate;
                task.Status = updateTask.Status;
                task.Priority = updateTask.Priority;
            }
        }
        public  void Delete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null) 
               _tasks.Remove(task);
        }

        // Check the Correct Id
        public TaskModel? GetById(int id) => _tasks.FirstOrDefault(t => t.Id == id);
        // Check and Avoiding the Duplicating
        public int GetNextId() => _tasks.Count == 0 ? 1 : _tasks.Max(t => t.Id) + 1;

        // Methods of View Options 
        public List<TaskModel> GetAll() => _tasks;
        public List<TaskModel> GetCompleted() => _tasks.Where(t => t.Status == TaskTracker.Models.TaskStatus.Completed).ToList();
        public List<TaskModel> GetPending() => _tasks.Where(t => t.Status == TaskTracker.Models.TaskStatus.Pending).ToList(); 
        public List<TaskModel> GetOverdue() => _tasks.Where(t => t.Status != TaskTracker.Models.TaskStatus.Completed && t.DueDate < DateTime.Now).ToList();
    }

}

