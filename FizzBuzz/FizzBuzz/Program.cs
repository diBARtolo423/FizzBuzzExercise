class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(Whiteboard(15));
        //Console.WriteLine(Whiteboard(20));
        //Console.WriteLine(Whiteboard(9));
        //Console.WriteLine(Whiteboard(0));


        //Console.WriteLine("Enter number");
        //string entry = Console.ReadLine();
        //value = int.Parse(entry);

        Console.WriteLine("Enter a number");

        var userinput = int.Parse(Console.ReadLine());
        Console.WriteLine(Whiteboard(userinput));



    }
    public static string Whiteboard(int x)
    {
        if ((x % 3 == 0) && (x % 5 == 0))
        {
            return "fizzbuzz";
        }
        else if (x % 3 == 0)
        {
            return "fizz";
        }
        else if (x % 5 == 0)
        {
            return "buzz";
        }
        else
        {
            return "try again";
        }
    }
}