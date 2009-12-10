using System.Collections.Generic;
using System.Linq;

namespace ToDo.Core
{
    public delegate void TaskAddedDelegate(Task task);
    
    public class TaskList
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

        public IEnumerable<Task> Tasks
        {
            get
            {
                return tasks.AsReadOnly();
            }
        }

        public Task MostRecentTask
        {
            get
            {
                return Tasks.OrderBy(t => t.Timestamp).FirstOrDefault();
            }
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            TaskAdded(task);
        }
    }
}