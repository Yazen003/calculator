while (true)
{
    try
    {
        Console.WriteLine("Choose +  -  /  *  ");
        char operation = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter First Number :");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number :");
        int num2 = Convert.ToInt32(Console.ReadLine());
        double result;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result = {result}");
                break;
            case '/':
                result = num1 / num2;
                Console.WriteLine($"Result = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result = {result}");
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine("You want to exit?");
    string exit = Console.ReadLine();

    if (exit.ToLower() == "yes" || exit.ToLower() == "y")
    {
        break;
    }
}