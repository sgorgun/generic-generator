using System;

namespace GenericSequenceGenerator
{
    public interface ISequenceGenerator<out T>
    {
        T Previous { get; }
        T Current { get; }
        T Next { get; }
    }

    public abstract class SequenceGenerator<T> : ISequenceGenerator<T>
    {
        private T previous;
        private T current;
        private int count;

        public T Previous => previous;
        public T Current => current;
        public abstract T Next { get; }
        public int Count => count;

        protected SequenceGenerator(T previous, T current)
        {
            this.previous = previous;
            this.current = current;
            count = 2;
        }

        protected T UpdateValues(T next)
        {
            previous = current;
            current = next;
            count++;
            return next;
        }
    }

    public class FibonacciSequenceGenerator : SequenceGenerator<int>
    {
        public FibonacciSequenceGenerator(int previous, int current) : base(previous, current)
        {
        }

        public override int Next => UpdateValues(Previous + Current);
    }

    public class SecondSequenceGenerator : SequenceGenerator<int>
    {
        public SecondSequenceGenerator(int previous, int current) : base(previous, current)
        {
        }

        public override int Next => UpdateValues(6 * Current - 8 * Previous);
    }

    public class ThirdSequenceGenerator : SequenceGenerator<double>
    {
        public ThirdSequenceGenerator(double previous, double current) : base(previous, current)
        {
        }

        public override double Next => UpdateValues(Current + Previous / Current);
    }
}
