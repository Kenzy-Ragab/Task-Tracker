using System;

namespace TaskTracker.Models
{
    public enum TaskStatus { Pending = 1, InProgress = 2, Completed = 3 };
    public enum TaskPriority { Low = 1, Medium = 2, High = 3 };

    public class TaskModel
    {
        //Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        
        // ReadOnly Computed Property
        public bool IsOverdue => DateTime.Now > DueDate && Status != TaskStatus.Completed;
    }
}
