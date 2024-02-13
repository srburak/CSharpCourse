Add();

//Topla
var result = Topla(5, 3);
Console.WriteLine(result);


//Topla2
int number1 = 20;
int number2 = 100;
var result2 = Topla2(ref number1, number2);
Console.WriteLine(result2);
Console.WriteLine(number1);

//Multiply
Console.WriteLine(Multiply(5, 9));

Console.WriteLine(Topla3(5, 6, 6, 8, 4));
static void Add()
{
    Console.WriteLine("Added!");
}

static int Topla(int number1=20, int number2=30)
{
    var result = number1 + number2;
    return result;
}


static int Topla2(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}


static int Multiply(int number1, int number2)
{
    return number1 * number2;
}

//static int Multiply(int number1, int number2, int number3)
//{
//    return number1 * number2 * number3;
//}


static int Topla3(int number, params int[] numbers)
{
    return numbers.Sum();
}
