
static void operation ()
{
    checked
    {
        int max = 500;
        
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
    }
}


try
{
    operation();
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
