using System;
using ToDo.Core;

namespace ToDo.Ui
{
    public class ToDoListPresenter : IPresenter
    {
        private IToDoListView view;
        private ITaskList taskList;
        private IExecutor executor;

        public ToDoListPresenter(IToDoListView view, ITaskList taskList, IExecutor executor)
        {
            this.view = view;
            this.executor = executor;
            this.taskList = taskList;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            taskList.TaskAdded += view.AddTaskToList;
            taskList.TaskRemoved += view.RemoveTaskFromList;

            view.RemoveTaskRequest += RemoveTaskRequestHandler;
            view.AddTaskRequest += AddTaskRequestHandler;
        }

        private void RemoveTaskRequestHandler(Task task)
        {
            executor.Execute(() => taskList.RemoveTask(task));
        }

        private void AddTaskRequestHandler(string action)
        {
            executor.Execute( () => taskList.AddTask(new Task(action)));
        }
        public void ShowView()
        {
            view.DisplayView();
        }
    }
}