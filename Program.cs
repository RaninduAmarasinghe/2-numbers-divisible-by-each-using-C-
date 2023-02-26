namespace divisible_by_each;
class Program
{
    static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Enter number 1");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter numer 2");
        num2 = int.Parse(Console.ReadLine());
        if (num1 % num2 == 0)
        {
            Console.WriteLine("Numbers are divisible by each other");
        }
        else
        {
            Console.WriteLine("Numbers are not divisible by each other");
        }
        Console.ReadLine();
    }
}

