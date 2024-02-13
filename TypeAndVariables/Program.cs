Console.WriteLine("Hello, World!");

//Value types
int number1 = 2147483647; // -2147483648 to 2147483647
long number2 = 9223372036854775807; // -9223372036854775808 to 9223372036854775807
short number3 = 32767; // -32768 to 32767
byte number4 = 255; // 0 to 255
bool condition = true; // true or false
char character = 'A'; // Unicode characters
double number5 = 10.4; // -1.7 x 10^308 to 1.7 x 10^308
decimal number6 = 10.5M; // (-7.9 x 10^28 to 7.9 x 10^28) / (10^0 to 28)
var number7 = 10; // Implicitly typed local variables
number7 = 'A'; // Error: Cannot implicitly convert type 'char' to 'int

Console.WriteLine("Number1 is {0}",number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Character is {0}", (int)character);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine((int)Days.Friday);
Console.WriteLine("Number7 is {0}",number7);

enum Days
{
    Monday=10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday, Sunday
};