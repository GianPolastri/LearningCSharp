
public class MyFirstConsoleApp
{
  
    static void Main(string[] args)
    {
        WriteSomething();
        WriteSomethingSpecific("I am an argument and called form a method");
        Console.WriteLine(Add(15, 22));
        Console.WriteLine(Multiply(25, 25));
        Console.WriteLine(Devide(25, 13));
Console.Read();
    }

    //Access modifier (static) return type method name (parameter1, parameter2)
    public static void WriteSomething()
    {
        Console.WriteLine("I am  called form a Method");
    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public static double Devide(double num1, double num2)
    {
        return num1 / num2;
    }

    public static void WriteSomethingSpecific(string myText)
    {
        Console.WriteLine(myText);
    }
}
 