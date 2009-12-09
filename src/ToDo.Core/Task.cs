using System;

namespace ToDo.Core
{
    public class Task
    {
        public Task(string action)
        {
            Action = action;
        }

        public string Action { get; set; }
        public DateTime Timestamp = SystemTime.Now();
    }
}
