// See https://aka.ms/new-console-template for more information


public class Arithmetic
{
    public int Add(int x,int y)
    {
        return x + y;
    }
    public int Sub(int x, int y)
    {
        return x - y;
    }
    public int Mul(int x, int y)
    {
        return x * y;
    }
    public int Div(int x, int y)
    {
        return x / y;
    }

}
namespace JenKinsConApp
{
    public class Program
    {
        public static void Main(String[] args)
        {
             Arithmetic arithmetic = new Arithmetic();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to the Console Application");
            Console.WriteLine("Here We are Running this application and Testing it using Jenkins");
            Console.WriteLine("Addition of Two Numbers: " + arithmetic.Add(10, 20));
            Console.WriteLine("Subtraction of Two Numbers: " + arithmetic.Sub(20, 10));
            Console.WriteLine("Multiplication of Two Numbers: " + arithmetic.Mul(10, 20));
            Console.WriteLine("Division of Two Numbers: " + arithmetic.Div(50, 25));
        }
    }
}
