using System;

namespace ToDo.Core
{
    public interface IExecutor
    {
        void Execute(Action action);
    }
}