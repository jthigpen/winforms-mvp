using System;
using System.Linq;
using NUnit.Framework;
using Rhino.Mocks;
using ToDo.Core;
using ToDo.Ui;

namespace ToDo.Specs.Ui
{
    public class ToDoListSpecs
    {
        public abstract class ToDoListContext : ContextSpecification
        {
            protected IToDoListView view;
            protected ToDoListPresenter presenter;
            protected ITaskList taskList;
            protected IExecutor executor;
            protected string taskName = "Action";
        }

        public class When_adding_an_action_to_empty_list : ToDoListContext
        {
            protected override void EstablishContext()
            {
                executor = new Executor();
                taskList = new TaskList();
                view = MockRepository.GenerateMock<IToDoListView>();
                presenter = new ToDoListPresenter(view, taskList, executor);

            }

            protected override void Because()
            {
                view.Raise(x => x.AddTaskRequest += null, taskName);
            }

            [Test]
            public void should_increase_task_count_to_one()
            {
                taskList.Count.ShouldEqual(1);
            }

            [Test]
            public void should_add_task_to_task_list_with_correct_action()
            {
                taskList.Tasks.First().Action.ShouldEqual(taskName);
            }

            [Test]
            public void should_add_new_task_to_view()
            {
                view.AssertWasCalled(v => v.AddTaskToList(Arg<Task>.Is.Anything));
            }

            [Test]
            public void should_add_task_to_view_with_correct_action()
            {
                view.AssertWasCalled(v => v.AddTaskToList(Arg<Task>.Matches(t => t.Action == taskName)));
            }
        }
    }
}