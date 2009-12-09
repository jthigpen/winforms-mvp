using System;
using NUnit.Framework;
using ToDo.Core;

namespace ToDo.Specs.Models
{
    public class TaskSpecs
    {
        public abstract class TaskContext : ContextSpecification
        {

        }

        public class When_recording_a_task : TaskContext
        {
            protected override void EstablishContext()
            {
                action = "Buy Eggs";
            }

            protected override void Because()
            {
                task = new Task(action);
            }

            [Test]
            public void should_record_task_action()
            {
                task.Action = action;
            }

            [Test]
            public void should_record_task_status()
            {
                throw new NotImplementedException();
            }

            [Test]
            public void should_notify_task_recorded()
            {
                throw new NotImplementedException();
            }

            [Test]
            public void should_increase_number_of_tasks_by_one()
            {
                throw new NotImplementedException();
            }

            [Test]
            public void should_replace_most_recent_task_with_newly_recorded_task()
            {
                throw new NotImplementedException();
            }

            private Task task;
            private string action;
        }
    }
}