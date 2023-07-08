namespace GenericSequenceGenerator.Tests
{
    [TestFixture]
    public class FibonacciSequenceGeneratorTests
    {
        [TestCase(20, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 })]
        public void GetNext_Should_Advance_Generator_In_Fibonacci_Sequence(int count, int[] expected)
        {
            var previous = 0;
            var current = 1;

            var fibonacciGenerator = new FibonacciSequenceGenerator(previous, current);
            var list = new List<int>(count)
            {
                fibonacciGenerator.Previous,
                fibonacciGenerator.Current
            };

            for (int i = 1; i <= count - 2; i++)
            {
                list.Add(fibonacciGenerator.Next);
            }

            CollectionAssert.AreEqual(expected, list.ToArray());
            Assert.That(fibonacciGenerator.Count == count);
        }
    }

    [TestFixture]
    public class SecondSequenceGeneratorTests
    {
        [TestCase(10, new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 })]
        public void GetNext_Should_Advance_Generator_In_Fibonacci_Sequence(int count, int[] expected)
        {
            var previous = 1;
            var current = 2;

            var fibonacciGenerator = new SecondSequenceGenerator(previous, current);
            var list = new List<int>(count)
            {
                fibonacciGenerator.Previous,
                fibonacciGenerator.Current
            };

            for (int i = 1; i <= count - 2; i++)
            {
                list.Add(fibonacciGenerator.Next);
            }

            CollectionAssert.AreEqual(expected, list.ToArray());
            Assert.That(fibonacciGenerator.Count == count);
        }
    }

    public class ThirdSequenceGeneratorTests
    {
        [TestCase(10, new double[] { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 })]
        public void GetNext_Should_Advance_Generator_In_Fibonacci_Sequence(int count, double[] expected)
        {
            var previous = 1;
            var current = 2;

            var fibonacciGenerator = new ThirdSequenceGenerator(previous, current);
            var list = new List<double>(count)
            {
                fibonacciGenerator.Previous,
                fibonacciGenerator.Current
            };

            for (int i = 1; i <= count - 2; i++)
            {
                list.Add(fibonacciGenerator.Next);
            }

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(list[i], Is.EqualTo(expected[i]).Within(1e-10));
            }

            Assert.That(fibonacciGenerator.Count == count);
        }
    }
}