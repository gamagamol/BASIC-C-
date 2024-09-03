using System.ComponentModel;


public class Cashier()
{

    string CashierName;
    int TotalCash;


    static void Main()
    {

        string? name, greetings;
        int x, y;
        HeaderApplication();
        Console.WriteLine("Please Insert Your Name:");
        name = Console.ReadLine()!;

        greetings = GetUserName(name);
        Console.WriteLine(greetings);

        Console.WriteLine("Insert Number 1 :");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert Number 2 :");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Result is:"+" "+CalculateNumber(x, y));


    }

    static void HeaderApplication()
    {
        Console.WriteLine("Welcome To My Application");
    }

    static int CalculateNumber(int x, int y)
    {
        return x + y;
    }

    static string GetUserName(string name)
    {
        return "Hai" + " "+name;
    }


}


