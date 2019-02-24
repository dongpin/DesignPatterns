using System;

namespace com.quansheng.DesignPatterns.Iterator
{
    public abstract class Iterator
    {
        public abstract Object First();
        public abstract Object Next(); 
        public abstract Object Current();
        public abstract bool IsDone();
    }
}