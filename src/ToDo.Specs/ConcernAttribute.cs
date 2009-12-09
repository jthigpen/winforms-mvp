using System;

namespace ToDo.Specs
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class ConcernAttribute : Attribute
    {
        public ConcernAttribute(Type type)
        {
            this.Concern = type;
        }

        public Type Concern { get; private set; }
    }
}