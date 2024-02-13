
ForLoop();
WhileLoop();
DoWhileLoop();
ForEachLoop();

if (IsPrimeNumber(7))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is not a prime number");
}


static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            break;
        }
    }
    return result;
}



void ForLoop()
{
    for (int i = 1; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}

void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 0);
}

void ForEachLoop()
{
    string[] students = new[] { "Burak", "Engin", "Derin", "Zehra", "Beyza" };

    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}