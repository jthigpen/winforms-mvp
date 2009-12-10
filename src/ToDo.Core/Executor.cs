using System;

namespace ToDo.Core
{
    public class Executor : IExecutor 
    {
        public void Execute(Action action)
        {
            action.Invoke();
        }
    }
}