Console.Write("Введите превое число: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);

Console.Write ("Введите второе число: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);


if (number1 > number2 )
{
    Console.Write("Наибольшее число: ");
    Console.Write(number1);
}
else
{
    Console.Write("Наибольшее число: ");
    Console.Write(number2);
}