using System.Collections.Generic;
using System.Threading;

namespace ToDo.Core
{
    public delegate void TaskAddedDelegate(Task task);
    public delegate void TaskRemovedDelegate(Task task);

    public class TaskList : ITaskList
    {
        private List<Task> tasks = new List<Task>();

        public int Count
        {
            get
            {
                return tasks.Count;
            }
        }

        public event TaskAddedDelegate TaskAdded = delegate { };
        public event TaskRemovedDelegate TaskRemoved = delegate { };

        public IEnumerable<Task> Tasks
        {
            get
            {
                return tasks.AsReadOnly();
            }
        }

        public void AddTask(Task task)
        {
            Thread.Sleep(3000);
            tasks.Add(task);
            TaskAdded(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
            TaskRemoved(task);
        }
    }
}