using System;
using System.Windows.Forms;
using ToDo.Core;

namespace ToDo.Ui
{
    public delegate void AddTaskRequest(string action);

    public delegate void RemoveTaskRequest(Task task);

    public partial class ToDoListView : Form, IToDoListView
    {
        private ITaskList taskList;

        public event AddTaskRequest AddTaskRequest = delegate { };
        public event RemoveTaskRequest RemoveTaskRequest = delegate { };

        public ToDoListView()
        {
            InitializeComponent();
        }

        public ToDoListView(ITaskList taskList)
        {
            InitializeComponent();
            this.taskList = taskList;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            taskList.TaskAdded += AddTaskToList;
            taskList.TaskRemoved += RemoveTaskFromList;
        }

        public void AddTaskToList(Task task)
        {
            this.ThreadSafeInvoke(() => tasksListView.AddObject(task));
        }

        public void RemoveTaskFromList(Task task)
        {
            this.ThreadSafeInvoke(() => tasksListView.RemoveObject(task));
        }

        private void newTaskTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter && newTaskTextBox.Text.Length > 0)
            {
                AddTaskRequest(newTaskTextBox.Text);
                newTaskTextBox.Clear();
            }
        }

        private void tasksListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var obj in tasksListView.SelectedObjects)
            {
                var task = obj as Task;
                if (task != null) RemoveTaskRequest(task);
            }
        }

        public void DisplayView()
        {
            Show();
        }
    }
}
