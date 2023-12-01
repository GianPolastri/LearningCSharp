
public class MyFirstConsoleApp
{
  
    static void Main(string[] args)
    {
        WriteSomething();
        WriteSomethingSpecific("I am an argument and called form a method");
        Console.Read();
    }

    //Access modifier (static) return type method name (parameter1, parameter2)
    public static void WriteSomething()
    {
        Console.WriteLine("I am  called form a Method");
    }

    public static void WriteSomethingSpecific(string myText)
    {
        Console.WriteLine(myText);
    }
}
 