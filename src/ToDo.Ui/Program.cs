using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToDo.Core;

namespace ToDo.Ui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var taskList = new TaskList();
            var view = new ToDoListView();
            var executor = new BackgroundUnitOfWorkSessionHandlingMagicalExecutor();
            var presenter = new ToDoListPresenter(view, taskList, executor);

            Application.Run(view);
        }
    }
}
