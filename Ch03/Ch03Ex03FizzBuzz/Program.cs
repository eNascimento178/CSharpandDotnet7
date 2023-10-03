/*
Switch Statements version
static string fizzBuzz (int n) =>
    (n % 3, n % 5) switch
    {
        (0, 0) => "FizzBuzz",
        (0, _) => "Fizz",
        (_, 0) => "Buzz",
        _ => n.ToString()
    };
*/

/*
If-Else version
static string fizzBuzz (int n) 
{
    if (n % 15 == 0)
    {
        return "FizzBuzz";
    }
    else if (n % 3 == 0)
    {
        return "Fizz";
    }
    else if (n % 5 == 0)
    {
        return "Buzz";
    }
    else
    { 
        return n.ToString();
    }
}
*/

static string fizzBuzz(int n) => n switch
{
    int _ when n % 15 == 0 => "FizzBuzz",
    int _ when n % 3 == 0 => "Fizz",
    int _ when n % 5 == 0 => "Buzz",
    _ => n.ToString()
};

for (int n = 1; n <= 100; n++)
{
    Console.Write(fizzBuzz(n));
    if (n != 100)
    {
        Console.Write(", ");
    }
    else
    {
        Console.WriteLine(".");
    }
}