using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GenericSequenceGenerator;
public interface ISequenceGenerator<out T>
{
    T Previous { get; }
    T Current { get; }
    T Next { get; }
}

public abstract class SequenceGenerator<T> : ISequenceGenerator<T>
{
    protected T previous;
    protected T current;

    public T Previous => previous;
    public T Current => current;
    public T Next
    {
        get => GetNext();
        set => throw new NotImplementedException();
    }
    public int Count { get; set; }

    protected SequenceGenerator(T previous, T current)
    {
        this.previous = previous;
        this.current = current;
        Count = 2;
    }

    public abstract T GetNext();
}

public class FibonacciSequenceGenerator : SequenceGenerator<int>
{
    public FibonacciSequenceGenerator(int previous, int current) : base(previous, current)
    {
    }


    public override int GetNext()
    {
        int next = previous + current;
        previous = current;
        current = next;
        Count++;
        return next;
    }
}

public class SecondSequenceGenerator : SequenceGenerator<int>
{
    public SecondSequenceGenerator(int previous, int current) : base(previous, current)
    {
    }

    public override int GetNext()
    {
        var next = 6 * current - 8 * previous;
        previous = current;
        current = next;
        Count++;
        return next;
    }   
}

public class ThirdSequenceGenerator : SequenceGenerator<double>
{
    public ThirdSequenceGenerator(double previous, double current) : base(previous, current)
    {
    }

    public override double GetNext()
    {
        var next = current + previous / current;
        previous = current;
        current = next;
        Count++;
        return next;
    }
}