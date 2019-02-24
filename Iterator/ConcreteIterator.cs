using System;

namespace com.quansheng.DesignPatterns.Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override Object First()
        {
            return this._aggregate[0];
        }

        public override Object Next()
        {
            if (this._current < this._aggregate.Count - 1)
            {
                return this._aggregate[++this._current];
            }

            return null;
        }

        public override Object Current()
        {
            return this._aggregate[this._current];
        }

        public override bool IsDone()
        {
            return this._current >= this._aggregate.Count - 1;
        }
    }
}