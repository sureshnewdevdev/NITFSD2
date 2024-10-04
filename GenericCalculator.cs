using System;
//Generic delegates and generic Delegates, Generic Classes


namespace GenericDelegatesAndClassesExample
{
    // Generic delegate definition
    public delegate T OperationDelegate<T>(T a, T b);

    // Generic class definition
    public class GenericCalculator<T>
    {
        // A generic method in a generic class
        public T Add(T a, T b, OperationDelegate<T> operation)
        {
            return operation(a, b);  // Call the delegate method
        }
    }

    class Program
    {
        // Methods that match the generic delegate signature
        public static int AddIntegers(int a, int b)
        {
            return a + b;
        }

        public static double AddDoubles(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Example using the generic class with integers
            GenericCalculator<int> intCalculator = new GenericCalculator<int>();
            OperationDelegate<int> intAddDelegate = AddIntegers;
            int intResult = intCalculator.Add(5, 10, intAddDelegate);
            Console.WriteLine($"Integer Addition: {intResult}");  // Output: 15

            // Example using the generic class with doubles
            GenericCalculator<double> doubleCalculator = new GenericCalculator<double>();
            OperationDelegate<double> doubleAddDelegate = AddDoubles;
            double doubleResult = doubleCalculator.Add(3.5, 4.5, doubleAddDelegate);
            Console.WriteLine($"Double Addition: {doubleResult}");  // Output: 8.0

            Console.ReadKey();
        }
    }
}
