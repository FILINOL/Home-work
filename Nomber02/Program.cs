Console.Write("Введите превое число: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);

Console.Write ("Введите второе число: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);

Console.Write ("Введите третье число: ");
string text3 = Console.ReadLine();
int number3 = Convert.ToInt32(text3);

int max = 0;

if (number1 > number2 )
{
    max = number1; 
}
if (number2 > number1 )
{
    max = number2;
}
if (number3 > max )
{
    Console.Write("Наибольшее число: ");
    Console.Write(number3);
}
else
{
    Console.Write("Наибольшее число: ");
    Console.Write(max);
}
