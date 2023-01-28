// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Decision(int number)
{
    int count = Convert.ToString(number).Length;
    int result = 0;
    int value = 0;
    for (int i = 0; i < count; i++)
    {
        value = number - number % 10;
        result = result + (number - value);
        number = number / 10;
    }
    return result;
}

int number = InputInt("Введите натуральное целое число");
System.Console.WriteLine($"Сумма цифер в числе {number} равна {Decision(number)}");