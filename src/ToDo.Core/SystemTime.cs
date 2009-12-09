using System;

namespace ToDo.Core
{
    public class SystemTime
    {
        public static Func<DateTime> Now = () => DateTime.Now;
    }
}