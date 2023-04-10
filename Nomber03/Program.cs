Console.Write("Введите превое число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

if (number % 2 == 0)
{
    Console.Write("Число является четным");
}
else
{
    Console.Write("Число не является четным");
}
