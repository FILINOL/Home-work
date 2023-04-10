Console.Write("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int input = 2;

while (input <= number)
{
    Console.WriteLine(input);
    input = input + 2;
}