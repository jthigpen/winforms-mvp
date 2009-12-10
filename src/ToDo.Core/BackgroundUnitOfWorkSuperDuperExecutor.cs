using System;
using System.Threading;

namespace ToDo.Core
{
    public class BackgroundUnitOfWorkSessionHandlingMagicalExecutor : IExecutor
    {
        public void Execute(Action action)
        {
            ThreadPool.QueueUserWorkItem(x =>
                                             {
                                                 StartUnitOfWork();
                                                 action.Invoke();
                                                 EndUnitOfWork();
                                             });
        }

        private void StartUnitOfWork()
        {
            Console.WriteLine("Starting Unit Of Work");
        }

        private void EndUnitOfWork()
        {
            Console.WriteLine("Ending Unit Of Work");
        }
    }
}