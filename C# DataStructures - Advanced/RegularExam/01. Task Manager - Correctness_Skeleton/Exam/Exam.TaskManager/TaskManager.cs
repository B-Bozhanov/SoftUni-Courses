using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.TaskManager
{
    public class TaskManager : ITaskManager
    {
        private Dictionary<string, Task> allTasks = new Dictionary<string, Task>();
        private Queue<Task> tasksToExecute = new Queue<Task>();

        public void AddTask(Task task)
        {
            if (!this.allTasks.ContainsKey(task.Id))
            {
                this.allTasks.Add(task.Id, task);
                this.tasksToExecute.Enqueue(task);
            }
        }

        public bool Contains(Task task)
        {
            return this.allTasks.ContainsKey(task.Id);
        }

        public void DeleteTask(string taskId)
        {
            if (!this.allTasks.ContainsKey(taskId))
            {
                throw new ArgumentException();
            }

            this.allTasks.Remove(taskId);
        }

        public Task ExecuteTask()
        {
            if (!this.tasksToExecute.Any())
            {
                throw new ArgumentException();
            }

            return this.tasksToExecute.Dequeue();
        }

        public IEnumerable<Task> GetAllTasksOrderedByEETThenByName()
        {
            return this.allTasks.Values
                 .OrderByDescending(t => t.EstimatedExecutionTime)
                 .ThenBy(t => t.Name.Length);
        }

        public IEnumerable<Task> GetDomainTasks(string domain)
        {
            var tasks = this.tasksToExecute.Where(t => t.Domain == domain);
            if (tasks.Count() == 0 || tasks == null)
            {
                throw new ArgumentException();
            }

            return tasks;
        }

        public Task GetTask(string taskId)
        {
            if (!this.allTasks.ContainsKey(taskId))
            {
                throw new ArgumentException();
            }

            return this.allTasks[taskId];
        }

        public IEnumerable<Task> GetTasksInEETRange(int lowerBound, int upperBound)
        {
            return this.tasksToExecute.Where(t => t.EstimatedExecutionTime >= lowerBound && t.EstimatedExecutionTime <= upperBound);
        }

        public void RescheduleTask(string taskId)
        {
            if (!this.allTasks.ContainsKey(taskId))
            {
                throw new ArgumentException();
            }

            this.tasksToExecute.Enqueue(allTasks[taskId]);
        }

        public int Size()
        {
            return this.allTasks.Count;
        }
    }
}
