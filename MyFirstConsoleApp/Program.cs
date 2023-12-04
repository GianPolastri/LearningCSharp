
public class MyFirstConsoleApp
{
  
    static void Main(string[] args)
    {
        WriteSomething();
        WriteSomethingSpecific("I am an argument and called form a method");
        Console.WriteLine(Add(15, 22));
        Console.WriteLine(Multiply(25, 25));
        Console.WriteLine(Devide(25, 13));
        string input = Console.ReadLine();
        Console.WriteLine(input);
        Calculator();
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

    public static void Calculator()
    {
        Console.WriteLine("Write the two numbers you wanna add up:");
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();

        int result = Int32.Parse(num1) + Int32.Parse(num2);
        Console.WriteLine("The result is: " + result);
    }
}
 