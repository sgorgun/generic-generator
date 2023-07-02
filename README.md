# Generic Sequence Generator

Your task is to design and implement a framework for generating sequences in a flexible and reusable manner. To achieve this, you will create an `interface`, an `abstract class`, and a `specific` sequence generator implementations.

### Interface: ISequenceGenerator<T>

- Create a generic interface called `ISequenceGenerator<T>`.
- Define the following properties:
    - Previous of type `T`, representing the previous element in the sequence.
    - Current of type `T`, representing the current element in the sequence.
    - Next of type `T`, representing the next element in the sequence.

### Abstract Class: SequenceGenerator<T>

- Create an abstract class called `SequenceGenerator<T>` that implements the `ISequenceGenerator<T>` interface.
- Provide a constructor that takes in initial values for `Previous` and `Current`. Inside the constructor, set the initial values and initialize any necessary variables.
- Implement the properties `Previous` and `Current` with appropriate accessors.
- Define a public property `Count` of type int, representing the number of elements generated in the sequence. The property should have a public getter and a private setter.
- Define an abstract method called `GetNext()` that returns an element of type `T` of the specific sequence.

### Sequence Generator Implementation: FibonacciSequenceGenerator

- Create a class called `FibonacciSequenceGenerator` that inherits from `SequenceGenerator<int>`.
- Implement the `GetNext()` method to generate the next Fibonacci number based on the previous and current values. The Fibonacci sequence starts with two initial values (e.g., 0 and 1), and each subsequent number is the sum of the previous two.
- Create a constructor for `FibonacciSequenceGenerator` that takes in the initial previous and current values.

Your task is to complete the implementation of the `FibonacciSequenceGenerator` class and use it as an example to understand how the framework works. However, you should also extend the framework by creating additional sequence generator classes by inheriting from `SequenceGenerator<T>` and overriding the GetNext() method to generate different types of sequences e.g.  

    $`x_1 = 1, x_2 = 2, x_{n + 1} = 6 x_n - 8 x_{n - 1}, n = 2, 3, ... ,`$ where T - integer    
    $`x_1 = 1, x_2 = 2, x_{n + 1} = x_n +  x_{n - 1} / x_{n}, n = 2, 3, ...,`$ where T - double 
etc.
