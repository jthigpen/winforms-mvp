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
            this.taskList.TaskAdded += UpdateList;
        }

        private void UpdateList(Task task)
        {
            tasksListView.AddObject(task);
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
            foreach (var task in tasksListView.SelectedObjects)
            {
                tasksListView.RemoveObject(task);
            }
        }
    }
}
