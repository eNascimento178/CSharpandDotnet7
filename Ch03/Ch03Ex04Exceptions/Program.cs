checked
{
    try
    {
        Console.Write("Enter a number between 0 and 255: ");
        byte a = byte.Parse(Console.ReadLine()!);
        Console.Write("Enter another number between 0 and 255: ");
        byte b = byte.Parse(Console.ReadLine()!);
        int div = a / b;
        Console.WriteLine($"{a} divided by {b} is {div}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"{e.GetType()}: {e.Message}");
    }
}

