using ToDo.Core;

namespace ToDo.Ui
{
    public interface IToDoListView
    {
        void AddTaskToList(Task task);
        void RemoveTaskFromList(Task task);
        event AddTaskRequest AddTaskRequest;
        event RemoveTaskRequest RemoveTaskRequest;
    }
}