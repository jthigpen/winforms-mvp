using System.Collections.Generic;

namespace ToDo.Core
{
    public interface ITaskList
    {
        int Count { get; }
        IEnumerable<Task> Tasks { get; }
        event TaskAddedDelegate TaskAdded;
        event TaskRemovedDelegate TaskRemoved;
        void AddTask(Task task);
        void RemoveTask(Task task);
    }
}