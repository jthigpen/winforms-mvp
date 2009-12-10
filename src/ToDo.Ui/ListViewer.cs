using System;
using System.Windows.Forms;
using ToDo.Core;

namespace ToDo.Ui
{
    public partial class ListViewer : Form
    {
        private TaskList taskList;

        public ListViewer()
        {
            InitializeComponent();
        }

        public ListViewer(TaskList taskList)
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

        private void AddTaskToList(Task task)
        {
            tasksListView.AddObject(task);
        }

        private void RemoveTaskFromList(Task task)
        {
            tasksListView.RemoveObject(task);
        }

        private void newTaskTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                var taskDescription = newTaskTextBox.Text;
                var task = new Task(taskDescription);
                taskList.AddTask(task);
                newTaskTextBox.Clear();
            }
        }

        private void tasksListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var obj in tasksListView.SelectedObjects)
            {
                var task = obj as Task;
                if (task != null) taskList.RemoveTask(task);
            }
        }
    }
}
