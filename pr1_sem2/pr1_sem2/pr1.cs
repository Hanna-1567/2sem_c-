using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_sem2
{
    internal class pr1
    {
        //1.2.1



        //public  delegate double MathOperation(double a, double b);
        //public static double Add(double a, double b)
        //{
        //    return a + b;
        //}
        //public static double Subtract(double a, double b)
        //{
        //    return a - b;
        //}
        //public static double Multiply(double a, double b)
        //{
        //    return a * b;
        //}
        //public static double Divide(double a, double b)
        //{
        //    if (b == 0)
        //    {
        //        throw new DivideByZeroException("Cannot divide by zero.");
        //    }
        //    return a / b;
        //}
        //static void Main()
        //{
        //    MathOperation operation;
        //    double a = 4;
        //    double b = 8;

        //    operation = Add;
        //    Console.WriteLine($"Addition: {operation(a, b)}");

        //    operation = Subtract;
        //    Console.WriteLine($"Subtraction: {operation(a, b)}");

        //    operation = Multiply;
        //    Console.WriteLine($"Multiplication: {operation(a, b)}");

        //    operation = Divide;
        //    Console.WriteLine($"Division: {operation(a, b)}");
        //}



        //2.2.1


        //public delegate void NotificstionHandler(string message);

        //public static void SendEmail(string message)
        //{
        //    Console.WriteLine($"Email sent: {message}");
        //}

        //public static void SendSms(string message)
        //{
        //    Console.WriteLine($"SMS sent: {message}");
        //}

        //static void Main()
        //{
        //    NotificstionHandler notify = null;

        //    notify += SendEmail;
        //    notify += SendSms;

        //    notify("Hello, this is a notification!");
        //}


        //3.2.1


        //public delegate bool FilterPredicate(int number);

        //public static void FilterArray(int[] numbers, FilterPredicate predicate)
        //{
        //    foreach (int num in numbers)
        //    {
        //        if (predicate(num))
        //        {
        //            Console.WriteLine(num + " ");
        //        }
        //    }
        //    Console.WriteLine();

        //}

        //public static void Main()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    Console.WriteLine("Even numbers:");
        //    FilterArray(numbers, IsEven);

        //    Console.WriteLine("Numbers greater than 5:");
        //    FilterArray(numbers, ThenFive);

        //}

        //public static bool IsEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public static bool ThenFive(int number)
        //{
        //    return number > 5;
        //}


        //4.2.1
        //public static double Add(double a, double b)
        //{
        //    return a + b;
        //}
        //public static double Subtract(double a, double b)
        //{
        //    return a - b;
        //}
        //public static double Multiply(double a, double b)
        //{
        //    return a * b;
        //}
        //public static double Divide(double a, double b)
        //{
        //    if (b == 0)
        //    {
        //        throw new DivideByZeroException("Cannot divide by zero.");
        //    }
        //    return a / b;
        //}
        //static void Main()
        //{
        //    Func<double, double, double> operation;
        //    double a = 4;
        //    double b = 8;

        //    operation = Add;
        //    Console.WriteLine($"Addition: {operation(a, b)}");

        //    operation = Subtract;
        //    Console.WriteLine($"Subtraction: {operation(a, b)}");

        //    operation = Multiply;
        //    Console.WriteLine($"Multiplication: {operation(a, b)}");

        //    operation = Divide;
        //    Console.WriteLine($"Division: {operation(a, b)}");


        //    Console.WriteLine();


        //    List<string> student = new List<string> { 
        //        "Alice", 
        //        "Bob", 
        //        "Charlie", 
        //        "David",
        //        "Bil",
        //        "Bobby",
        //        "Ann"
        //    };

        //    List<string> result = student.FindAll(
        //        name => name.StartsWith("B")
        //    );

        //    Console.WriteLine("Students whose names start with 'B':");

        //    foreach (string name in result)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}


        //5.2.1

        //public class Logger
        //{
        //    public Action<string> LogHandler;

        //    public void Log(string message)
        //    {
        //        LogHandler?.Invoke(message);
        //    }
        //}
        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Logger logger = new Logger();

        //        logger.LogHandler = ms => Console.WriteLine($"Log: {ms}");

        //        logger.Log("This is a log message.");

        //        logger.LogHandler = ms => Console.WriteLine(ms.ToUpper());

        //        logger.Log("This is another log message.");
        //    }
        //}
    }
}
